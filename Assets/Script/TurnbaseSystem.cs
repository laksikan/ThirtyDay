using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum TurnState {Start,Notification , ActionTurn, EndTurn, EndGame }
public class TurnbaseSystem : MonoBehaviour
{
    #region Variables
    
    //Variable
    public TurnState state;
    public int _Day = 1;
    public int _DayPeriod = 1;
    
    //TextInterfaceShowoff
    public Text DayText;
    public Text DayPeriodText;
    public Text TurnStateText;
    public Button EndTurnButton;
    
    #endregion
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

    public void ActionTurn()
    {
        
    }

    public void EndTurn()
    {
    
        DayPeriodText.text = "Stupid";
    }
    
    

    void EndGame()
    {
        
    }
}
