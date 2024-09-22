namespace BreakTime.Custom;

public class TimerLogic
{
    private int _intSec;
    private int _intMin;

    public TimerLogic()
    {
        _intSec = 30;
        _intMin = 1;
    }
    public void SetTickCountdown()
    {
        
        
            //if seconds is 0 move to 59 and subtract one minute
            if (_intSec == 0)
            {
                _intSec = 59;
                _intMin--;
                //display min left on label
            }
            else if (_intSec != 0)
            {
                _intSec--;
            }
            else if (_intSec == 0 && _intMin == 0)
            {
                //display time is up and change background color
                
                
            }
        


    }

 

    //format time using min and seconds with additional placement of 0
    public string GetFormatedString()
    {
        return _intMin.ToString().PadLeft(2, '0') + ":" + _intSec.ToString().PadLeft(2, '0');
    }
}