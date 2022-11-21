using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Display : MonoBehaviour
{   
    public Card card;
    public Text descriptionText,c1,c2,c3;
    public Image backgroundImage,eventImage;
    public Button button1,button2;
    
    void Start()
    {   
        
        descriptionText.text = card.description;
        eventImage.sprite = card.eventImage;
        c1.text = card.choice1;
        c2.text = card.choice2;
        c3.text = card.choice3;
    }


}
