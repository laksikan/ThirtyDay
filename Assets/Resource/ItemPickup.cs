using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickup : MonoBehaviour
{
    public Resource Item;

    void Addup()
    {
        InventorySystem.Instance.Add(Item);
    }
}
