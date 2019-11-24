using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dash : Timer {

    //Info
    PlayerInfo info;

    //Dash
    public bool affected_by_gravity;

    public float dash_speed;
    public float dash_duration;
    public float dash_cooldown;

    float dash_direct = 1;

    void Start() {
        base.Start();

        info = gameObject.GetComponentInParent<PlayerInfo>();

        duration = dash_duration;
        cooldown = dash_cooldown;
    }

    void Update() {
        base.Update();

        if (Mathf.Abs(info.dashInput) >= info.inputThreshold && !isActive) {
            activate();
        }
        
    }

    public override void activate() {
        base.activate();
        
        if (Mathf.Abs(info.moveInput.x) < info.inputThreshold) { return; }
        dash_direct = info.moveInput.x / Mathf.Abs(info.moveInput.x); //normalize the input

    }

    public override void passiveEffect() {
        info.moveInput.x = 0; //kinda brute force, but this wrestles control out of the move ability (CHANGE LATER)
        float y = affected_by_gravity ? info.rb.velocity.y : 0;
        info.rb.velocity = new Vector3(dash_speed*dash_direct,y,info.rb.velocity.z);
    }

}
