using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
using UnityTutorial.PlayerControl;

public class NoteInteraction : MonoBehaviour
{
    [SerializeField] GameObject note;
    [SerializeField] AudioSource audioSource;
    private bool isOpen = false;
    private bool flag = false;

    private void Awake()
    {
        audioSource.playOnAwake = false;
    }

    private void Update()
    {
        if (flag && Input.GetButtonDown("Interact"))
        {
            if (isOpen)
            {
                isOpen = false;
                FindAnyObjectByType<FirstPersonController>().enabled = true;
            } else
            {
                isOpen = true;
                audioSource.Play();
                FindAnyObjectByType<FirstPersonController>().enabled = false;
            }
            note.SetActive(isOpen);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("player_interact"))
        {
            flag = true;
        } 
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("player_interact"))
        {
            flag = false;
        }
    }
}
