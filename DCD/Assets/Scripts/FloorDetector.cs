﻿using System.Collections;
using System.Collections.Generic;
using static GlobalContainer;
using UnityEngine;

public class FloorDetector : MonoBehaviour {

    public bool isOnGround;

    void FixedUpdate() {
        isOnGround = false;
    }

    private void OnTriggerStay(Collider other) {

        if (self.ground_layers.Contains(other.gameObject.layer)) {
            isOnGround = true;
        }
        
    }

}
