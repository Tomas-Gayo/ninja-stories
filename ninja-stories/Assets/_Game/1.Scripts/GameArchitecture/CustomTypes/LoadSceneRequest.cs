/// <summary>
/// Request sent when a new scene want to be loaded
/// </summary>
[System.Serializable]
public class LoadSceneRequest
{
    public SceneSO scene;
    public bool hasLoadingScreen;


    public LoadSceneRequest(SceneSO scene, bool hasLoadingScreen)
    {
        this.scene = scene;
        this.hasLoadingScreen = hasLoadingScreen;
    }
}