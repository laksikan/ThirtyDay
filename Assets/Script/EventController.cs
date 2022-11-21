using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class EventController : MonoBehaviour
{
    public GameObject ExplosionEvent;
    public GameObject ChoiceE1;
    public GameObject ChoiceE2;
    public GameObject ChoiceE3;
    public GameObject RefrigeratorEvent;
    public GameObject ChoiceR1;
    public GameObject ChoiceR2;
    public GameObject ChoiceR3;
    
    public int digit;
    
    public int ChoiceExplosion;
    public int ChoiceRefrigerator;
    

    //-------------------Result of main event--------------------------//
    public void ExplosionOption1()
    {
        ChoiceExplosion = 1;
        
        if (ChoiceExplosion == 1)
        {
            Debug.Log("Battle with Bandit");
            digit = Random.Range(0, 100);
            
            if (digit <= 10 ) 
            {
                Debug.Log(digit);
                Debug.Log("You Got Lucky Loot Box");
                Debug.Log("Assault Rifle +1\n" +
                          "Token +2\n" +
                          "Meat +5\n");
            } else {
                Debug.Log(digit);
                Debug.Log("You Got Normal Loot Box");
                Debug.Log("Token +1\n" +
                          "Bread +2\n");
            }
        }
    }
    
    public void ExplosionOption2()
    {
        Debug.Log("Lost 1 Turn");
        ChoiceExplosion = 2;
        
        if (ChoiceExplosion == 2)
        {
            digit = Random.Range(0, 100);
            if (digit <= 8 )
            {
                Debug.Log(digit);
                Debug.Log("You Got Normal Loot Box");
                Debug.Log("Token +1\n" +
                          "Bread +2\n");
            } else {
                Debug.Log(digit);
                Debug.Log("You Got Empty Loot Box");
            }
        }
    }
    
    public void ExplosionOption3()
    {
        Debug.Log("Nothing Happened -> Continue Travelling");
        ChoiceExplosion = 3;
    }
    
    //---------------------Result of second event-----------------------//
    public void RefrigeratorOption1()
    {
        Debug.Log("30% -> Nothing Happened\n" +
                  "30% -> Battle with Giant Cockroach\n" +
                  "30% -> Battle with Junkie\n" +
                  "10% -> Found the village\n");
        ChoiceRefrigerator = 1;
        
        if (ChoiceRefrigerator == 1)
        {
            ExplosionEvent.SetActive(false);
            digit = Random.Range(0, 100);
            
            if (digit <= 9 ) 
            {
                Debug.Log(digit);
                Debug.Log("You Found the Village");
                
            } else if (digit < 30 && digit >= 10) {
                
                Debug.Log(digit);
                Debug.Log("Fight with Junkie");
                
            }else if (digit < 60 && digit >= 30) {
                
                Debug.Log(digit);
                Debug.Log("A Giant cockroach going to attack you!");
            }
            else
            {
                Debug.Log(digit);
                Debug.Log("It is a Empty Refrigerator");
            }
        }
    }
    
    public void RefrigeratorOption2()
    {
        Debug.Log("Energy Point -18 \n" +
                  "Weapon Duration -3\n" +
                  "Meat +2\n");
        ChoiceRefrigerator = 2;
    }
    
    public void RefrigeratorOption3()
    {
        Debug.Log("Nothing Happened -> Continue Travelling");
        ChoiceRefrigerator = 3;
    }
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Main Event Show up");
            ExplosionEvent.SetActive(true);
        }

        if ( ChoiceExplosion >= 1)
        {
            ExplosionEvent.SetActive(false);
            RefrigeratorShowUp();
        }

        void RefrigeratorShowUp()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Debug.Log("Refrigerator Event Show up");
                RefrigeratorEvent.SetActive(true);
            }
            if ( ChoiceRefrigerator >= 1)
            {
                RefrigeratorEvent.SetActive(false);
            }
        }
        
        
    }
}
