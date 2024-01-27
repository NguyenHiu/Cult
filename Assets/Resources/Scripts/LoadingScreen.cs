using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadingScreen : MonoBehaviour
{
    [SerializeField] GameObject MyLoadingScene;

    private void Start()
    {
        MyLoadingScene = transform.GetChild(0).gameObject;
    }

    public void LoadScene(int sceneId)
    {
        StartCoroutine(LoadSceneAsync(sceneId));
    }

    IEnumerator LoadSceneAsync(int sceneId)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneId);

        MyLoadingScene.SetActive(true);

        while (!operation.isDone) yield return null;

    }
}
