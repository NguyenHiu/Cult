using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public enum KeyIndex
    {
        None = 0,
        hasDoorKey = 1,
        hasCarKey = 2,
        hasDoor1Key = 3,
        hasExitDoorKey = 4,
    }

    public bool[] keys = {true, false, false, false, false };
    public void SetKeyAt(KeyIndex index)
    {
        keys[(int)index] = true;
    }

    public bool GetKeyAt(KeyIndex index)
    {
        return keys[(int)index];
    }
}

