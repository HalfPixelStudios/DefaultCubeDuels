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
    public float move_speed = 5f;

    //Jump
    public GameObject jumpTrigger;
    Timer jumpTimer;
    public float fall_g_multiplier = 2.5f;
    public float lowJump_g_multiplier = 2f;

    void Awake() {

        //Physics
        rb = GetComponent<Rigidbody>();

        //Input
        inputAction = new PlayerInputActions();

        inputAction.PlayerControls.Move.performed += ctx => moveInput = ctx.ReadValue<Vector2>();
        inputAction.PlayerControls.Jump.performed += ctx => jumpInput =  ctx.ReadValue<float>();

        //Jump
        jumpTimer = jumpTrigger.GetComponent<Timer>();
        jumpTimer.duration = 0.2f;
    }

    void Update() {

        //MOVEMENT
        if (Mathf.Abs(moveInput.x) >= inputThreshold) {
            rb.velocity = new Vector3(moveInput.x * move_speed, rb.velocity.y, rb.velocity.z);
        }

        //JUMP
        if (jumpInput >= inputThreshold && !jumpTimer.isActive && jumpTrigger.GetComponent<FloorDetector>().isOnGround) { //threshold for jump input
            jumpTimer.activate();
        }
        if (jumpInput >= inputThreshold && jumpTimer.isActive) {
            rb.velocity = new Vector3(rb.velocity.x,6f,rb.velocity.z);
        }
        if (jumpInput < inputThreshold) {
            jumpTimer.deactivate();
        }

        //modify gravity for jump
        if (rb.velocity.y < 0) { //if player is falling, apply gravity scale
            rb.velocity += Vector3.up * Physics.gravity.y * (fall_g_multiplier - 1) * Time.deltaTime;
        } else if (rb.velocity.y > 0 && jumpInput < inputThreshold) {
            rb.velocity += Vector3.up * Physics.gravity.y * (lowJump_g_multiplier - 1) * Time.deltaTime;
        }

        
    }



    private void OnEnable() { inputAction.Enable(); }
    private void OnDisable() { inputAction.Disable(); }
}
