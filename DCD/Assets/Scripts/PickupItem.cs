using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupItem : MonoBehaviour {

    public float pickup_radius;

    void Start() {
        
    }

    void Update() {
        Debug.Log(getClosestPickup());
    }

    
    private GameObject getClosestPickup() { 
        Collider[] cols = Physics.OverlapSphere(transform.position,pickup_radius, 1 << GlobalContainer.self.pickup_layer); //only look for colliders in pickup layer

        float best_dist = Mathf.Infinity;
        GameObject best_collider_object = null;
        foreach (Collider c in cols) {

            float dist = Vector3.Distance(transform.position,c.gameObject.transform.position);
            if (dist < best_dist) {
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
