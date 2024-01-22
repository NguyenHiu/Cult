using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public enum KeyIndex
    {
        hasDoorKey = 0,
        hasCarKey = 1,
    }

    public bool[] keys = {false, false};
    public void SetKeyAt(KeyIndex index)
    {
        keys[(int)index] = true;
    }

    public bool GetKeyAt(KeyIndex index)
    {
        return keys[(int)index];
    }
}

