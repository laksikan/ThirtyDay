using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

//[CreateAssetMenu(fileName = "New Resource", menuName = "Resource")]

public abstract class Resource : ScriptableObject
{
    public string name;
    public string description;
    public float Mass;
    public float Value;
    
    public Sprite artwork;
    
     
    
    
}
public enum MyEnumeratedType 
{
    Material, Food, Weapon, Apparel, Item
}
