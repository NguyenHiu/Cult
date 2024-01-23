using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ObjectDialog : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI m_TextMeshProUGUI;
    [SerializeField] string text;
    private void Awake()
    {
        m_TextMeshProUGUI = FindAnyObjectByType<Canvas>().GetComponentInChildren<TextMeshProUGUI>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("player_interact"))
        {
            m_TextMeshProUGUI.text = text;  
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("player_interact"))
        {
            m_TextMeshProUGUI.text = "";
        }
    }
}

