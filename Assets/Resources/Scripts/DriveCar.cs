using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DriveCar : MonoBehaviour
{
    private bool flag = false;

    private void Update()
    {
        if (flag && Input.GetButtonDown("Interact"))
        {
            Debug.Log("Driving car ... ");
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
