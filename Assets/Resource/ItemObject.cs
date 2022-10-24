using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemObject : MonoBehaviour
{
    public Resource referenceItem;
    
    void Addup()
    {
        InventorySystem.Instance.Add(referenceItem);
    }
}
