using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class EscapeButton : MonoBehaviour
{
    [SerializeField] GameObject EscapeScreen;
    [SerializeField] LoadingScreen loadingScreen;
    public void QuitScene()
    {
        EscapeScreen.SetActive(false);
        Time.timeScale = 1f;
        FindAnyObjectByType<FirstPersonController>().enabled = true;
        loadingScreen.LoadScene(0);
    }

    public void ResumeGame()
    {
        EscapeScreen.SetActive(false);
        Time.timeScale = 1f;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        FindAnyObjectByType<FirstPersonController>().enabled = true;
    }
}
