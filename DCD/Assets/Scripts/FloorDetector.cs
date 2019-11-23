using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorDetector : MonoBehaviour {

    public bool isOnGround;

    void FixedUpdate() {
        isOnGround = false;
    }

    private void OnTriggerStay(Collider other) {

        if (GlobalContainer.self.ground_layers.Contains(other.gameObject.layer)) {
            isOnGround = true;
        }
        
    }

}
