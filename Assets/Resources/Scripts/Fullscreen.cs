using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fullscreen : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Screen.fullScreenMode = FullScreenMode.ExclusiveFullScreen;
    }
}
