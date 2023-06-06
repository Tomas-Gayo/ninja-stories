using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SetResolution : MonoBehaviour
{
    [Header("Dependencies")]
    [SerializeField] private TMP_Dropdown resolutionDropdown;

    [SerializeField] private List<Vector2Int> resolutions;

    private void Start()
    {
        resolutionDropdown.ClearOptions();

        List<string> options = new List<string>();

        int currentResolutionIndex = 0;
        for (int i = 0; i < resolutions.Count; i++)
        {
            string option = resolutions[i].x + " x " + resolutions[i].y;
            options.Add(option);

            if (resolutions[i].x == Screen.currentResolution.width &&
                resolutions[i].y == Screen.currentResolution.height)
            {
                currentResolutionIndex = i;
            }
        }
        resolutionDropdown.AddOptions(options);
        resolutionDropdown.value = currentResolutionIndex;
        resolutionDropdown.RefreshShownValue();
    }

    public void SetResolutionValue(int resolutionIndex)
    {
        Screen.SetResolution(resolutions[resolutionIndex].x, resolutions[resolutionIndex].y, Screen.fullScreen);
    }

}
