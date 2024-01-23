using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetKey : MonoBehaviour
{
    public Inventory.KeyIndex keyIndex;
    private bool flag = false;
    // Start is called before the first frame update

    private void Update()
    {
        if (flag && Input.GetButtonDown("Interact"))
        {
            FindObjectOfType<Inventory>().SetKeyAt(keyIndex);
            this.gameObject.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("player_interact"))
        {
            flag = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("player_interact"))
        {
            flag = false;
        }
    }
}
