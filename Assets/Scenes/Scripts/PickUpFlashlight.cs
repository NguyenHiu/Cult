using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PickUpFlashlight : MonoBehaviour
{
    public GameObject FlashLightObject;
    public Flashlight FlashLightSlot;
    public AudioSource PickUpSound;
    public GameObject Dialog;

    private string Text = "Pick up [E]";
    private bool InReach = false;

    // Update is called once per frame
    void Update()
    {
        if (InReach && Input.GetButtonDown("Interact"))
        {
            FlashLightSlot.IsPickedUp = true;   
            PickUpSound.Play();
            Dialog.SetActive(false);
            FlashLightObject.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Reach"))
        {
            InReach = true;
            Dialog.GetComponentInChildren<TextMeshProUGUI>().text = Text;
            Dialog.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Reach"))
        {
            InReach = false;
            Dialog.SetActive(false);
        }
    }
}
