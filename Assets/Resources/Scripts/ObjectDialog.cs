using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ObjectDialog : MonoBehaviour
{
    private TextMeshProUGUI m_TextMeshProUGUI;
    private TextMeshProUGUI m_object_infor;
    [SerializeField] string text_hint;
    [SerializeField] string text_obj_infor = "";
    private void Awake()
    {
        m_TextMeshProUGUI = GameObject.FindGameObjectWithTag("hint").GetComponent<TextMeshProUGUI>();
        m_object_infor = GameObject.FindGameObjectWithTag("object_infor").GetComponent<TextMeshProUGUI>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("player_interact"))
        {
            m_TextMeshProUGUI.text = text_hint;  
            m_object_infor.text = text_obj_infor;  
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("player_interact"))
        {
            m_TextMeshProUGUI.text = "";
            m_object_infor.text = "";
        }
    }
}

