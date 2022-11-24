using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "New Consumed", menuName = "Consumed")]
public class Consumed : Resource
{
    public float nutrition;
    public float heal;
    
    private bool consumed = false;
    
    public override string ItemType
    {
        get
        {
            return "Consumed";
        }
    }

    
}
