using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[Serializable]
public class InventoryItem
{
    public Resource data { get; private set; }
    public int stackSize { get; private set; }

    public InventoryItem(Resource source)
    {
        data = source;
        AddtoStack();
    }

    public void AddtoStack()
    {
        stackSize++;
    }

    public void RemoveFromStack()
    {
        stackSize--;
    }
    
}
