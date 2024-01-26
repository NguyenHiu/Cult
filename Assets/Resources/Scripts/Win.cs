using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Win : MonoBehaviour
{
    [SerializeField] GameObject win;
    [SerializeField] GameObject ghoul;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("player"))
        {
            win.SetActive(true);
            ghoul.SetActive(false);
            StartCoroutine(WAITING());
        }
    }

    IEnumerator WAITING()
    {
        yield return new WaitForSeconds(10);
        StartCoroutine(RESTART());
    }

    IEnumerator RESTART()
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(0);

        while (!operation.isDone) yield return null;

        win.SetActive(false);

    }
}
