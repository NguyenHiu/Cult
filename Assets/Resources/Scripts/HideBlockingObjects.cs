using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideBlockingObjects : MonoBehaviour
{
    [SerializeField] GameObject m_gameObject;

    public void HideObjets()
    {
        m_gameObject.SetActive(false);
    }
}
