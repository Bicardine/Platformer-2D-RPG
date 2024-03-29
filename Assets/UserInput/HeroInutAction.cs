// GENERATED AUTOMATICALLY FROM 'Assets/UserInput/HeroInutAction.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @HeroInutAction : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @HeroInutAction()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""HeroInutAction"",
    ""maps"": [
        {
            ""name"": ""Hero"",
            ""id"": ""0c07cba6-ad5c-4c64-912b-8b286cbdd849"",
            ""actions"": [
                {
                    ""name"": ""movement"",
                    ""type"": ""Value"",
                    ""id"": ""279c6bc9-53e0-40c4-8e91-2fff563c9bde"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Interact"",
                    ""type"": ""Button"",
                    ""id"": ""d1705bc5-e90a-468a-bdf7-bfff8021a719"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Attack"",
                    ""type"": ""Button"",
                    ""id"": ""9f4796fa-d06c-49d0-bd26-45733ee80efb"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Throw"",
                    ""type"": ""Button"",
                    ""id"": ""889385dd-aad2-4993-bdb2-589559e66705"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""NextItem"",
                    ""type"": ""Button"",
                    ""id"": ""c5ea2e8b-2b57-421c-a04d-7adeb706cab6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""DropDown"",
                    ""type"": ""Button"",
                    ""id"": ""08755ec6-62a9-4e54-baee-954831776712"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""UsePerk"",
                    ""type"": ""Button"",
                    ""id"": ""92caea29-ee9c-4619-9794-3d5ff669db34"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""17a2cdf4-83da-435c-9f74-5dd968c1ddd4"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""ef87d2a5-e7ac-45c0-9a39-7f074cab6c00"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""2df05a97-52bc-48d0-a96c-aaeea7127671"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""0cda7a43-7d06-430b-8eca-f6ae011da4aa"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""7c99f50d-0e88-4ecf-833b-dfbadf9bcb45"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""30c0b62d-f6a0-48a3-917e-9ea4ceb7fe2a"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""97706643-90fe-44a5-8dfd-229748aa7eea"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bcbacb10-5167-4edf-adca-9f31e6f968f3"",
                    ""path"": ""<Keyboard>/shift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Throw"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""77271a72-89ae-49f8-b976-f040447b5e30"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""NextItem"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Button With One Modifier"",
                    ""id"": ""c8af75e5-33db-4560-a978-0c84ba5a8550"",
                    ""path"": ""ButtonWithOneModifier"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DropDown"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""modifier"",
                    ""id"": ""760a6f19-6c89-4a33-836a-7c9613412cb6"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DropDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""button"",
                    ""id"": ""e8f64911-7334-45cb-bc82-a1dc135a55b8"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DropDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""e355a380-a644-43fa-a56b-63a023984d28"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""UsePerk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Hero
        m_Hero = asset.FindActionMap("Hero", throwIfNotFound: true);
        m_Hero_movement = m_Hero.FindAction("movement", throwIfNotFound: true);
        m_Hero_Interact = m_Hero.FindAction("Interact", throwIfNotFound: true);
        m_Hero_Attack = m_Hero.FindAction("Attack", throwIfNotFound: true);
        m_Hero_Throw = m_Hero.FindAction("Throw", throwIfNotFound: true);
        m_Hero_NextItem = m_Hero.FindAction("NextItem", throwIfNotFound: true);
        m_Hero_DropDown = m_Hero.FindAction("DropDown", throwIfNotFound: true);
        m_Hero_UsePerk = m_Hero.FindAction("UsePerk", throwIfNotFound: true);
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

    // Hero
    private readonly InputActionMap m_Hero;
    private IHeroActions m_HeroActionsCallbackInterface;
    private readonly InputAction m_Hero_movement;
    private readonly InputAction m_Hero_Interact;
    private readonly InputAction m_Hero_Attack;
    private readonly InputAction m_Hero_Throw;
    private readonly InputAction m_Hero_NextItem;
    private readonly InputAction m_Hero_DropDown;
    private readonly InputAction m_Hero_UsePerk;
    public struct HeroActions
    {
        private @HeroInutAction m_Wrapper;
        public HeroActions(@HeroInutAction wrapper) { m_Wrapper = wrapper; }
        public InputAction @movement => m_Wrapper.m_Hero_movement;
        public InputAction @Interact => m_Wrapper.m_Hero_Interact;
        public InputAction @Attack => m_Wrapper.m_Hero_Attack;
        public InputAction @Throw => m_Wrapper.m_Hero_Throw;
        public InputAction @NextItem => m_Wrapper.m_Hero_NextItem;
        public InputAction @DropDown => m_Wrapper.m_Hero_DropDown;
        public InputAction @UsePerk => m_Wrapper.m_Hero_UsePerk;
        public InputActionMap Get() { return m_Wrapper.m_Hero; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(HeroActions set) { return set.Get(); }
        public void SetCallbacks(IHeroActions instance)
        {
            if (m_Wrapper.m_HeroActionsCallbackInterface != null)
            {
                @movement.started -= m_Wrapper.m_HeroActionsCallbackInterface.OnMovement;
                @movement.performed -= m_Wrapper.m_HeroActionsCallbackInterface.OnMovement;
                @movement.canceled -= m_Wrapper.m_HeroActionsCallbackInterface.OnMovement;
                @Interact.started -= m_Wrapper.m_HeroActionsCallbackInterface.OnInteract;
                @Interact.performed -= m_Wrapper.m_HeroActionsCallbackInterface.OnInteract;
                @Interact.canceled -= m_Wrapper.m_HeroActionsCallbackInterface.OnInteract;
                @Attack.started -= m_Wrapper.m_HeroActionsCallbackInterface.OnAttack;
                @Attack.performed -= m_Wrapper.m_HeroActionsCallbackInterface.OnAttack;
                @Attack.canceled -= m_Wrapper.m_HeroActionsCallbackInterface.OnAttack;
                @Throw.started -= m_Wrapper.m_HeroActionsCallbackInterface.OnThrow;
                @Throw.performed -= m_Wrapper.m_HeroActionsCallbackInterface.OnThrow;
                @Throw.canceled -= m_Wrapper.m_HeroActionsCallbackInterface.OnThrow;
                @NextItem.started -= m_Wrapper.m_HeroActionsCallbackInterface.OnNextItem;
                @NextItem.performed -= m_Wrapper.m_HeroActionsCallbackInterface.OnNextItem;
                @NextItem.canceled -= m_Wrapper.m_HeroActionsCallbackInterface.OnNextItem;
                @DropDown.started -= m_Wrapper.m_HeroActionsCallbackInterface.OnDropDown;
                @DropDown.performed -= m_Wrapper.m_HeroActionsCallbackInterface.OnDropDown;
                @DropDown.canceled -= m_Wrapper.m_HeroActionsCallbackInterface.OnDropDown;
                @UsePerk.started -= m_Wrapper.m_HeroActionsCallbackInterface.OnUsePerk;
                @UsePerk.performed -= m_Wrapper.m_HeroActionsCallbackInterface.OnUsePerk;
                @UsePerk.canceled -= m_Wrapper.m_HeroActionsCallbackInterface.OnUsePerk;
            }
            m_Wrapper.m_HeroActionsCallbackInterface = instance;
            if (instance != null)
            {
                @movement.started += instance.OnMovement;
                @movement.performed += instance.OnMovement;
                @movement.canceled += instance.OnMovement;
                @Interact.started += instance.OnInteract;
                @Interact.performed += instance.OnInteract;
                @Interact.canceled += instance.OnInteract;
                @Attack.started += instance.OnAttack;
                @Attack.performed += instance.OnAttack;
                @Attack.canceled += instance.OnAttack;
                @Throw.started += instance.OnThrow;
                @Throw.performed += instance.OnThrow;
                @Throw.canceled += instance.OnThrow;
                @NextItem.started += instance.OnNextItem;
                @NextItem.performed += instance.OnNextItem;
                @NextItem.canceled += instance.OnNextItem;
                @DropDown.started += instance.OnDropDown;
                @DropDown.performed += instance.OnDropDown;
                @DropDown.canceled += instance.OnDropDown;
                @UsePerk.started += instance.OnUsePerk;
                @UsePerk.performed += instance.OnUsePerk;
                @UsePerk.canceled += instance.OnUsePerk;
            }
        }
    }
    public HeroActions @Hero => new HeroActions(this);
    public interface IHeroActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnInteract(InputAction.CallbackContext context);
        void OnAttack(InputAction.CallbackContext context);
        void OnThrow(InputAction.CallbackContext context);
        void OnNextItem(InputAction.CallbackContext context);
        void OnDropDown(InputAction.CallbackContext context);
        void OnUsePerk(InputAction.CallbackContext context);
    }
}
