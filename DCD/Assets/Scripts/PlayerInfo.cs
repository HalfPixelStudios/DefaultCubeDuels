using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInfo : MonoBehaviour {

    //Physics
    [HideInInspector] public Rigidbody rb;

    //Input
    [Range(1,2)] public int playerNumber;

    [HideInInspector] public PlayerInputActions inputAction;
    public float inputThreshold;

    [HideInInspector] public Vector2 moveInput;
    [HideInInspector] public float jumpInput;
    [HideInInspector] public float dashInput;
    [HideInInspector] public float interactInput;
    [HideInInspector] public float throwInput;



    void Awake() {

        //Physics
        rb = GetComponent<Rigidbody>();

        //Input
        inputAction = new PlayerInputActions();

        if (playerNumber == 1) {
            inputAction.PlayerControls.P1Move.performed += ctx => moveInput = ctx.ReadValue<Vector2>();
            inputAction.PlayerControls.P1Jump.performed += ctx => jumpInput = ctx.ReadValue<float>();
            inputAction.PlayerControls.P1Dash.performed += ctx => dashInput = ctx.ReadValue<float>();
            inputAction.PlayerControls.P1Interact.performed += ctx => interactInput = ctx.ReadValue<float>();
            inputAction.PlayerControls.P1Throw.performed += ctx => throwInput = ctx.ReadValue<float>();
        } else if (playerNumber == 2) {
            inputAction.PlayerControls.P2Move.performed += ctx => moveInput = ctx.ReadValue<Vector2>();
            inputAction.PlayerControls.P2Jump.performed += ctx => jumpInput = ctx.ReadValue<float>();
            inputAction.PlayerControls.P2Dash.performed += ctx => dashInput = ctx.ReadValue<float>();
            inputAction.PlayerControls.P2Interact.performed += ctx => interactInput = ctx.ReadValue<float>();
            inputAction.PlayerControls.P2Throw.performed += ctx => throwInput = ctx.ReadValue<float>();
        }


    }




    private void OnEnable() { inputAction.Enable(); }
    private void OnDisable() { inputAction.Disable(); }
}
