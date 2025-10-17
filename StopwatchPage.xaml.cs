using System.Diagnostics;

namespace MAUI_Lessons;

public partial class StopwatchPage : ContentPage
{
    Stopwatch stopwatch = new Stopwatch();
    IDispatcherTimer timer;

    public StopwatchPage()
	{
		InitializeComponent();

        timer = Dispatcher.CreateTimer();
        timer.Interval = TimeSpan.FromSeconds(1);
        timer.Tick += (s, e) =>
        {
            UpdateTime();
        };
    }

    async void StartStopwatch(object sender, EventArgs args)
    {
        stopwatch.Start();
        timer.Start();
    }

    async void StopStopwatch(object sender, EventArgs args)
    {
        stopwatch.Stop();
        timer.Stop();
    }

    async void ResetStopwatch(object sender, EventArgs args)
    {
        timer.Start();
        stopwatch.Reset();
    }

    void UpdateTime()
	{
        TimeSpan elapsed = stopwatch.Elapsed;
        string targetTime = $"{elapsed.Days:D2}:{elapsed.Hours:D2}:{elapsed.Minutes:D2}:{elapsed.Seconds:D2}";

        DayDigit1.Text = targetTime[0].ToString();
        DayDigit2.Text = targetTime[1].ToString();
        HoursDigit1.Text = targetTime[3].ToString();
        HoursDigit2.Text = targetTime[4].ToString();
        MinutesDigit1.Text = targetTime[6].ToString();
        MinutesDigit2.Text = targetTime[7].ToString();
        SecondsDigit1.Text = targetTime[9].ToString();
        SecondsDigit2.Text = targetTime[10].ToString();

    }
}