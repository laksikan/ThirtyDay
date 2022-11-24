using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryItemControl : MonoBehaviour
{
    Resource item;
    private Consumed _consumed;

    public void RemoveItem()
    {
        Debug.Log(item.displayName);
        //InventorySystem.Instance.Remove(item);
        //Destroy(gameObject);
    }

    public void ConsumedItem()
    {
        InventorySystem.Instance.ConsumedItem(item,_consumed.nutrition,_consumed.heal);
        Destroy(gameObject);
    }

    public void AddItem(Resource newItem)
    {
        item = newItem;
    }
}
