using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashlightControl : MonoBehaviour
{
    [SerializeField] GameObject spotlight;

    public void TurnOn()
    {
        spotlight.SetActive(true);
    }

    public void TurnOff()
    {
        spotlight.SetActive(false);
    }
}
