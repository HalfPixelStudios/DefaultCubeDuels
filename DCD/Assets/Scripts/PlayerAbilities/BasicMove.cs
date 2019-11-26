using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicMove : MonoBehaviour {

    //Info
    PlayerInfo info;

    //Movement
    public float move_speed;
    public float max_speed;
    [Range(0f, 1f)] public float horizontal_drag;

    void Start() {
        info = gameObject.GetComponentInParent<PlayerInfo>();
    }

    void Update() {
        //MOVEMENT
        if (Mathf.Abs(info.moveInput.x) >= info.inputThreshold) {
            info.rb.velocity = new Vector3(info.moveInput.x * move_speed, info.rb.velocity.y, info.rb.velocity.z);
            //info.rb.AddForce(Vector3.right * info.moveInput.x * move_speed);
        }

        
        if (Mathf.Abs(info.rb.velocity.x) >= 0.1f) { //applying some horizontal damping
            info.rb.velocity = new Vector3(info.rb.velocity.x * horizontal_drag, info.rb.velocity.y, info.rb.velocity.z);

        }
        else
        {
            info.rb.velocity = new Vector3(0,info.rb.velocity.y,info.rb.velocity.z);
        }

        //max speed
        //info.rb.velocity = new Vector3(Mathf.Clamp(info.rb.velocity.x, -max_speed, max_speed),info.rb.velocity.y, info.rb.velocity.z);
        
    }
}
