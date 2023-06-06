using UnityEngine;
using ScriptableObjectArchitecture;
	
/// <summary>
/// This will broadcast on an event to request a new scene to load
/// </summary>
public class SceneLoader : MonoBehaviour
{
    [Header("Configuration")]
    public SceneSO sceneToLoad;
    public bool loadingScreen;

    [Header("Broadcasting on channels")]
    public LoadSceneRequestGameEvent loadSceneChannel;

    public void LoadScene()
    {
        var request = new LoadSceneRequest(
            scene: sceneToLoad,
            hasLoadingScreen: loadingScreen
        );

        loadSceneChannel.Raise(request);
    }

    public void Exit()
    {
        Application.Quit();
        Debug.Log("Bye Bye");
    }
}
