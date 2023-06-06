using UnityEngine;

public class GameStateChanger : MonoBehaviour
{
    [Header("Dependencies")]
    public GameManagerSO gameManager;

    public void SetGameState(GameStateSO gameState)
    {
        gameManager.SetGameState(gameState);
    }

    public void RestorePreviousState()
    {
        gameManager.RestorePreviousState();
    }
}
