using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wolf : MonoBehaviour
{
    [SerializeField] AudioSource[] sfx;
    [SerializeField] float min, max;
    private float tmpTime;
    private float acc;

    private void Start()
    {
        acc = 0;
        tmpTime = Random.Range(min, max);
    }

    private void Update()
    {
        acc += Time.deltaTime;
        if (acc >= tmpTime) {
            tmpTime = Random .Range(min, max);
            acc = 0;
            sfx[Random.Range(0, sfx.Length)].Play();
        }
    }
}
