using System;
using System.Threading;
using System.Threading.Tasks;



namespace MAUI_Lessons;

public partial class SetedTimerPage : ContentPage
{

    private TimeSpan remainingTime;
    private CancellationTokenSource cts;

    public SetedTimerPage()
	{
		InitializeComponent();

		Hour1.Text = DataStore.SharedHour1;
		Hour2.Text = DataStore.SharedHour2;

		Minute1.Text = DataStore.SharedMinute1;
		Minute2.Text = DataStore.SharedMinute2;

		Second1.Text = DataStore.SharedSecond1;
		Second2.Text = DataStore.SharedSecond2;

		remainingTime = TimeSpan.Parse($"{Hour1.Text + Hour2.Text}:{Minute1.Text + Minute2.Text}:{Second1.Text + Second2.Text}");
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();

        cts = new CancellationTokenSource();
        await StartCountdown(cts.Token);
    }

    private async Task StartCountdown(CancellationToken token)
    {
        while (remainingTime.TotalSeconds > 0)
        {
            if (token.IsCancellationRequested)
                break;

            UpdateTimeLabels(remainingTime);

            await Task.Delay(1000, token);
            remainingTime = remainingTime.Subtract(TimeSpan.FromSeconds(1));
        }

        UpdateTimeLabels(TimeSpan.Zero);
        await Navigation.PushAsync(new ALARM());
    }

    private async Task UpdateTimeLabels(TimeSpan time)
    {
        string timeString = time.ToString(@"hhmmss");

        Hour1.Text = timeString[0].ToString();
        Hour2.Text = timeString[1].ToString();
        Minute1.Text = timeString[2].ToString();
        Minute2.Text = timeString[3].ToString();
        Second1.Text = timeString[4].ToString();
        Second2.Text = timeString[5].ToString();
    }
}