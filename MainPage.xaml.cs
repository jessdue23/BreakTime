
using BreakTime.Custom;
namespace BreakTime;

public partial class MainPage : ContentPage
{

    private TimerLogic oTimer = new TimerLogic();
    private bool isRunning = false;
    
    public MainPage()
    {
        InitializeComponent();
        Title = "Break Time";
    }

 

    private void BtnTakeFive_OnClicked(object sender, EventArgs e)
    { 
        isRunning = true;
       //int intMin = 5;
       //int intSec = 0;
       
       Application.Current.Dispatcher.StartTimer(TimeSpan.FromSeconds(1), () =>
       {
           if (isRunning)
           {
               oTimer.SetTickCountdown();
               lblDisplayBreakTime.Text = oTimer.GetFormatedString();
           }

           return isRunning;
           
           
       });

       //how do i get isRunning to revert back to false in the TimerLogic since the callback will always return true
    }

    private void BtnTakeTen_OnClicked(object sender, EventArgs e)
    {
        throw new NotImplementedException();
    }

    private void BtnTakeFifteen_OnClicked(object sender, EventArgs e)
    {
        throw new NotImplementedException();
    }
}