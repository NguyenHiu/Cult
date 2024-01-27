using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class TutorialsESC : MonoBehaviour
{

    private void Update()
    {
        if (Input.GetButtonDown("Escape"))
        {
            gameObject.SetActive(false);
        }
    }
}