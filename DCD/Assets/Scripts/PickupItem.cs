using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Handles picking up and throwing items

public class PickupItem : MonoBehaviour {

    PlayerInfo info;

    public float pickup_radius;
    public GameObject hold_point;
    public float hold_radius;

    public float throw_strength;

    GameObject equipped_item;

    void Start() {
        info = GetComponentInParent<PlayerInfo>();

    }

    void Update() {

        if (info.interactInput >= info.inputThreshold) { //if player presses the interact button
            GameObject pickup = getClosestPickup();
            if (pickup == null) { return; }

            equipped_item = pickup;
            pickup.transform.parent = hold_point.transform;
            pickup.transform.localPosition = -pickup.GetComponent<GrabableObject>().getHoldPoint();
            pickup.GetComponent<Rigidbody>().isKinematic = true;
            pickup.GetComponent<Collider>().isTrigger = true;
            
        }

        if (info.throwInput >= info.inputThreshold && equipped_item != null) { //throw item
           
            equipped_item.transform.parent = null;
            equipped_item.GetComponent<Rigidbody>().isKinematic = false;
            equipped_item.GetComponent<Collider>().isTrigger = false;
            equipped_item = null;
        }

        //Make item point towards cursor
        //if (equipped_item != null && Mathf.Abs(equipped_item.transform.rotation.x - info.mouse_angle) > 5) {
        if (equipped_item != null)
        {

            float xComp = Mathf.Cos(Mathf.Deg2Rad * info.mouse_angle);
            float yComp = Mathf.Sin(Mathf.Deg2Rad * info.mouse_angle);
            hold_point.transform.localPosition=
                new Vector3( xComp, yComp, hold_point.transform.position.z);
            hold_point.transform.rotation=Quaternion.Euler(info.mouse_angle,-90,0);
            equipped_item.transform.localRotation=info.mouse_angle>90? Quaternion.Euler(0,90,0):Quaternion.identity;

        }
    }

    private Vector3 rotateAroundPoint(Vector3 point, Vector3 pivot, Vector3 rotation) {
        Vector3 dir = point - pivot;
        dir = Quaternion.Euler(rotation) * dir;
        point = dir + pivot;
        return point;
    }

    private void softplus() {

    }
    
    private GameObject getClosestPickup() { 
        //Note: the layer mask is just to help limit the amount of things we are looking through
        Collider[] cols = Physics.OverlapSphere(transform.position,pickup_radius); 

        float best_dist = Mathf.Infinity;
        GameObject best_collider_object = null;
        foreach (Collider c in cols) {

            float dist = Vector3.Distance(transform.position,c.gameObject.transform.position);
            if (c.gameObject.GetComponent<GrabableObject>() != null && dist < best_dist) {
                best_dist = dist;
                best_collider_object = c.gameObject;
            }

        }

        return best_collider_object;
    }

    private void OnDrawGizmos() {
        Gizmos.color = Color.blue;
        Gizmos.DrawWireSphere(transform.position, pickup_radius);
    }
}
