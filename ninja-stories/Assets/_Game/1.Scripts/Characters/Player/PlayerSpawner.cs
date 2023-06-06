using System;
using UnityEngine;
using Cinemachine;

	
/// <summary>
/// Spawns the player object in a specific position when requested.
/// </summary>
public class PlayerSpawner : MonoBehaviour
{
	[Header("Dependencies")]
	[SerializeField, Tooltip("Player prefab")] private GameObject playerPrefab;
	[SerializeField] private GameObject playerParent;
	[SerializeField] private PlayerPathSO playerPath;
	[SerializeField] private CinemachineVirtualCamera playerVC;

	// References
	LevelEntrance[] spawnLocations;
	Transform defaultLocation;

    private void Awake()
    {
		// First of all, find all the location entrances on the scene
        spawnLocations = FindObjectsOfType<LevelEntrance>();
		defaultLocation = transform.GetChild(0);
	}

    public void SpawnPlayerOnScene()
    {
		// Find player and location to spawn
		GameObject player = GetPlayer();

		// Last configurations on player when is ready
		player.transform.parent = playerParent.transform;
		playerVC.Follow = player.transform.GetChild(0);
		playerVC.LookAt = player.transform.GetChild(0);

		// Player path not longer needed, so it's reseted
		playerPath.ResetPlayerPath();
    }

	private GameObject GetPlayer()
    {
		// Check if there is a player already on scene
		GameObject playerGO = GameObject.FindGameObjectWithTag("Player");

		Transform spawnLocation = GetSpawnPosition();

		// On the countrary, spawn a new one
		if (playerGO == null)
        {
			playerGO = 
				Instantiate(playerPrefab, spawnLocation.transform.position, spawnLocation.rotation);
		}

		return playerGO;
    }

	private Transform GetSpawnPosition()
    {
		// if the player path is empty, location is a default one
		if (playerPath.LevelEntrance == null)
			return transform.GetChild(0);

		// Find the entrance comparing the array locations with the player path location
		int entranceIndex = Array.FindIndex(spawnLocations, element =>
			element.Location == playerPath.LevelEntrance);

		// In case of not founded, return default position
		if (entranceIndex == -1)
		{
			Debug.LogWarning("The level entrance was not found. Please, provide a proper level entrance.");
			return defaultLocation;
		}
		else
			return spawnLocations[entranceIndex].transform;
	}
}
