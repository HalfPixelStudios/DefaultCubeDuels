using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabableObject : MonoBehaviour {

    public bool two_hand_hold;
    public GameObject grab_point; //used to determine offset

    [HideInInspector] public GameObject owner;
   
}