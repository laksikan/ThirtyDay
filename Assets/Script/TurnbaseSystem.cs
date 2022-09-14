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
    public int Day = 1;
    public int DayPeriod = 1;
    
    //TextInterfaceShowoff
    public Text DayText;
    public Text DayPeriodText;
    public Text TurnStateText;

    #endregion
    void Start()
    {
        state = TurnState.Start;
        _SetupTurn();
    }
    
    void Update()
    {
        
    }

    void _SetupTurn()
    {
        //endsetup
        state = TurnState.ActionTurn;
    }

    public void _ActionTurn()
    {
        
    }

    public void _EndTurn()
    {
        _ProcessDay(1);
        DayPeriodText.text = _NameDayPeriod(DayPeriod);
        DayText.text = Day.ToString();
    }

    void _EndGame()
    {
        
    }
    
    private void _ProcessDay(int addTurn)
    {
        DayPeriod = DayPeriod + addTurn;
        
        //ขึ้นวันใหม่จบเทิร์นที่ 5
        if (DayPeriod == 6)
        {
            DayPeriod = 1;
            Day++;
            
        }
        
    }

    private string _NameDayPeriod(int periodTurn)
    {
        string name = "NaN";
        if (periodTurn == 1)
        {
            name = "Dawn";
        }
        else if (periodTurn == 2)
        {
            name = "Morning";
        }
        else if (periodTurn == 3)
        {
            name = "Noon";
        }
        else if (periodTurn == 4)
        {
            name = "Evening";
        }
        else if (periodTurn == 5)
        {
            name = "Night";
        }
        return name;
    }
}
