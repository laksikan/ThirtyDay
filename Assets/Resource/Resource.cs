using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEditor;
using UnityEngine.UI;

//[CreateAssetMenu(fileName = "New Resource", menuName = "Resource")]

public abstract class Resource : ScriptableObject
{
    public string itemId;
    public string displayName;
    public string description;
    public float Mass;
    public float Value;
    

    public Sprite artwork;

    public abstract string ItemType
    {
        get;
    }

    



}
public enum Item_Type  
{
    Material, Food, Weapon, Apparel, Consumed
}
