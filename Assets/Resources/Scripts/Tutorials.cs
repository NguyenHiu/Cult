using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Tutorials : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI textField;

    private void Start()
    {
        textField.text = "Nhấn [F] để mở đèn pin";
    }

    private void Update()
    {
        if (Input.GetButtonDown("Flashlight"))
        {
            textField.text = "";
        }
    }
}
