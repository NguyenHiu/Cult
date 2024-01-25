using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GetKey : MonoBehaviour
{
    public Inventory.KeyIndex keyIndex;
    private bool flag = false;
    // Start is called before the first frame update

    private void Update()
    {
        if (flag && Input.GetButtonDown("Pickup"))
        {
            FindObjectOfType<Inventory>().SetKeyAt(keyIndex);
            GameObject.FindGameObjectWithTag("hint").GetComponent<TextMeshProUGUI>().text = "";
            GameObject.FindGameObjectWithTag("object_infor").GetComponent<TextMeshProUGUI>().text = "";
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
