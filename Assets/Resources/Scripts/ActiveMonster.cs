using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveMonster : MonoBehaviour
{
    [SerializeField] private GameObject Key;
    [SerializeField] private GameObject Monster;

    private void Update()
    {
        if (Key.activeInHierarchy == false)
        {
            Monster.SetActive(true);
            this.gameObject.SetActive(false);
        }
    }

}
