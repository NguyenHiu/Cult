using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class EscapeController : MonoBehaviour
{
    [SerializeField] GameObject escapeScreen;
    private bool isPause = false;

    private void Update()
    {
        if (Input.GetButtonDown("Escape"))
        {
            isPause = !isPause;
            if (isPause)
            {
                escapeScreen.SetActive(true);
                Time.timeScale = 0f;
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;
                FindAnyObjectByType<FirstPersonController>().enabled = false;
            }
            else
            {
                escapeScreen.SetActive(false);
                Time.timeScale = 1f;
                Cursor.visible = false;
                Cursor.lockState = CursorLockMode.Locked;
                FindAnyObjectByType<FirstPersonController>().enabled = true;
            }
        }
    }
}
