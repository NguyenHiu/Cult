using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class OpenCloseDialog : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI dialog;
    [SerializeField] Inventory.KeyIndex requiredKey;
    [SerializeField] string textKeyMissing = "Missing Key";
    [SerializeField] string textHint = "Open/Close [E]";
    [SerializeField] Inventory inventory;

    private void Awake()
    {
        inventory = FindAnyObjectByType<Inventory>();
        dialog = GameObject.FindGameObjectWithTag("hint").GetComponent<TextMeshProUGUI>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("player_interact"))
        {
            if (inventory.GetKeyAt(requiredKey))
            {
                dialog.text = textHint;
            } else
            {
                dialog.text = textKeyMissing;
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("player_interact"))
        {
            dialog.text = "";
        }
    }

}
