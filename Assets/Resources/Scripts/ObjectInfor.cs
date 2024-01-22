using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectInfor : MonoBehaviour
{
    public string text = "pick up [E]";
    public Inventory.KeyIndex keyIndex;
    private bool flag = false;

    private void Update()
    {
        if (flag && Input.GetButtonDown("Interact")) {
            FindObjectOfType<Inventory>().SetKeyAt(keyIndex);
            FindObjectOfType<UpdateCanvas>().updateCavas("");
            this.gameObject.SetActive(false);
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("player_interact"))
        {
            other.GetComponent<UpdateCanvas>().updateCavas(text);
            flag = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("player_interact"))
        {
            other.GetComponent<UpdateCanvas>().updateCavas("");
            flag = false;
        }
    }
}
