using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashlight : MonoBehaviour
{
    public GameObject flashlight;

    public AudioSource turnOn, turnOff;

    public bool on;

    public bool IsPickedUp = false;

    // Start is called before the first frame update
    void Start()
    {
        on = false;
        flashlight.SetActive(on);
    }

    // Update is called once per frame
    void Update()
    {
        if (!IsPickedUp)
            return;
        if (!on && Input.GetButtonDown("F"))
        {
            on = true;
            flashlight.SetActive(on);
            turnOn.Play();
        } else if (on && Input.GetButtonDown("F"))
        {
            on = false;
            turnOff.Play();
            flashlight.SetActive(on);
        }
    }
}
