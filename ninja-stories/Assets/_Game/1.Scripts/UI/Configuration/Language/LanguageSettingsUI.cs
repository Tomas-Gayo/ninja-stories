using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Localization;
using UnityEngine.Localization.Settings;
using UnityEngine.ResourceManagement.AsyncOperations;

public class LanguageSettingsUI : MonoBehaviour
{
	[SerializeField] LanguageDropdownUI languageDropdownUI;

    public event UnityAction<Locale> save = default;
    private int currentLocale = 0;
    private List<string> languages;
    private AsyncOperationHandle initializeOperation;

    private void OnEnable()
    {
        initializeOperation = LocalizationSettings.SelectedLocaleAsync;
        if (initializeOperation.IsDone)
        {
            OnLocalizationSystemReady(initializeOperation);
        }
        else
        {
            initializeOperation.Completed += OnLocalizationSystemReady;
        }
    }

    private void OnDisable()
    {
        languageDropdownUI.languageChange -= ChangeLanguage;
    }

    private void OnLocalizationSystemReady(AsyncOperationHandle obj)
    {
        initializeOperation.Completed -= OnLocalizationSystemReady;

        languages = new List<string>();

        List<Locale> locales = LocalizationSettings.AvailableLocales.Locales;

        for (int i = 0; i < locales.Count; ++i)
        {
            Locale locale = locales[i];
            if (LocalizationSettings.SelectedLocale == locale)
                currentLocale = i;

            string localeToDisplay = locales[i].ToString();

            languages.Add(localeToDisplay);
        }

        languageDropdownUI.languageChange += ChangeLanguage;
        DisplayOptions();
    }

    public void DisplayOptions()
    {
        languageDropdownUI.DisplayOptions(languages, currentLocale);
    }

    private void ChangeLanguage(int localeIndex)
    {
        languageDropdownUI.languageChange -= ChangeLanguage;
        Locale currentLocale = LocalizationSettings.AvailableLocales.Locales[localeIndex];
        LocalizationSettings.SelectedLocale = currentLocale;
        languageDropdownUI.languageChange += ChangeLanguage;
    }
}
