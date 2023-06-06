using UnityEngine;

/// <summary>
/// This will manage the path taken to be able to spawn the player on the specific location
/// </summary>
//[CreateAssetMenu(fileName = "PlayerPathSO", menuName = "Scriptable Objects/PlayerPathSO")]
public class PlayerPathSO : ScriptableObject
{
    [SerializeField] private PathSO levelEntrance;

    public PathSO LevelEntrance => levelEntrance;

    public void SetLevelEntrance(PathSO newEntry)
    {
        levelEntrance = newEntry;
    }

    public void ResetPlayerPath()
    {
        levelEntrance = null;
    }
}
