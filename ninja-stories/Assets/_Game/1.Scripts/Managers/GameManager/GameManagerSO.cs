using UnityEngine;
using ScriptableObjectArchitecture;

//[CreateAssetMenu(fileName = "GameManager", menuName = "Scriptable Objects/Game Manager")]
public class GameManagerSO : ScriptableObject
{
    [SerializeField] private GameStateSO currentState;

    [Header("Broadcasting Events")]
    [SerializeField] private GameStateSOGameEvent gameStateChanged;


    private GameStateSO previousState;

    public void SetGameState(GameStateSO gameState)
    {
        if (currentState != null)
            previousState = currentState;

        currentState = gameState;

        if (gameStateChanged != null)
            gameStateChanged.Raise(gameState);
    }

    public void RestorePreviousState()
    {
        SetGameState(previousState);
    }
}
