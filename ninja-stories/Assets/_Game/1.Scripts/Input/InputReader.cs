using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

/// <summary>
/// Reads the input from the Action Map and sends an event the conditions are met
/// </summary>
//[CreateAssetMenu(fileName = "InputReader", menuName = "Scriptable Objects/InputReader")]
public class InputReader : ScriptableObject, PlayerInput.IGameplayActions, PlayerInput.IMenuActions
{
    // Actions during gameplay state
    public event UnityAction<Vector2> MoveEvent = delegate { };
    public event UnityAction<Vector2> LookEvent = delegate { };
    public event UnityAction StartRunningEvent = delegate { };
    public event UnityAction StopRunningEvent = delegate { };
    public event UnityAction InteractEvent = delegate { };
    public event UnityAction SheatheUnsheatheEvent = delegate { };
    public event UnityAction AttackEvent = delegate { };
    public event UnityAction SpecialAttackEvent = delegate { };
    public event UnityAction OpenPauseMenuEvent = delegate { };
    public event UnityAction OpenInventoryEvent = delegate { };

    // Actions during menu state
    public event UnityAction CloseInventoryEvent = delegate { };
    public event UnityAction ClosePauseMenuEvent = delegate { };


    // Player Input is the class generated from the Player Action map
    // It saves all the data from the inputs and we can use it to
    // get the maps and actions and act in consequence
    private PlayerInput playerInput;

    private void OnEnable()
    {
        // Ask to the action map that we want to know about the actions triggered
        if (playerInput == null)
        {
            playerInput = new PlayerInput();
            
            playerInput.Gameplay.SetCallbacks(this);
            playerInput.Menu.SetCallbacks(this);
        }
    }

    private void OnDisable()
    {
        DisableAllInputs();
    }

    // Input call back events

    public void OnMove(InputAction.CallbackContext context)
    {
        MoveEvent.Invoke(context.ReadValue<Vector2>().normalized);
    }

    public void OnLook(InputAction.CallbackContext context)
    {
        LookEvent.Invoke(context.ReadValue<Vector2>().normalized);
    }

    public void OnRun(InputAction.CallbackContext context)
    {
        switch (context.phase)
        {
            case InputActionPhase.Performed:
                StartRunningEvent.Invoke();
                break;
            case InputActionPhase.Canceled:
                StopRunningEvent.Invoke();
                break;
        }
    }

    public void OnInteract(InputAction.CallbackContext context)
    {
        if (context.phase == InputActionPhase.Performed)
            InteractEvent.Invoke();
    }

    public void OnAttack(InputAction.CallbackContext context)
    {
        if (context.phase == InputActionPhase.Performed)
            AttackEvent.Invoke();
    }

    public void OnSheatheUnsheathe(InputAction.CallbackContext context)
    {
        if (context.phase == InputActionPhase.Performed)
            SheatheUnsheatheEvent.Invoke();
    }

    public void OnSpecialAttack(InputAction.CallbackContext context)
    {
        if (context.phase == InputActionPhase.Performed)
            SpecialAttackEvent.Invoke();
    }

    public void OnOpenInventory(InputAction.CallbackContext context)
    {
        if (context.phase == InputActionPhase.Performed)
            OpenInventoryEvent.Invoke();
    }

    public void OnCloseInventory(InputAction.CallbackContext context)
    {
        if (context.phase == InputActionPhase.Performed)
            CloseInventoryEvent.Invoke();
    }

    public void EnableGameplayInput()
    {
        playerInput.Menu.Disable();
        playerInput.Gameplay.Enable();
    }
    public void OnOpenPauseMenu(InputAction.CallbackContext context)
    {
        if (context.phase == InputActionPhase.Performed)
            OpenPauseMenuEvent.Invoke();
    }

    public void OnClosePauseMenu(InputAction.CallbackContext context)
    {
        if (context.phase == InputActionPhase.Performed)
            ClosePauseMenuEvent.Invoke();
    }

    public void EnableMenuInput()
    {
        playerInput.Gameplay.Disable();
        playerInput.Menu.Enable();
    }

    public void DisableAllInputs()
    {
        playerInput.Gameplay.Disable();
        playerInput.Menu.Disable();
    }

}
