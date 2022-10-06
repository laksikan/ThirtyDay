using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
[CreateAssetMenu(fileName = "New Card",menuName = "Cards/Minion")]
public class Card : ScriptableObject
{
    public new string name;
    public Sprite eventI,background;
    public string description,choice1,choice2;

}
