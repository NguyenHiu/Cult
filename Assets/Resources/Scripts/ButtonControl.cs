using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ButtonControl : MonoBehaviour
{
    public TextMeshProUGUI textMesh;

    void Start()
    {
        textMesh = GetComponent<TextMeshProUGUI>();
    }

    // The mesh goes red when the mouse is over it...
    void OnMouseEnter()
    {
        textMesh.text = "Enter";
    }

    // ...the red fades out to cyan as the mouse is held over...
    void OnMouseOver()
    {
        textMesh.color -= new Color(0.1F, 0, 0) * Time.deltaTime;
    }

    // ...and the mesh finally turns white when the mouse moves away.
    void OnMouseExit()
    {
        textMesh.text = "Exit";
    }
}
