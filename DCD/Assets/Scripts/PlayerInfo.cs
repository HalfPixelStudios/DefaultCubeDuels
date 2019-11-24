using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInfo : MonoBehaviour {

    //Physics
    [HideInInspector] public Rigidbody rb;

    //Input
    [Range(1,2)] public int playerNumber;

    [HideInInspector] public PlayerInputActions inputAction;
    [HideInInspector] public Vector2 moveInput;
    [HideInInspector] public float jumpInput;
    [HideInInspector] public float inputThreshold = 0.1f;


    void Awake() {

        //Physics
        rb = GetComponent<Rigidbody>();

        //Input
        inputAction = new PlayerInputActions();

        if (playerNumber == 1) {
            inputAction.PlayerControls.P1Move.performed += ctx => moveInput = ctx.ReadValue<Vector2>();
            inputAction.PlayerControls.P1Jump.performed += ctx => jumpInput = ctx.ReadValue<float>();
        } else if (playerNumber == 2) {
            inputAction.PlayerControls.P2Move.performed += ctx => moveInput = ctx.ReadValue<Vector2>();
            inputAction.PlayerControls.P2Jump.performed += ctx => jumpInput = ctx.ReadValue<float>();
        }


    }




    private void OnEnable() { inputAction.Enable(); }
    private void OnDisable() { inputAction.Disable(); }
}
