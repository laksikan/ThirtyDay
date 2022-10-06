using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UI_Storage : MonoBehaviour
{
    public Sprite artwork;
    [SerializeField] GameObject storage;
    
    public Button UseButton,AllButton,MaterialButton,ConsumedButton,WeaponButton,ApparelButton;
    
    void Start(){
        
        Button btn2 = UseButton.GetComponent<Button>();
		btn2.onClick.AddListener(TaskOnClick_Use);
        Button btn3 =AllButton.GetComponent<Button>();
		btn3.onClick.AddListener(TaskOnClick_All);
        Button btn4 =MaterialButton.GetComponent<Button>();
		btn4.onClick.AddListener(TaskOnClick_Material);
        Button btn5 =ConsumedButton.GetComponent<Button>();
		btn5.onClick.AddListener(TaskOnClick_Consumed);
        Button btn6 =WeaponButton.GetComponent<Button>();
		btn6.onClick.AddListener(TaskOnClick_Weapon);
        Button btn7 =AllButton.GetComponent<Button>();
		btn7.onClick.AddListener(TaskOnClick_Apparel);
    }
   
    void TaskOnClick_Use(){

    }
    void TaskOnClick_All(){

    }
    void TaskOnClick_Material(){

    }
    void TaskOnClick_Consumed(){

    }
    void TaskOnClick_Weapon(){

    }
    void TaskOnClick_Apparel(){

    }
}