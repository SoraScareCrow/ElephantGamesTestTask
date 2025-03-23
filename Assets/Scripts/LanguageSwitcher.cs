using UnityEngine;
using UnityEngine.Localization.Settings;
using System.Collections;

public class LanguageToggle : MonoBehaviour
{
    public void ToggleLanguage()
    {
        StartCoroutine(ToggleLanguageCoroutine());
    }

    private IEnumerator ToggleLanguageCoroutine()
    {
        yield return LocalizationSettings.InitializationOperation;

        var currentLocale = LocalizationSettings.SelectedLocale.Identifier.Code;

        if (currentLocale == "en")
        {
            var pl = LocalizationSettings.AvailableLocales.GetLocale("pl");
            LocalizationSettings.SelectedLocale = pl;
        }
        else
        {
            var en = LocalizationSettings.AvailableLocales.GetLocale("en");
            LocalizationSettings.SelectedLocale = en;
        }
    }
}
