using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using TMPro;

	
public class LanguageDropdownUI : MonoBehaviour
{
	[SerializeField] private TMP_Dropdown dropdown;

    public event UnityAction<int> languageChange;

	public void DisplayOptions(List<string> locales, int currentLocaleIndex)
    {
        dropdown.ClearOptions();
        dropdown.AddOptions(locales);
        dropdown.value = currentLocaleIndex;
        //dropdown.RefreshShownValue();
    }

    public void OnValueChanged(int newLocaleIndex)
    {
        languageChange.Invoke(newLocaleIndex);
    }
}
