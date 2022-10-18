using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MaterialPickUp : MonoBehaviour
{   
   
    public Material Material;
    
    
    
    public void PickUp(){
        //InventoryManeger.Instance.Remove(Material);
        InventoryManeger.Instance.Add(Material);        
    }
    private void OnMouseDown(){
        
        PickUp();
        
        
    }
    
}
