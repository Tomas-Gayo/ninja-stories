using UnityEngine;
using UnityEngine.Events;

	
/// <summary>
/// On Trigger event with player, if all the conditions are met
/// then, the player will be spawn in another location
/// </summary>
[RequireComponent(typeof(SceneLoader))]
public class LevelExit : MonoBehaviour
{
    [Header("Configuration")]
	[SerializeField] private PathSO pathToTake;
	[SerializeField] private PlayerPathSO playerPath;

    [Header("Events")]
    [SerializeField] private UnityEvent onTriggerEnter = default;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerPath.SetLevelEntrance(pathToTake);
            onTriggerEnter.Invoke();
        }
    }
}
