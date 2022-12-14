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
    public GameObject clockhand;

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
        //ปรับนาฬิกา เป็นตอนเช้า
        clockhand.transform.rotation = Quaternion.Euler(0,0,110);
        
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
        state = TurnState.EndTurn;
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
            //110
            clockhand.transform.rotation = Quaternion.Euler(0,0,110);
            name = "Morning";
        }
        else if (periodTurn == 2)
        {
            //160
            clockhand.transform.rotation = Quaternion.Euler(0,0,160);
            name = "Noon";
        }
        else if (periodTurn == 3)
        {
            //200
            clockhand.transform.rotation = Quaternion.Euler(0,0,200);
            name = "Afternoon";
        }
        else if (periodTurn == 4)
        {
            //250
            clockhand.transform.rotation = Quaternion.Euler(0,0,250);
            name = "Evening";
        }
        else if (periodTurn == 5)
        {
            clockhand.transform.rotation = Quaternion.Euler(0,0,0);
            name = "Night";
        }
        return name;
    }
}
