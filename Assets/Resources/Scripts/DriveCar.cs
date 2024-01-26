using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DriveCar : MonoBehaviour
{
    private bool flag = false;

    private void Update()
    {
        if (flag && Input.GetButtonDown("Interact"))
        {
            FindAnyObjectByType<LoadingScreen>().LoadScene(2);
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
