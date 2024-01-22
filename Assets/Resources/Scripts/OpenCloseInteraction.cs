using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Transactions;
using UnityEngine;

public class OpenCloseInteraction : MonoBehaviour
{
    [SerializeField] Animator anim;
    private bool _isOpen = false;
    private bool flag = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("player_interact"))
        {
            flag = true;
            Debug.Log("player enter");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("player_interact"))
        {
            flag = false;
            Debug.Log("player exit");
        }
    }

    private void Update()
    {
        if ( flag && Input.GetButtonDown("Interact"))
        {
            Debug.Log("db");
            anim.SetBool("Open", !_isOpen);
            _isOpen = !_isOpen;
        }
    }
}
