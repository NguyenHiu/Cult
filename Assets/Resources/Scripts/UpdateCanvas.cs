using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UpdateCanvas : MonoBehaviour
{

    public TextMeshProUGUI textMeshProUGUI;
    public void updateCavas(string text)
    {
        textMeshProUGUI.text = text;
    }
}
