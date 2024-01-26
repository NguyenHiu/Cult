using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashlightControl : MonoBehaviour
{
    [SerializeField] GameObject spotlight;
    [SerializeField] AudioSource turnOnSfx, turnOffSfx;
    private bool _isActive;

    private void Start()
    {
        spotlight.SetActive(false);
        _isActive = false;
    }

    private void Update()
    {
        if (Input.GetButtonDown("Flashlight"))
        {
            _isActive = !_isActive;
            spotlight.SetActive(_isActive);
            if (_isActive) turnOnSfx.Play();
            else turnOffSfx.Play();
        }
    }
}
