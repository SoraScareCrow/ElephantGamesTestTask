using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LocalizedTextSetter : MonoBehaviour
{
    public TextMeshProUGUI targetText;

    public void ApplyLocalizedText(string value)
    {
        if (targetText != null)
        {
            targetText.SetText(value);
        }
    }
}
