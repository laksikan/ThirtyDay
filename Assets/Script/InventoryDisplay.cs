using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryDisplay : MonoBehaviour
{
    public  GameObject InventoryBox;
    public  GameObject DetailBox;

    public void ShowInventory() 
    {
        if (InventoryBox != null)
        {
            bool isActive = InventoryBox.activeSelf;
            InventoryBox.SetActive(!isActive);
        }
    }
    
    public void CloseInventory()
    {
        InventoryBox.SetActive(false);
    }
    
    public void ShowDetailBox()
    {
        DetailBox.SetActive(true);
    }
    
    public void CloseDetailBox()
    {
        DetailBox.SetActive(false);
    }
}
