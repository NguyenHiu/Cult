using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandAnimation : MonoBehaviour
{
    [SerializeField] Animator anim;
    private bool _leftArmActive = false;
    private bool _rightArmActive = false;

    void Start()
    {
        Debug.Log("Layer LeftArm Index: " + anim.GetLayerIndex("LeftArm"));
        Debug.Log("Layer RightArm Index: " + anim.GetLayerIndex("RightArm"));
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Flashlight"))
        {
            _leftArmActive = !_leftArmActive;
            anim.SetBool("OpenFlashlight", _leftArmActive);
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

        if (Input.GetButtonDown("Pickup"))
        {
            anim.SetTrigger("Pickup");
            // if (_rightArmActive)
            // {
            //     anim.SetLayerWeight(2, 0);
            //     _rightArmActive = false;
            // }
            // else
            // {
            //     anim.SetLayerWeight(2, 1);
            //     _rightArmActive = true;
            // }

        }
    }
}
