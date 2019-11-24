using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//https://github.com/FirstGearGames/SuperCam
public class FocusCamera : MonoBehaviour {

    public List<GameObject> players;
    public FocusBounds focusBounds;


    //update speed
    public float depthUpdateSpeed;
    public float angleUpdateSpeed;
    public float positionUpdateSpeed;

    public float min_depth;
    public float max_depth;

    public float min_angle;
    public float max_angle;

    private float target_angle;
    private Vector3 target_pos;

    void Start() {
        players.Add(focusBounds.gameObject);
    }

    void LateUpdate() {
        UpdateCam();
        MoveCam();
    }


    //TODO: possibly give all players in bounds a weight of 2, and the map center and players out of bound a weight of 1
    private void MoveCam() {
        Vector3 cur_pos = gameObject.transform.position;
        if (cur_pos != target_pos) {
            //update position of cam
            Vector3 new_pos = Vector3.zero;
            new_pos.x = Mathf.MoveTowards(cur_pos.x, target_pos.x, positionUpdateSpeed * Time.deltaTime);
            new_pos.y = Mathf.MoveTowards(cur_pos.y, target_pos.y, positionUpdateSpeed * Time.deltaTime);
            new_pos.z = Mathf.MoveTowards(cur_pos.z, target_pos.z, depthUpdateSpeed * Time.deltaTime);
            gameObject.transform.position = new_pos;
        }

        Vector3 cur_angle = gameObject.transform.localEulerAngles;
        if (cur_angle.x != target_angle) {
            //update tilt of cam
            Vector3 new_angle = new Vector3(target_angle,cur_angle.y,cur_angle.z);
            gameObject.transform.localEulerAngles = Vector3.MoveTowards(cur_angle, new_angle, angleUpdateSpeed*Time.deltaTime);

        }
    }

    private void UpdateCam() { //also modifies zoom and angle
        Vector3 avgCenter = Vector3.zero;
        Vector3 totPos = Vector3.zero;
        Bounds newBound = new Bounds();

        Bounds b = focusBounds.bound;
        foreach (GameObject player in players) {
            Vector3 pos = player.transform.position;

            if (!b.Contains(pos)) { //if player pos is not inside the bound size, we don't care about them as much
                float x = Mathf.Clamp(pos.x,b.min.x,b.max.x);
                float y = Mathf.Clamp(pos.y, b.min.y, b.max.y);
                float z = Mathf.Clamp(pos.z, b.min.z, b.max.z);
                pos = new Vector3(x, y, z);
            }

            totPos += pos;
            newBound.Encapsulate(pos);
        }

        avgCenter = totPos / players.Count;

        float extents = newBound.extents.x + newBound.extents.y;
        float lerpPercent = Mathf.InverseLerp(0, (focusBounds.dims.x+focusBounds.dims.y)/4f,extents);

        //The closer the players are, the closer the camera will zoom
        float depth = Mathf.Lerp(max_depth, min_depth, lerpPercent);
        
        //apply changes
        target_angle = Mathf.Lerp(max_angle, min_angle, lerpPercent);
        target_pos = new Vector3(avgCenter.x,avgCenter.y,depth);

    }
}
