using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class SceneManagment : MonoBehaviour
{
    public GameObject num1;
    public GameObject num2;
    public GameObject num3;
    public GameObject num4;
    public GameObject num5;
    
    public void StartPlay()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
    
    public void Tutorial()
    {
        num1.SetActive(true);
    }

    public void Num2()
    {
        num1.SetActive(false);
        num2.SetActive(true);
    }
    
    public void Num3()
    {
        num2.SetActive(false);
        num3.SetActive(true);
    }
    
    public void Num4()
    {
        num3.SetActive(false);
        num4.SetActive(true);
    }
    
    public void Num5()
    {
        num4.SetActive(false);
        num5.SetActive(true);
    }

    public void ExitTutorial()
    {
        num5.SetActive(false);
    }
}
