// GENERATED AUTOMATICALLY FROM 'Assets/PlayerInputActions.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerInputActions : IInputActionCollection, IDisposable
{
    private InputActionAsset asset;
    public @PlayerInputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInputActions"",
    ""maps"": [
        {
            ""name"": ""PlayerControls"",
            ""id"": ""053c4a8b-8442-4d21-bb59-81dd3c832d31"",
            ""actions"": [
                {
                    ""name"": ""P1Move"",
                    ""type"": ""PassThrough"",
                    ""id"": ""d3e78517-45b5-4d7b-8cc5-ddd0af4ca672"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""P1Jump"",
                    ""type"": ""PassThrough"",
                    ""id"": ""9fd9f99a-05a1-4c88-ab46-78d3ae4ad970"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""P1Dash"",
                    ""type"": ""PassThrough"",
                    ""id"": ""b80dbc60-2a89-4032-85e9-6a406a1a8f94"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""P1Interact"",
                    ""type"": ""PassThrough"",
                    ""id"": ""eaad41e6-ec58-4f74-92d9-d22212f333fb"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""P1Throw"",
                    ""type"": ""PassThrough"",
                    ""id"": ""55a4251a-354e-4611-8c28-8ddac8a19faa"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""P2Move"",
                    ""type"": ""PassThrough"",
                    ""id"": ""10872b97-2472-4632-bf9c-74b4ce85b273"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""P2Jump"",
                    ""type"": ""PassThrough"",
                    ""id"": ""ae9de151-a5a8-422c-8f72-8b2dc0eb4d0a"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""P2Dash"",
                    ""type"": ""PassThrough"",
                    ""id"": ""57f5566f-182e-4c24-a1d8-5f35fd8813a2"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""P2Interact"",
                    ""type"": ""PassThrough"",
                    ""id"": ""363863ac-5b2b-4172-88db-8315e0360680"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""P2Throw"",
                    ""type"": ""Button"",
                    ""id"": ""030876ff-8bad-41d1-93aa-6be5214d699d"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""P2Aim"",
                    ""type"": ""PassThrough"",
                    ""id"": ""4129eb83-2fd9-484e-bc69-699572448e6d"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""60909eef-76a0-4b1d-8be4-67d174b53052"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""P1Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""left"",
                    ""id"": ""973aaafb-a544-45b2-a22f-988d9e61230c"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and mouse"",
                    ""action"": ""P1Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""12f3af25-6b39-47b9-b791-c840076b801d"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and mouse"",
                    ""action"": ""P1Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""ffa2d0e4-879b-4a0a-9293-ab52976e6d3a"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and mouse"",
                    ""action"": ""P1Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""AnalogStick"",
                    ""id"": ""d0db1cfb-f128-470a-ba3d-dc83b74c52ee"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""P2Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""left"",
                    ""id"": ""bf831299-7067-4cfa-8941-f3eadee4982c"",
                    ""path"": ""<XInputController>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Xbox Gamepad"",
                    ""action"": ""P2Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""95d91f9e-6ed2-49d8-a45d-b56aa5fb560b"",
                    ""path"": ""<XInputController>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Xbox Gamepad"",
                    ""action"": ""P2Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""5b4faf7e-f433-4ff3-8a7f-01748b0e409c"",
                    ""path"": ""<XInputController>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Xbox Gamepad"",
                    ""action"": ""P2Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""076e22b2-81b7-4199-8676-c631b02122d2"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and mouse"",
                    ""action"": ""P1Dash"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1a8524f3-2897-4bf0-bd9b-0be73f10d0bf"",
                    ""path"": ""<XInputController>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Xbox Gamepad"",
                    ""action"": ""P2Dash"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8d0cdbef-b6d6-4405-848d-59fde7eea863"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and mouse"",
                    ""action"": ""P1Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9fd9b44c-ab9e-4e08-aa51-d2e78ad21fbe"",
                    ""path"": ""<XInputController>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Xbox Gamepad"",
                    ""action"": ""P2Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""eef64b8a-6fa2-487d-a645-76bf5d5e95a9"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and mouse"",
                    ""action"": ""P1Throw"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f6ee0f93-d961-4c01-80df-56209767c097"",
                    ""path"": ""<Keyboard>/b"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Xbox Gamepad"",
                    ""action"": ""P2Throw"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""86a34724-ccbe-435f-bfec-649f12f359de"",
                    ""path"": ""<XInputController>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Xbox Gamepad"",
                    ""action"": ""P2Aim"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard and mouse"",
            ""bindingGroup"": ""Keyboard and mouse"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Xbox Gamepad"",
            ""bindingGroup"": ""Xbox Gamepad"",
            ""devices"": [
                {
                    ""devicePath"": ""<XInputController>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // PlayerControls
        m_PlayerControls = asset.FindActionMap("PlayerControls", throwIfNotFound: true);
        m_PlayerControls_P1Move = m_PlayerControls.FindAction("P1Move", throwIfNotFound: true);
        m_PlayerControls_P1Jump = m_PlayerControls.FindAction("P1Jump", throwIfNotFound: true);
        m_PlayerControls_P1Dash = m_PlayerControls.FindAction("P1Dash", throwIfNotFound: true);
        m_PlayerControls_P1Interact = m_PlayerControls.FindAction("P1Interact", throwIfNotFound: true);
        m_PlayerControls_P1Throw = m_PlayerControls.FindAction("P1Throw", throwIfNotFound: true);
        m_PlayerControls_P2Move = m_PlayerControls.FindAction("P2Move", throwIfNotFound: true);
        m_PlayerControls_P2Jump = m_PlayerControls.FindAction("P2Jump", throwIfNotFound: true);
        m_PlayerControls_P2Dash = m_PlayerControls.FindAction("P2Dash", throwIfNotFound: true);
        m_PlayerControls_P2Interact = m_PlayerControls.FindAction("P2Interact", throwIfNotFound: true);
        m_PlayerControls_P2Throw = m_PlayerControls.FindAction("P2Throw", throwIfNotFound: true);
        m_PlayerControls_P2Aim = m_PlayerControls.FindAction("P2Aim", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    // PlayerControls
    private readonly InputActionMap m_PlayerControls;
    private IPlayerControlsActions m_PlayerControlsActionsCallbackInterface;
    private readonly InputAction m_PlayerControls_P1Move;
    private readonly InputAction m_PlayerControls_P1Jump;
    private readonly InputAction m_PlayerControls_P1Dash;
    private readonly InputAction m_PlayerControls_P1Interact;
    private readonly InputAction m_PlayerControls_P1Throw;
    private readonly InputAction m_PlayerControls_P2Move;
    private readonly InputAction m_PlayerControls_P2Jump;
    private readonly InputAction m_PlayerControls_P2Dash;
    private readonly InputAction m_PlayerControls_P2Interact;
    private readonly InputAction m_PlayerControls_P2Throw;
    private readonly InputAction m_PlayerControls_P2Aim;
    public struct PlayerControlsActions
    {
        private @PlayerInputActions m_Wrapper;
        public PlayerControlsActions(@PlayerInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @P1Move => m_Wrapper.m_PlayerControls_P1Move;
        public InputAction @P1Jump => m_Wrapper.m_PlayerControls_P1Jump;
        public InputAction @P1Dash => m_Wrapper.m_PlayerControls_P1Dash;
        public InputAction @P1Interact => m_Wrapper.m_PlayerControls_P1Interact;
        public InputAction @P1Throw => m_Wrapper.m_PlayerControls_P1Throw;
        public InputAction @P2Move => m_Wrapper.m_PlayerControls_P2Move;
        public InputAction @P2Jump => m_Wrapper.m_PlayerControls_P2Jump;
        public InputAction @P2Dash => m_Wrapper.m_PlayerControls_P2Dash;
        public InputAction @P2Interact => m_Wrapper.m_PlayerControls_P2Interact;
        public InputAction @P2Throw => m_Wrapper.m_PlayerControls_P2Throw;
        public InputAction @P2Aim => m_Wrapper.m_PlayerControls_P2Aim;
        public InputActionMap Get() { return m_Wrapper.m_PlayerControls; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerControlsActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerControlsActions instance)
        {
            if (m_Wrapper.m_PlayerControlsActionsCallbackInterface != null)
            {
                @P1Move.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnP1Move;
                @P1Move.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnP1Move;
                @P1Move.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnP1Move;
                @P1Jump.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnP1Jump;
                @P1Jump.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnP1Jump;
                @P1Jump.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnP1Jump;
                @P1Dash.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnP1Dash;
                @P1Dash.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnP1Dash;
                @P1Dash.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnP1Dash;
                @P1Interact.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnP1Interact;
                @P1Interact.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnP1Interact;
                @P1Interact.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnP1Interact;
                @P1Throw.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnP1Throw;
                @P1Throw.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnP1Throw;
                @P1Throw.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnP1Throw;
                @P2Move.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnP2Move;
                @P2Move.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnP2Move;
                @P2Move.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnP2Move;
                @P2Jump.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnP2Jump;
                @P2Jump.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnP2Jump;
                @P2Jump.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnP2Jump;
                @P2Dash.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnP2Dash;
                @P2Dash.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnP2Dash;
                @P2Dash.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnP2Dash;
                @P2Interact.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnP2Interact;
                @P2Interact.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnP2Interact;
                @P2Interact.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnP2Interact;
                @P2Throw.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnP2Throw;
                @P2Throw.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnP2Throw;
                @P2Throw.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnP2Throw;
                @P2Aim.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnP2Aim;
                @P2Aim.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnP2Aim;
                @P2Aim.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnP2Aim;
            }
            m_Wrapper.m_PlayerControlsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @P1Move.started += instance.OnP1Move;
                @P1Move.performed += instance.OnP1Move;
                @P1Move.canceled += instance.OnP1Move;
                @P1Jump.started += instance.OnP1Jump;
                @P1Jump.performed += instance.OnP1Jump;
                @P1Jump.canceled += instance.OnP1Jump;
                @P1Dash.started += instance.OnP1Dash;
                @P1Dash.performed += instance.OnP1Dash;
                @P1Dash.canceled += instance.OnP1Dash;
                @P1Interact.started += instance.OnP1Interact;
                @P1Interact.performed += instance.OnP1Interact;
                @P1Interact.canceled += instance.OnP1Interact;
                @P1Throw.started += instance.OnP1Throw;
                @P1Throw.performed += instance.OnP1Throw;
                @P1Throw.canceled += instance.OnP1Throw;
                @P2Move.started += instance.OnP2Move;
                @P2Move.performed += instance.OnP2Move;
                @P2Move.canceled += instance.OnP2Move;
                @P2Jump.started += instance.OnP2Jump;
                @P2Jump.performed += instance.OnP2Jump;
                @P2Jump.canceled += instance.OnP2Jump;
                @P2Dash.started += instance.OnP2Dash;
                @P2Dash.performed += instance.OnP2Dash;
                @P2Dash.canceled += instance.OnP2Dash;
                @P2Interact.started += instance.OnP2Interact;
                @P2Interact.performed += instance.OnP2Interact;
                @P2Interact.canceled += instance.OnP2Interact;
                @P2Throw.started += instance.OnP2Throw;
                @P2Throw.performed += instance.OnP2Throw;
                @P2Throw.canceled += instance.OnP2Throw;
                @P2Aim.started += instance.OnP2Aim;
                @P2Aim.performed += instance.OnP2Aim;
                @P2Aim.canceled += instance.OnP2Aim;
            }
        }
    }
    public PlayerControlsActions @PlayerControls => new PlayerControlsActions(this);
    private int m_KeyboardandmouseSchemeIndex = -1;
    public InputControlScheme KeyboardandmouseScheme
    {
        get
        {
            if (m_KeyboardandmouseSchemeIndex == -1) m_KeyboardandmouseSchemeIndex = asset.FindControlSchemeIndex("Keyboard and mouse");
            return asset.controlSchemes[m_KeyboardandmouseSchemeIndex];
        }
    }
    private int m_XboxGamepadSchemeIndex = -1;
    public InputControlScheme XboxGamepadScheme
    {
        get
        {
            if (m_XboxGamepadSchemeIndex == -1) m_XboxGamepadSchemeIndex = asset.FindControlSchemeIndex("Xbox Gamepad");
            return asset.controlSchemes[m_XboxGamepadSchemeIndex];
        }
    }
    public interface IPlayerControlsActions
    {
        void OnP1Move(InputAction.CallbackContext context);
        void OnP1Jump(InputAction.CallbackContext context);
        void OnP1Dash(InputAction.CallbackContext context);
        void OnP1Interact(InputAction.CallbackContext context);
        void OnP1Throw(InputAction.CallbackContext context);
        void OnP2Move(InputAction.CallbackContext context);
        void OnP2Jump(InputAction.CallbackContext context);
        void OnP2Dash(InputAction.CallbackContext context);
        void OnP2Interact(InputAction.CallbackContext context);
        void OnP2Throw(InputAction.CallbackContext context);
        void OnP2Aim(InputAction.CallbackContext context);
    }
}
