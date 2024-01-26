using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackPlayer : MonoBehaviour
{
    [SerializeField] GameObject die;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("player"))
        {
            die.SetActive(true);
            StartCoroutine(WAITING());
        }
    }

    IEnumerator WAITING()
    {
        yield return new WaitForSeconds(5);

        FindAnyObjectByType<LoadingScreen>().LoadScene(0);
    }
}
