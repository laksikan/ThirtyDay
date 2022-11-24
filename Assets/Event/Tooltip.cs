using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
[ExecuteInEditMode()]
public class Tooltip : MonoBehaviour
{   
    
    public TextMeshProUGUI contentField;
    public LayoutElement layoutElement;
    public int characterWrapLimit;
    public void SetText(string content =""){
        if(string.IsNullOrEmpty(content)){
            contentField.gameObject.SetActive(false);
        }
        else{
            contentField.gameObject.SetActive(true);
        }
        contentField.text = content;
    }
}
