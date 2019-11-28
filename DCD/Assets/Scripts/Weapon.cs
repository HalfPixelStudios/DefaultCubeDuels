using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Timer))]
public class Weapon : MonoBehaviour {

    //public bool consumable;

    public GameObject projectile;
    public GameObject projectile_spawn_point;
    public Vector3 starting_velocity;

    public float fire_cooldown;

    Timer shoot_timer;

    void Start() {

        shoot_timer = GetComponent<Timer>();
        shoot_timer.duration = fire_cooldown;
    }

    void Update() {
        info = GetComponentInParent<PlayerInfo>();
        if (info == null) return;

        if (info.useInput >= info.inputThreshold && !shoot_timer.isActive) { //shoot weapon
            shoot_timer.activate();
            
            //spawn projectile
            GameObject p = Instantiate(projectile,projectile_spawn_point.transform.position,Quaternion.identity);
            p.GetComponent<Rigidbody>().velocity = starting_velocity;
            
        }
        


    }


}
