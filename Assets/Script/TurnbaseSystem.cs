using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum TurnState {Start,Notification , ActionTurn, EndTurn }
public class TurnbaseSystem : MonoBehaviour
{
    
    public TurnState state;
    public int Day = 1;
    public int DayPeriod = 1;
    
    void Start()
    {
        state = TurnState.Start;
        SetupTurn();
    }
    
    void Update()
    {
        
    }

    void SetupTurn()
    {
        //endsetup
        state = TurnState.ActionTurn;
    }
}
