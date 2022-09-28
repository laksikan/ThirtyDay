using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEditor;
using UnityEngine.UI;

//[CreateAssetMenu(fileName = "New Resource", menuName = "Resource")]

public abstract class Resource : ScriptableObject
{
    public string name;
    public string description;
    public float Mass;
    public float Value;

    public Sprite artwork;

    public bool renameOnValidate = false;
    
    public abstract string ItemType
    {
        get;
    }
    
    private void OnValidate()
    {
        if (renameOnValidate)
        {
            string thisFileNewName = name;
            string assetPath = AssetDatabase.GetAssetPath(this.GetInstanceID());
            AssetDatabase.RenameAsset(assetPath, thisFileNewName);
            renameOnValidate = false;
        }           
    }            
    
    
}
public enum Item_Type 
{
    Material, Food, Weapon, Apparel, Consumed
}
