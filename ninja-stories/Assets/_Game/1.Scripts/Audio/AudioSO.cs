using System;
using UnityEngine;

/// <summary>
/// 
/// </summary>
[CreateAssetMenu(fileName = "NewAudio", menuName = "Scriptable Objects/Audio")]
public class AudioSO : ScriptableObject
{
    public bool hasToLoop = false;
    [SerializeField] private AudioClip[] clips;

    public AudioClip[] GetClips()
    {
        return clips;
    }
}