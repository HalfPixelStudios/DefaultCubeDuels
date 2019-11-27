using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Timer))]
public class Weapon : MonoBehaviour {

    PlayerInfo info;

    //public bool consumable;

    public GameObject projectile;
    public GameObject projectile_spawn_point;
    public Vector3 starting_velocity;

    public float fire_cooldown;

    Timer shoot_timer;

    void Start() {
        info = GetComponentInParent<PlayerInfo>();

        shoot_timer = GetComponent<Timer>();
        shoot_timer.cooldown = fire_cooldown;
    }

    void Update() {
        
        if (info.useInput >= info.inputThreshold && !shoot_timer.isActive) { //shoot weapon
            shoot_timer.activate();

            //spawn projectile
            GameObject p = Instantiate(projectile,projectile_spawn_point.transform.position,Quaternion.identity);
            p.GetComponent<Rigidbody>().velocity = starting_velocity;

        }
        


    }


}
