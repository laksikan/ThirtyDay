using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CreateAssetMenu(fileName = "New Material", menuName = "Material")]
public class Material : Resource
{
    
    public override string ItemType
    {
        get
        {
            return "Material";
        }
    }
}
