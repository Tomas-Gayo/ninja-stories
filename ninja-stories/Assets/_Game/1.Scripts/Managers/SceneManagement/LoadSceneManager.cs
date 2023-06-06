using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using ScriptableObjectArchitecture;
	
/// <summary>
/// 
/// </summary>
public class LoadSceneManager : MonoBehaviour
{
    [Header("Dependencies")]
    [SerializeField] private LoadingScreenUI loadingScreen;

    // Reference
    private LoadSceneRequest pendingRequest;

    // Event listener to load menu scene
    public void LoadMenuScene(LoadSceneRequest request)
    {
        SceneSO sceneToLoad = request.scene;

        if (!IsAlreadyLoaded(sceneToLoad))
        {
            SceneManager.LoadScene(sceneToLoad.name);
        }
    }

    // Event listener to load game scene
    public void LoadGameScene(LoadSceneRequest request)
    {
        SceneSO sceneToLoad = request.scene;

        if (IsAlreadyLoaded(sceneToLoad))
        {
            ActivateScene(request);
        }
        else
        {
            if (request.hasLoadingScreen)
            {
                pendingRequest = request;
                loadingScreen.ToggleScreen(true);
            }
            else
            {
                StartCoroutine(LoadScene(request));
            }
        }
    }

    private IEnumerator LoadScene(LoadSceneRequest request)
    {
        SceneSO sceneToLoad = request.scene;

        if (sceneToLoad != null)
        {
            // Unload current active scene
            Scene currentScene = SceneManager.GetActiveScene();
            SceneManager.UnloadSceneAsync(currentScene);

            AsyncOperation loadingOP =
                    SceneManager.LoadSceneAsync(sceneToLoad.name, LoadSceneMode.Additive);

            while (!loadingOP.isDone)
                yield return null;

            // Once the level is ready, activate it!
            ActivateScene(request);
        }
        
    }
    // Check if the scene is requested is already loaded 
    private bool IsAlreadyLoaded(SceneSO scene)
    {
        Scene sceneToCheck = SceneManager.GetSceneByName(scene.name);

        if (sceneToCheck != null && sceneToCheck.isLoaded)
            return true;
        else
            return false;
    }

    private void ActivateScene(LoadSceneRequest request)
    {
        // Set active
        Scene loadedScene = SceneManager.GetSceneByName(request.scene.name);
        SceneManager.SetActiveScene(loadedScene);

        // Hide loading screen
        if (request.hasLoadingScreen)
        {
            loadingScreen.ToggleScreen(false);
        }

        // Clean request
        pendingRequest = null;
    }

    // Event listener that listens from loading screen animator.
    // Is activated when loading screen was requested and we need to load new screen.
    public void OnLoadingScreenToggled(bool enabled)
    {
        if (enabled && pendingRequest != null)
        {
            StartCoroutine(LoadScene(pendingRequest));
        }
    }
}
