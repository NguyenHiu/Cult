using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Transactions;
using TMPro;
using UnityEngine;

public class OpenCloseInteraction : MonoBehaviour
{
    [SerializeField] AudioSource m_AudioSource;
    Animator anim;
    Inventory inventory;
    public Inventory.KeyIndex requiredKey;


    private bool _isOpen = false;
    private bool flag = false;

    private void Awake()
    {
        m_AudioSource.playOnAwake = false;
        anim = GetComponent<Animator>();
        inventory = FindAnyObjectByType<Inventory>();
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

    private void Update()
    {
        if ( flag && Input.GetButtonDown("Interact"))
        {
            if ((int)requiredKey == 0 || inventory.GetKeyAt(requiredKey))
            {
                anim.SetBool("Open", !_isOpen);
                _isOpen = !_isOpen;
                m_AudioSource.Play();
            } 
        }
    }
}
