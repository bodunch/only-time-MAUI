using System.Threading.Tasks;
using System.Timers;
using Microsoft.Maui.Dispatching;

namespace MAUI_Lessons;

public partial class MainPage : ContentPage
{
    private readonly IDispatcherTimer timer;
    string alarmTime = DataStore.SharedAlarmTime;

    public MainPage()
    {
        InitializeComponent();

        timer = Dispatcher.CreateTimer();
        timer.Interval = TimeSpan.FromSeconds(1);
        timer.Tick += Timer_Tick;
        timer.Start();

        UpdateTime();
    }

    private void Timer_Tick(object sender, EventArgs e)
    {
        UpdateTime();
    }

    private async Task UpdateTime()
    {
        var now = DateTime.Now.ToString("HHmm"); // формат 24 години, наприклад "0935"

        if(now == alarmTime)
        {
            await Navigation.PushAsync(new ALARM());
            alarmTime = null;
        }

        Hours1.Text = now[0].ToString();
        Hours2.Text = now[1].ToString();
        Minutes1.Text = now[2].ToString();
        Minutes2.Text = now[3].ToString();
    }
}