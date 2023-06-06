using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class AudioSettingsUI : MonoBehaviour
{
    [Header("UI Elements")]
    [SerializeField] private Slider volumeSlider;

    public event UnityAction<float> volumeChange = delegate {};

    public void SetUpField(float volumeValue)
    {
        volumeSlider.value = volumeValue;
    }

    public void OnValueChanged(float newVolume)
    {
        volumeChange.Invoke(newVolume);
    }
}
