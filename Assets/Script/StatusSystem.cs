using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatusSystem : MonoBehaviour
{
    #region Variables

    public static StatusSystem Instance;
    
    //Variable
    private float health = 100;
    private float energy = 100;
    private float stravation = 100;
    private float mass = 25;

    //TextInterfaceShowoff

    public Text HealthText;
    public Slider HealthSlider;
    
    public Text StarvationText;
    public Slider StravationSlider;
    
    public Text EnergyText;
    public Slider EnergySlider;
    

    #endregion
    

    void FixedUpdate()
    {
        DisplayStatus();
    }
    public void DisplayStatus()
    {
        //TextUI
        HealthText.text = Health.ToString() + " /100";
        StarvationText.text = Stravation.ToString() + " /100";
        EnergyText.text = Energy.ToString() + " /100";
        //SliderUI
        HealthSlider.value = Health;
        StravationSlider.value = Stravation;
        EnergySlider.value = Energy;
    }

    public float Health
    {
        get { return health; }
        set
        {
            health = value;
            if (health > 100)
            {
                health = 100;
            }
        }
    }
    public float Stravation
    {
        get { return stravation; }
        set
        {
            stravation = value;
            if (stravation > 100)
            {
                stravation = 100;
            }
        }
    }
    public float Energy
    {
        get { return energy; }
        set
        {
            energy = value;
            if (energy > 100)
            {
                energy = 100;
            }
        }
    }

    public float Mass
    {
        get;
        set;
    }
    

    public void addHealth(float add)
    {
        Health = health + add;
    }

    public void reduceHealth(float reduce)
    {
        Health = Health - reduce;
    }
    
    public void addStravation(float add)
    {
        Stravation = Stravation + add;
    }
    
    public void reduceStravation(float reduce)
    {
        Stravation = Stravation - reduce;
    }
    
    public void addEnergy(float add)
    {
        Energy = Energy + add;
    }
    public void reduceEnergy(float reduce)
    {
        Energy = Energy - reduce;
    }
}
