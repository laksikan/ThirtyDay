using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
[CreateAssetMenu(fileName = "New CardEvent",menuName = "Event")]
public class Card : ScriptableObject
{
    public new string name;
    public Sprite eventImage,background;
    public string description,choice1,choice2,choice3;
    public int numChoice;

}
