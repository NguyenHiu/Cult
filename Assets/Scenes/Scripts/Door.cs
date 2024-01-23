using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Door : MonoBehaviour
{
    public Animator OpenDoorAnimation;
    public GameObject Dialog;
    public AudioSource OpenDoorAudio;
    public GameObject KeyBox;

    private bool IsOpen = false;
    private bool InReach = false;
    private string OpenText = "Open [E]", FindKeyText = "Missing Key";

    // Update is called once per frame
    void Update()
    {
        if (IsOpen)
            return;
        if (InReach && Input.GetButtonDown("Interact") && KeyBox.activeInHierarchy)
        {
            OpenDoorAnimation.SetBool("Open", true);
            OpenDoorAudio.Play();
            IsOpen = true;
            Dialog.SetActive(false);    
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (IsOpen)
            return;
        if (other.gameObject.CompareTag("Reach"))
        {
            InReach = true;
            if (InReach)
            {
                if (KeyBox.activeInHierarchy)
                    Dialog.GetComponentInChildren<TextMeshProUGUI>().text = OpenText;
                else
                    Dialog.GetComponentInChildren<TextMeshProUGUI>().text = FindKeyText;
            }
            Dialog.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (IsOpen)
            return;
        if (other.gameObject.CompareTag("Reach"))
        {
            InReach = false;
            Dialog.SetActive(false);
        }
    }
}
