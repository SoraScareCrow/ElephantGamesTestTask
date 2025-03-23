
using UnityEngine;
using TMPro;
using UnityEngine.Localization;
using UnityEngine.Localization.Components;

[RequireComponent(typeof(TextMeshProUGUI))]
public class LocalizedTMPBridge : MonoBehaviour
{
    public LocalizedString localizedString;

    void OnEnable()
    {
        localizedString.StringChanged += UpdateText;
    }

    void OnDisable()
    {
        localizedString.StringChanged -= UpdateText;
    }

    void UpdateText(string value)
    {
        GetComponent<TextMeshProUGUI>().text = value;
    }
}
