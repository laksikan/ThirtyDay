using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Weapon", menuName = "Weapon")]
public class Weapon : Resource
{
    public float Damage;
    public float Durability;

    public bool equippable;

}

