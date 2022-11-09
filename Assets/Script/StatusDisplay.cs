using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatusDisplay : MonoBehaviour
{
    public GameObject StatusBox;
    public GameObject UnequipButton;

    public void ShowStatusDisplay()
    {
        if (StatusBox != null)
        {
            bool isActive = StatusBox.activeSelf;
            StatusBox.SetActive(!isActive);
        }
    }
    
    public void CloseStatusDisplay()
    {
        StatusBox.SetActive(false);
    }
    
    public void ShowUnequipButton()
    {
        if (UnequipButton != null)
        {
            bool isActive = UnequipButton.activeSelf;
            UnequipButton.SetActive(!isActive);
        }
    }
}
