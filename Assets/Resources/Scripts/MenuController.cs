using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuController : MonoBehaviour
{
    private LoadingScreen l;

    private void Start()
    {
        l = GetComponent<LoadingScreen>();  
    }
    public void ExitGame()
    {
        Application.Quit(); 
    }

    public void PlayeGame()
    {
        l.LoadScene(1);
    }
}
