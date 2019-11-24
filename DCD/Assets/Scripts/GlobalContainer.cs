using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Holds global vars
public class GlobalContainer : MonoBehaviour {

    public static GlobalContainer self;

    public List<int> ground_layers;

    public int pickup_layer;

    void Awake() {
        self = this;
    }

}
