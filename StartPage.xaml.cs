namespace MAUI_Lessons;

public partial class StartPage : ContentPage
{
	public StartPage()
	{
		InitializeComponent();
	}
    
    private async void OnClock(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new MainPage());
	}

	private async void OnTimer(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new TimerPage());
	}

	private async void OnStopwatch (object sender, EventArgs e)
	{
		await Navigation.PushAsync(new StopwatchPage());
	}

	private async void OnAlarm (object sender, EventArgs e)
	{
		await Navigation.PushAsync(new AlarmPage());
	}
}