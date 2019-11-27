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

    public float mouse_angle; //in degrees
    [HideInInspector] public Vector2 cursorInput; //ONLY FOR CONTROLLERS
    [HideInInspector] public Vector2 moveInput;
    [HideInInspector] public float jumpInput;
    [HideInInspector] public float dashInput;
    [HideInInspector] public float interactInput;
    [HideInInspector] public float throwInput;
    [HideInInspector] public float useInput;

    Ray mouse_ray;

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
            inputAction.PlayerControls.P1Use.performed += ctx => useInput = ctx.ReadValue<float>();
        } else if (playerNumber == 2) {
            inputAction.PlayerControls.P2Aim.performed += ctx => cursorInput = ctx.ReadValue<Vector2>();
            inputAction.PlayerControls.P2Move.performed += ctx => moveInput = ctx.ReadValue<Vector2>();
            inputAction.PlayerControls.P2Jump.performed += ctx => jumpInput = ctx.ReadValue<float>();
            inputAction.PlayerControls.P2Dash.performed += ctx => dashInput = ctx.ReadValue<float>();
            inputAction.PlayerControls.P2Interact.performed += ctx => interactInput = ctx.ReadValue<float>();
            inputAction.PlayerControls.P2Throw.performed += ctx => throwInput = ctx.ReadValue<float>();
            inputAction.PlayerControls.P2Use.performed += ctx => useInput = ctx.ReadValue<float>();
        }


    }

    void Update() {
        
        //Get mouse position
        if (playerNumber == 1) { //ray cast onto a plane to determine mouse position in 3d space
            Plane surface = new Plane(Vector3.forward,0);

            mouse_ray = Camera.main.ScreenPointToRay(Input.mousePosition);


            float dist_to_plane;
            if (surface.Raycast(mouse_ray,out dist_to_plane)) {
                Vector3 mouse_pos = mouse_ray.GetPoint(dist_to_plane);
                mouse_angle = Mathf.Atan2(mouse_pos.y-transform.position.y,mouse_pos.x-transform.position.x)*Mathf.Rad2Deg;
            }

        } else if (playerNumber == 2 && cursorInput != Vector2.zero) {
            mouse_angle = Mathf.Atan2(cursorInput.y,cursorInput.x) * Mathf.Rad2Deg;
        }
        //Debug.Log(mouse_angle);
    }

    private void OnDrawGizmos() {
        Gizmos.DrawRay(mouse_ray);
    }


    private void OnEnable() { inputAction.Enable(); }
    private void OnDisable() { inputAction.Disable(); }
}
