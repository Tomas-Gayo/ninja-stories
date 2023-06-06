using UnityEngine;

/// <summary>
/// 
/// </summary>
[CreateAssetMenu(fileName = "NewScene", menuName = "Scriptable Objects/Scene")]
public class SceneSO : ScriptableObject
{
    [SerializeField] private string sceneName;

    public string SceneName => sceneName;
}
