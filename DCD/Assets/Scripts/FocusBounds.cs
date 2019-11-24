using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//https://github.com/FirstGearGames/SuperCam
public class FocusBounds : MonoBehaviour {

    public Vector3 dims;

    public Bounds bound;


    void Update() {
        Vector3 pos = gameObject.transform.position;
        Bounds b = new Bounds();
        b.Encapsulate(new Vector3(pos.x+dims.x/2, pos.y + dims.y / 2, pos.z + dims.z / 2));
        b.Encapsulate(new Vector3(pos.x - dims.x / 2, pos.y - dims.y / 2, pos.z - dims.z / 2));
        bound = b;
    }
}
