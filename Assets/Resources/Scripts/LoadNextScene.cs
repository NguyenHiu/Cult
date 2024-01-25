using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadNextScene : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("player"))
        {
            SceneManager.LoadScene(2);
            other.transform.position = new Vector3(683f, 10f, 532.5f);
            other.transform.eulerAngles = new Vector3(0f, 90f, 0f);
        }
    }

}
