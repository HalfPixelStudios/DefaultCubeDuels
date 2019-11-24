using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    //Physics
    Rigidbody rb;

    //Input
    [Range(1,2)] public int playerNumber;

    PlayerInputActions inputAction;
    Vector2 moveInput;
    float jumpInput;

    float inputThreshold = 0.1f;

    //Movement
    public float move_speed;
    [Range(0f,1f)] public float horizontal_drag;

    //Jump
    public GameObject jumpTrigger;
    public float max_hold_time;
    Timer jumpTimer;
    public float fall_g_multiplier;
    public float lowJump_g_multiplier;

    void Awake() {

        //Physics
        rb = GetComponent<Rigidbody>();

        //Input
        inputAction = new PlayerInputActions();

        if (playerNumber == 1) {
            inputAction.PlayerControls.P1Move.performed += ctx => moveInput = ctx.ReadValue<Vector2>();
            inputAction.PlayerControls.P1Jump.performed += ctx => jumpInput = ctx.ReadValue<float>();
        } else if (playerNumber == 2) {
            inputAction.PlayerControls.P2Move.performed += ctx => moveInput = ctx.ReadValue<Vector2>();
            inputAction.PlayerControls.P2Jump.performed += ctx => jumpInput = ctx.ReadValue<float>();
        }

        //Jump
        jumpTimer = jumpTrigger.GetComponent<Timer>();
        jumpTimer.duration = max_hold_time;

    }

    void Update() {

        //MOVEMENT
        if (Mathf.Abs(moveInput.x) >= inputThreshold) {
            rb.velocity = new Vector3(moveInput.x * move_speed, rb.velocity.y, rb.velocity.z);
        }
  
        if (Mathf.Abs(rb.velocity.x) >= 0.1f) { //applying some horizontal damping
            rb.velocity = new Vector3(rb.velocity.x*horizontal_drag, rb.velocity.y, rb.velocity.z);
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
