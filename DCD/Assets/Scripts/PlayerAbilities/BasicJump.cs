using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

[RequireComponent(typeof(Timer))]
public class BasicJump : MonoBehaviour {

    //Info
    PlayerInfo info;

    //Jump
    public GameObject jumpTrigger;
    [SerializeField] private float maxHoldTime, fallGFactor, lowJumpGFactor;
    Timer jumpTimer;

    void Start() {
        info = gameObject.GetComponentInParent<PlayerInfo>();

        //Jump
        jumpTimer = GetComponent<Timer>();
        jumpTimer.duration = maxHoldTime;
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
            info.rb.velocity += Vector3.up * Physics.gravity.y * (fallGFactor - 1) * Time.deltaTime;
        } else if (info.rb.velocity.y > 0 && info.jumpInput < info.inputThreshold) {
            info.rb.velocity += Vector3.up * Physics.gravity.y * (lowJumpGFactor - 1) * Time.deltaTime;
        }

    }
}
