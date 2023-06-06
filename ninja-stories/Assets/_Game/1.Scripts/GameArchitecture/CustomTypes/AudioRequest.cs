using UnityEngine;

/// <summary>
/// 
/// </summary>
[System.Serializable]
public class AudioRequest
{
    public AudioSO audioClips;
    public AudioConfigurationSO audioConfig;
    public Vector3 worldPosition;

    public AudioRequest(AudioSO audioClips, AudioConfigurationSO audioConfig, Vector3 worldPosition)
    {
        this.audioClips = audioClips;
        this.audioConfig = audioConfig;
        this.worldPosition = worldPosition;
    }
}