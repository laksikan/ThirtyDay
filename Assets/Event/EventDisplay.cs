using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventDisplay : MonoBehaviour
{
    public GameObject ExplosionEvent;
    public GameObject ChoiceE1;
    public GameObject ChoiceE2;
    public GameObject ChoiceE3;
    public GameObject RefrigeratorEvent;
    public GameObject ChoiceR1;
    public GameObject ChoiceR2;
    public GameObject ChoiceR3;
    
    public int ChoiceExplosion;
    public int ChoiceRefrigerator;

    //-------------------Result of main event--------------------------//
    public void ExplosionOption1()
    {
        Debug.Log("Battle with Bandit");
        ChoiceExplosion = 1;
    }
    
    public void ExplosionOption2()
    {
        Debug.Log("Lost 1 Turn");
        ChoiceExplosion = 2;
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
