using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityTutorial.PlayerControl;

public class NoteInteraction : MonoBehaviour
{
    [SerializeField] GameObject note;
    private bool isOpen = false;
    private bool flag = false;

    private void Update()
    {
        Debug.Log("flag: " + flag);
        if (flag && Input.GetButtonDown("Interact"))
        {
            if (isOpen)
            {
                isOpen = false;
                FindAnyObjectByType<PlayerController>().UnFreeze();
            } else
            {
                isOpen = true;
                FindAnyObjectByType<PlayerController>().Freeze();
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
