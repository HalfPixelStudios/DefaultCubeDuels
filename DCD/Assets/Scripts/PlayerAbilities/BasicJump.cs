using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicJump : MonoBehaviour {

    //Info
    PlayerInfo info;

    //Jump
    public GameObject jumpTrigger;
    public float max_hold_time;
    public float fall_g_multiplier;
    public float lowJump_g_multiplier;

    Timer jumpTimer;

    void Start() {
        info = gameObject.GetComponentInParent<PlayerInfo>();

        //Jump
        jumpTimer = jumpTrigger.GetComponent<Timer>();
        jumpTimer.duration = max_hold_time;
    }

    void Update() {


        //JUMP
        if (info.jumpInput >= info.inputThreshold && !jumpTimer.isActive && jumpTrigger.GetComponent<FloorDetector>().isOnGround) { //threshold for jump input
            jumpTimer.activate();
        }
        if (info.jumpInput >= info.inputThreshold && jumpTimer.isActive) {
            info.rb.velocity = new Vector3(info.rb.velocity.x, 6f, info.rb.velocity.z);
        }
        if (info.jumpInput < info.inputThreshold) {
            jumpTimer.deactivate();
        }

        //modify gravity for jump
        if (info.rb.velocity.y < 0) { //if player is falling, apply gravity scale
            info.rb.velocity += Vector3.up * Physics.gravity.y * (fall_g_multiplier - 1) * Time.deltaTime;
        } else if (info.rb.velocity.y > 0 && info.jumpInput < info.inputThreshold) {
            info.rb.velocity += Vector3.up * Physics.gravity.y * (lowJump_g_multiplier - 1) * Time.deltaTime;
        }

    }
}
