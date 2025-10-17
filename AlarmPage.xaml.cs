namespace MAUI_Lessons;

public partial class AlarmPage : ContentPage
{
    List<int> hour1 = new List<int> { 0, 1, 2};
    int hour1Index = 0;

    List<int> hour2 = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9};
    int hour2Index = 0;

    List<int> minute1 = new List<int> { 0, 1, 2, 3, 4, 5 };
    int minute1Index = 0;

    List<int> minute2 = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
    int minute2Index = 0;

	public AlarmPage()
	{
		InitializeComponent();
	}

    async void StartAlarm(object sender, EventArgs args)
    {
        if ((Hour1.Text == "2" && Convert.ToInt32(Hour2.Text) <= 3) || (Hour1.Text == "1") || (Hour1.Text == "0"))
        {
            DataStore.SharedAlarmTime = $"{Hour1.Text + Hour2.Text + Minute1.Text + Minute2.Text}";
            await Navigation.PushAsync(new MainPage());
        }
    }

	async void UpHour1(object sender, EventArgs args)
	{
        if(hour1.Count > hour1Index + 1)
        {
            hour1Index++;
        }
        else
        {
            hour1Index = 0;
        }
        Hour1.Text = Convert.ToString(hour1[hour1Index]);
	}
    async void UpHour2(object sender, EventArgs args)
    {
        if (hour2.Count > hour2Index + 1)
        {
            hour2Index++;
        }
        else
        {
            hour2Index = 0;
        }
        Hour2.Text = Convert.ToString(hour2[hour2Index]);
    }
    async void UpMinute1(object sender, EventArgs args)
    {
        if (minute1.Count > minute1Index + 1)
        {
            minute1Index++;
        }
        else
        {
            minute1Index = 0;
        }
        Minute1.Text = Convert.ToString(minute1[minute1Index]);
    }
    async void UpMinute2(object sender, EventArgs args)
    {
        if (minute2.Count > minute2Index + 1)
        {
            minute2Index++;
        }
        else
        {
            minute2Index = 0;
        }
        Minute2.Text = Convert.ToString(minute2[minute2Index]);
    }
    async void DownHour1(object sender, EventArgs args)
    {
        if (hour1Index > 0)
        {
            hour1Index--;
        }
        else
        {
            hour1Index = hour1[hour1.Count - 1];
        }
        Hour1.Text = Convert.ToString(hour1[hour1Index]);
    }
    async void DownHour2(object sender, EventArgs args)
    {
        if (hour2Index > 0)
        {
            hour2Index--;
        }
        else
        {
            hour2Index = hour2[hour2.Count - 1];
        }
        Hour2.Text = Convert.ToString(hour2[hour2Index]);
    }
    async void DownMinute1(object sender, EventArgs args)
    {
        if (minute1Index > 0)
        {
            minute1Index--;
        }
        else
        {
            minute1Index = minute1[minute1.Count - 1];
        }
        Minute1.Text = Convert.ToString(minute1[minute1Index]);
    }
    async void DownMinute2(object sender, EventArgs args)
    {
        if (minute2Index > 0)
        {
            minute2Index--;
        }
        else
        {
            minute2Index = minute2[minute2.Count - 1];
        }
        Minute2.Text = Convert.ToString(minute2[minute2Index]);
    }
}