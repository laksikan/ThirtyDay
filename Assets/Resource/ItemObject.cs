using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemObject : MonoBehaviour
{
    public Resource referenceItem;
    public InventoryItemControl refItem;
    
    public void Addup()
    {
        InventorySystem.Instance.Add(referenceItem);
        refItem.AddItem(referenceItem);
    }

    public void RemoveItem()
    {
        InventorySystem.Instance.Remove(referenceItem);
        Destroy(gameObject);
    }
    
}
