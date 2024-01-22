using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyDetect : MonoBehaviour
{
    public OpenCloseInteraction openCloseAnim;
    public Inventory.KeyIndex keyIndex;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("player") && other.GetComponentInChildren<Inventory>().GetKeyAt(keyIndex))
        {
            openCloseAnim.enabled = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("player"))
        {
            openCloseAnim.enabled = false;
        }
    }
}
