using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableObject : MonoBehaviour
{
    public GameObject gameobject;
    public void MEnableObject()
    {
        gameobject.SetActive(true);
    }

    public void MDisableObject()
    {
        gameobject.SetActive(false);
    }

}
