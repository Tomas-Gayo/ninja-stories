using UnityEngine;
using ScriptableObjectArchitecture;
using UnityEngine.Events;

public class GameStateListener : MonoBehaviour
{
    [SerializeField] private InputReader inputReader;

    [Header("Listening to Events")]
    public GameStateSOGameEvent gameStateChangedEvent;

    [Header("Actions")]
    public UnityEvent onMainMenuState = default;
    public UnityEvent onGameState = default;
    public UnityEvent onInventoryState = default;
    public UnityEvent onQuestPanelState = default;
    public UnityEvent onEndGameState = default;
    public UnityEvent onLoadingState = default;
    public UnityEvent onPauseState = default;

    private void OnEnable()
    {
        gameStateChangedEvent.AddListener(GameStateChanged);
    }

    private void OnDisable()
    {
        gameStateChangedEvent.RemoveListener(GameStateChanged);
    }


    private void GameStateChanged(GameStateSO newGameState)
    {
        switch (newGameState.name)
        {
            case "MainMenu":
                onMainMenuState.Invoke();
                inputReader.DisableAllInputs();
                break;
            case "InGame":
                onGameState.Invoke();
                inputReader.EnableGameplayInput();
                break;
            case "Inventory":
                onInventoryState.Invoke();
                inputReader.EnableMenuInput();
                break;
            case "QuestPanel":
                onQuestPanelState.Invoke();
                inputReader.EnableMenuInput();
                break;
            case "EndGame":
                onEndGameState.Invoke();
                inputReader.DisableAllInputs();
                break;
            case "Loading":
                onLoadingState.Invoke();
                inputReader.DisableAllInputs();
                break;
            case "Pause":
                onPauseState.Invoke();
                inputReader.EnableMenuInput();
                break;
            default:
                Debug.LogError("State not recognized");
                break;
        }
    }
}
