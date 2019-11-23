using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    //Physics
    Rigidbody rb;

    //Input
    PlayerInputActions inputAction;
    Vector2 moveInput;
    float jumpInput;

    float inputThreshold = 0.1f;


    //Movement
    public float movement_force = 40f;
    public float max_horizontal_speed = 10f;

    //Jump
    public float fall_g_multiplier = 2.5f;
    public float lowJump_g_multiplier = 2f;

    void Awake() {

        //Physics
        rb = GetComponent<Rigidbody>();

        //Input
        inputAction = new PlayerInputActions();

        inputAction.PlayerControls.Move.performed += ctx => moveInput = ctx.ReadValue<Vector2>();
        inputAction.PlayerControls.Jump.performed += ctx => jumpInput =  ctx.ReadValue<float>();

    }

    void Update() {

        //MOVEMENT
        //rb.velocity = new Vector3(moveInput.x*5,rb.velocity.y,rb.velocity.z);
        rb.AddForce(Vector3.right*moveInput.x*movement_force);

        //JUMP
        if (jumpInput >= inputThreshold) { //threshold for jump input
            rb.velocity = new Vector3(rb.velocity.x,6f,rb.velocity.z);
        }

        if (rb.velocity.y < 0) { //if player is falling, apply gravity scale
            rb.velocity += Vector3.up * Physics.gravity.y * (fall_g_multiplier - 1) * Time.deltaTime;
        } else if (rb.velocity.y > 0 && jumpInput < inputThreshold) {
            rb.velocity += Vector3.up * Physics.gravity.y * (lowJump_g_multiplier - 1) * Time.deltaTime;
        }

        rb.velocity = new Vector3(Mathf.Clamp(rb.velocity.x, -max_horizontal_speed, max_horizontal_speed), rb.velocity.y, rb.velocity.z);
    }



    private void OnEnable() { inputAction.Enable(); }
    private void OnDisable() { inputAction.Disable(); }
}
