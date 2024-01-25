using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityTutorial.PlayerControl;

public class HandAnimation : MonoBehaviour
{
    [SerializeField] Animator anim;
    private FlashlightControl flashlightControl;
    private bool _leftArmActive = false;
    private bool _rightArmActive = false;
    private bool _isFreezing = false;

    private void Awake()
    {
        flashlightControl = FindAnyObjectByType<FlashlightControl>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!_isFreezing && Input.GetButtonDown("Flashlight"))
        {
            _leftArmActive = !_leftArmActive;
            anim.SetBool("OpenFlashlight", _leftArmActive);
            if (_leftArmActive )
            {
                flashlightControl.TurnOn();
            } else
            {
                flashlightControl.TurnOff();
            }
            // if (_leftArmActive)
            // {
            //     anim.SetLayerWeight(1, 0);
            //     _leftArmActive = false;
            // }
            // else
            // {
            //     anim.SetLayerWeight(1, 1);
            //     _leftArmActive = true;
            // }

        }

    }
}