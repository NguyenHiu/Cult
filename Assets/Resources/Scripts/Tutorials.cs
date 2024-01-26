using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Tutorials : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI textField;

    private void Start()
    {
        textField.text = "Press [F] to use Flashlight";
    }

    private void Update()
    {
        if (Input.GetButtonDown("Flashlight"))
        {
            textField.text = "";
        }
    }
}
