
using UnityEngine;

public class LoadNextScene : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("player"))
        {
            GameObject.FindAnyObjectByType<LoadingScreen>().LoadScene(3);
        }
    }

}
