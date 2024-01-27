using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowCursor : MonoBehaviour
{

    private void Start()
    {
        getgo();
    }
    private void getgo()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }

}
