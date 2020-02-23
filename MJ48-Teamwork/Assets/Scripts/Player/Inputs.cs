// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/Player/Inputs.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Inputs : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @Inputs()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Inputs"",
    ""maps"": [
        {
            ""name"": ""Controller"",
            ""id"": ""7a99bf71-90bb-4053-b1a8-366b146a3587"",
            ""actions"": [
                {
                    ""name"": ""LeftAnalog"",
                    ""type"": ""Button"",
                    ""id"": ""465243a6-bb1a-42ce-8d6c-0c12bab562a6"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RightAnalog"",
                    ""type"": ""Button"",
                    ""id"": ""71de56e8-fd2e-4c29-b47a-dfb3d822b704"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RightAnalogDown"",
                    ""type"": ""Button"",
                    ""id"": ""57b402c1-881d-4862-b3f4-4f029f98dfd8"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Start"",
                    ""type"": ""Button"",
                    ""id"": ""38160fa6-cd3c-4575-b026-e965821da99e"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""North"",
                    ""type"": ""Button"",
                    ""id"": ""35b9a828-0277-4589-90f7-b558fcc4ad67"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""West"",
                    ""type"": ""Button"",
                    ""id"": ""9c8bb7ba-89ed-4d32-b31b-e79556a7032a"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""South"",
                    ""type"": ""Button"",
                    ""id"": ""0a5c17fd-d171-4f48-99ce-3ecf290647b6"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""2e41458a-cee8-47b6-881d-cf39e4f8053e"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftAnalog"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ea525589-3279-42c1-be5f-4998ee1618ba"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RightAnalog"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fc4f69f7-9087-4e20-96f7-ec746d4547a8"",
                    ""path"": ""<Gamepad>/rightStickPress"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RightAnalogDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b88b7de9-aa73-48ac-8788-e0743b9072d4"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""West"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""114acaf3-96d1-45a5-9999-469eea3b9952"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""South"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fcd36a46-9edf-4dea-a80f-3201c451f818"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""North"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d92529c7-fc18-43d8-b56c-a40bcdddd28d"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Start"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Keyboard"",
            ""id"": ""6d851d84-3711-40cd-b593-4345ea603e5a"",
            ""actions"": [
                {
                    ""name"": ""Up"",
                    ""type"": ""Button"",
                    ""id"": ""d13e224b-ded6-4703-988d-3c57f0530c51"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Down"",
                    ""type"": ""Button"",
                    ""id"": ""b620ae17-4252-4f18-ad88-972d6925c64f"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Left"",
                    ""type"": ""Button"",
                    ""id"": ""77befa7b-ec00-47dc-9ead-e6bc6132fdf2"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Right"",
                    ""type"": ""Button"",
                    ""id"": ""24791605-1ec9-4158-8a77-73afd81adc62"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Shift"",
                    ""type"": ""Button"",
                    ""id"": ""c697cf1f-122c-469b-a991-d308f4c8ea9d"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Mouse"",
                    ""type"": ""Button"",
                    ""id"": ""f64865d3-8189-4108-9b82-73dfb34d6fd3"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""LMB"",
                    ""type"": ""Button"",
                    ""id"": ""4b258a9f-f8ec-489f-b063-f1cdfcb88309"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""cb942ee2-8970-4993-9cce-653eb4d7eaa2"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Up"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""babf5c73-7e3d-41d5-abb0-c7736412a02e"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Down"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7cb27f53-602b-46bc-8af1-848859dc41a4"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""dabd6232-d71c-413e-a713-8d87a11ce80e"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e68371c5-cb48-4d24-90a2-93cb38c8ebbe"",
                    ""path"": ""<Keyboard>/shift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shift"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bbe9b2ce-27b1-463f-9421-4d88c4936b28"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Mouse"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""af9b062f-a980-4c15-97cc-a8e2c8a76650"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LMB"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Controller
        m_Controller = asset.FindActionMap("Controller", throwIfNotFound: true);
        m_Controller_LeftAnalog = m_Controller.FindAction("LeftAnalog", throwIfNotFound: true);
        m_Controller_RightAnalog = m_Controller.FindAction("RightAnalog", throwIfNotFound: true);
        m_Controller_RightAnalogDown = m_Controller.FindAction("RightAnalogDown", throwIfNotFound: true);
        m_Controller_Start = m_Controller.FindAction("Start", throwIfNotFound: true);
        m_Controller_North = m_Controller.FindAction("North", throwIfNotFound: true);
        m_Controller_West = m_Controller.FindAction("West", throwIfNotFound: true);
        m_Controller_South = m_Controller.FindAction("South", throwIfNotFound: true);
        // Keyboard
        m_Keyboard = asset.FindActionMap("Keyboard", throwIfNotFound: true);
        m_Keyboard_Up = m_Keyboard.FindAction("Up", throwIfNotFound: true);
        m_Keyboard_Down = m_Keyboard.FindAction("Down", throwIfNotFound: true);
        m_Keyboard_Left = m_Keyboard.FindAction("Left", throwIfNotFound: true);
        m_Keyboard_Right = m_Keyboard.FindAction("Right", throwIfNotFound: true);
        m_Keyboard_Shift = m_Keyboard.FindAction("Shift", throwIfNotFound: true);
        m_Keyboard_Mouse = m_Keyboard.FindAction("Mouse", throwIfNotFound: true);
        m_Keyboard_LMB = m_Keyboard.FindAction("LMB", throwIfNotFound: true);
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

    // Controller
    private readonly InputActionMap m_Controller;
    private IControllerActions m_ControllerActionsCallbackInterface;
    private readonly InputAction m_Controller_LeftAnalog;
    private readonly InputAction m_Controller_RightAnalog;
    private readonly InputAction m_Controller_RightAnalogDown;
    private readonly InputAction m_Controller_Start;
    private readonly InputAction m_Controller_North;
    private readonly InputAction m_Controller_West;
    private readonly InputAction m_Controller_South;
    public struct ControllerActions
    {
        private @Inputs m_Wrapper;
        public ControllerActions(@Inputs wrapper) { m_Wrapper = wrapper; }
        public InputAction @LeftAnalog => m_Wrapper.m_Controller_LeftAnalog;
        public InputAction @RightAnalog => m_Wrapper.m_Controller_RightAnalog;
        public InputAction @RightAnalogDown => m_Wrapper.m_Controller_RightAnalogDown;
        public InputAction @Start => m_Wrapper.m_Controller_Start;
        public InputAction @North => m_Wrapper.m_Controller_North;
        public InputAction @West => m_Wrapper.m_Controller_West;
        public InputAction @South => m_Wrapper.m_Controller_South;
        public InputActionMap Get() { return m_Wrapper.m_Controller; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ControllerActions set) { return set.Get(); }
        public void SetCallbacks(IControllerActions instance)
        {
            if (m_Wrapper.m_ControllerActionsCallbackInterface != null)
            {
                @LeftAnalog.started -= m_Wrapper.m_ControllerActionsCallbackInterface.OnLeftAnalog;
                @LeftAnalog.performed -= m_Wrapper.m_ControllerActionsCallbackInterface.OnLeftAnalog;
                @LeftAnalog.canceled -= m_Wrapper.m_ControllerActionsCallbackInterface.OnLeftAnalog;
                @RightAnalog.started -= m_Wrapper.m_ControllerActionsCallbackInterface.OnRightAnalog;
                @RightAnalog.performed -= m_Wrapper.m_ControllerActionsCallbackInterface.OnRightAnalog;
                @RightAnalog.canceled -= m_Wrapper.m_ControllerActionsCallbackInterface.OnRightAnalog;
                @RightAnalogDown.started -= m_Wrapper.m_ControllerActionsCallbackInterface.OnRightAnalogDown;
                @RightAnalogDown.performed -= m_Wrapper.m_ControllerActionsCallbackInterface.OnRightAnalogDown;
                @RightAnalogDown.canceled -= m_Wrapper.m_ControllerActionsCallbackInterface.OnRightAnalogDown;
                @Start.started -= m_Wrapper.m_ControllerActionsCallbackInterface.OnStart;
                @Start.performed -= m_Wrapper.m_ControllerActionsCallbackInterface.OnStart;
                @Start.canceled -= m_Wrapper.m_ControllerActionsCallbackInterface.OnStart;
                @North.started -= m_Wrapper.m_ControllerActionsCallbackInterface.OnNorth;
                @North.performed -= m_Wrapper.m_ControllerActionsCallbackInterface.OnNorth;
                @North.canceled -= m_Wrapper.m_ControllerActionsCallbackInterface.OnNorth;
                @West.started -= m_Wrapper.m_ControllerActionsCallbackInterface.OnWest;
                @West.performed -= m_Wrapper.m_ControllerActionsCallbackInterface.OnWest;
                @West.canceled -= m_Wrapper.m_ControllerActionsCallbackInterface.OnWest;
                @South.started -= m_Wrapper.m_ControllerActionsCallbackInterface.OnSouth;
                @South.performed -= m_Wrapper.m_ControllerActionsCallbackInterface.OnSouth;
                @South.canceled -= m_Wrapper.m_ControllerActionsCallbackInterface.OnSouth;
            }
            m_Wrapper.m_ControllerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @LeftAnalog.started += instance.OnLeftAnalog;
                @LeftAnalog.performed += instance.OnLeftAnalog;
                @LeftAnalog.canceled += instance.OnLeftAnalog;
                @RightAnalog.started += instance.OnRightAnalog;
                @RightAnalog.performed += instance.OnRightAnalog;
                @RightAnalog.canceled += instance.OnRightAnalog;
                @RightAnalogDown.started += instance.OnRightAnalogDown;
                @RightAnalogDown.performed += instance.OnRightAnalogDown;
                @RightAnalogDown.canceled += instance.OnRightAnalogDown;
                @Start.started += instance.OnStart;
                @Start.performed += instance.OnStart;
                @Start.canceled += instance.OnStart;
                @North.started += instance.OnNorth;
                @North.performed += instance.OnNorth;
                @North.canceled += instance.OnNorth;
                @West.started += instance.OnWest;
                @West.performed += instance.OnWest;
                @West.canceled += instance.OnWest;
                @South.started += instance.OnSouth;
                @South.performed += instance.OnSouth;
                @South.canceled += instance.OnSouth;
            }
        }
    }
    public ControllerActions @Controller => new ControllerActions(this);

    // Keyboard
    private readonly InputActionMap m_Keyboard;
    private IKeyboardActions m_KeyboardActionsCallbackInterface;
    private readonly InputAction m_Keyboard_Up;
    private readonly InputAction m_Keyboard_Down;
    private readonly InputAction m_Keyboard_Left;
    private readonly InputAction m_Keyboard_Right;
    private readonly InputAction m_Keyboard_Shift;
    private readonly InputAction m_Keyboard_Mouse;
    private readonly InputAction m_Keyboard_LMB;
    public struct KeyboardActions
    {
        private @Inputs m_Wrapper;
        public KeyboardActions(@Inputs wrapper) { m_Wrapper = wrapper; }
        public InputAction @Up => m_Wrapper.m_Keyboard_Up;
        public InputAction @Down => m_Wrapper.m_Keyboard_Down;
        public InputAction @Left => m_Wrapper.m_Keyboard_Left;
        public InputAction @Right => m_Wrapper.m_Keyboard_Right;
        public InputAction @Shift => m_Wrapper.m_Keyboard_Shift;
        public InputAction @Mouse => m_Wrapper.m_Keyboard_Mouse;
        public InputAction @LMB => m_Wrapper.m_Keyboard_LMB;
        public InputActionMap Get() { return m_Wrapper.m_Keyboard; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(KeyboardActions set) { return set.Get(); }
        public void SetCallbacks(IKeyboardActions instance)
        {
            if (m_Wrapper.m_KeyboardActionsCallbackInterface != null)
            {
                @Up.started -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnUp;
                @Up.performed -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnUp;
                @Up.canceled -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnUp;
                @Down.started -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnDown;
                @Down.performed -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnDown;
                @Down.canceled -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnDown;
                @Left.started -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnLeft;
                @Left.performed -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnLeft;
                @Left.canceled -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnLeft;
                @Right.started -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnRight;
                @Right.performed -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnRight;
                @Right.canceled -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnRight;
                @Shift.started -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnShift;
                @Shift.performed -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnShift;
                @Shift.canceled -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnShift;
                @Mouse.started -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnMouse;
                @Mouse.performed -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnMouse;
                @Mouse.canceled -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnMouse;
                @LMB.started -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnLMB;
                @LMB.performed -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnLMB;
                @LMB.canceled -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnLMB;
            }
            m_Wrapper.m_KeyboardActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Up.started += instance.OnUp;
                @Up.performed += instance.OnUp;
                @Up.canceled += instance.OnUp;
                @Down.started += instance.OnDown;
                @Down.performed += instance.OnDown;
                @Down.canceled += instance.OnDown;
                @Left.started += instance.OnLeft;
                @Left.performed += instance.OnLeft;
                @Left.canceled += instance.OnLeft;
                @Right.started += instance.OnRight;
                @Right.performed += instance.OnRight;
                @Right.canceled += instance.OnRight;
                @Shift.started += instance.OnShift;
                @Shift.performed += instance.OnShift;
                @Shift.canceled += instance.OnShift;
                @Mouse.started += instance.OnMouse;
                @Mouse.performed += instance.OnMouse;
                @Mouse.canceled += instance.OnMouse;
                @LMB.started += instance.OnLMB;
                @LMB.performed += instance.OnLMB;
                @LMB.canceled += instance.OnLMB;
            }
        }
    }
    public KeyboardActions @Keyboard => new KeyboardActions(this);
    public interface IControllerActions
    {
        void OnLeftAnalog(InputAction.CallbackContext context);
        void OnRightAnalog(InputAction.CallbackContext context);
        void OnRightAnalogDown(InputAction.CallbackContext context);
        void OnStart(InputAction.CallbackContext context);
        void OnNorth(InputAction.CallbackContext context);
        void OnWest(InputAction.CallbackContext context);
        void OnSouth(InputAction.CallbackContext context);
    }
    public interface IKeyboardActions
    {
        void OnUp(InputAction.CallbackContext context);
        void OnDown(InputAction.CallbackContext context);
        void OnLeft(InputAction.CallbackContext context);
        void OnRight(InputAction.CallbackContext context);
        void OnShift(InputAction.CallbackContext context);
        void OnMouse(InputAction.CallbackContext context);
        void OnLMB(InputAction.CallbackContext context);
    }
}
