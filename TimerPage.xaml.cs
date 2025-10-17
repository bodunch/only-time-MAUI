namespace MAUI_Lessons;

public partial class TimerPage : ContentPage
{
    List<int> hours1 = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
    int hours1Index = 0;

    List<int> hours2 = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
    int hours2Index = 0;

    List<int> minutes1 = new List<int> { 0, 1, 2, 3, 4, 5 };
    int minutes1Index = 0;

    List<int> minutes2 = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
    int minutes2Index = 0;

    List<int> seconds1 = new List<int> { 0, 1, 2, 3, 4, 5 };
    int seconds1Index = 0;

    List<int> seconds2 = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
    int seconds2Index = 0;

    public TimerPage()
	{
		InitializeComponent();
	}

	async void StartTimer(object sender, EventArgs args)
	{
        DataStore.SharedHour1 = Hours1.Text;
        DataStore.SharedHour2 = Hours2.Text;
        DataStore.SharedMinute1 = Minutes1.Text;
        DataStore.SharedMinute2 = Minutes2.Text;
        DataStore.SharedSecond1 = Seconds1.Text;
        DataStore.SharedSecond2 = Seconds2.Text;

        if(Convert.ToInt32(Seconds2.Text) > 0 || Convert.ToInt32(Seconds2.Text) > 0 ||
            Convert.ToInt32(Minutes2.Text) > 0 || Convert.ToInt32(Minutes1.Text) > 0 ||
            Convert.ToInt32(Hours2.Text) > 0 || Convert.ToInt32(Hours1.Text) > 0)
        await Navigation.PushAsync(new SetedTimerPage());
	}

	async void UpHours1(object sender, EventArgs args)
	{
        if(hours1.Count > hours1Index + 1)
        {
            hours1Index++;
        }
        else
        {
            hours1Index = 0;
        }
        Hours1.Text = Convert.ToString(hours1[hours1Index]);
	}

    async void UpHours2(object sender, EventArgs args)
    {
        if (hours2.Count > hours2Index + 1)
        {
            hours2Index++;
        }
        else
        {
            hours2Index = 0;
        }
        Hours2.Text = Convert.ToString(hours2[hours2Index]);
    }

    async void UpMinutes1(object sender, EventArgs args)
    {
        if(minutes1.Count > minutes1Index + 1)
        {
            minutes1Index++;
        }
        else
        {
            minutes1Index = 0;
        }
        Minutes1.Text = Convert.ToString(minutes1[minutes1Index]);
    }

    async void UpMinutes2(object sender, EventArgs args)
    {
        if (minutes2.Count > minutes2Index + 1)
        {
            minutes2Index++;
        }
        else
        {
            minutes2Index = 0;
        }
        Minutes2.Text = Convert.ToString(minutes2[minutes2Index]);
    }

    async void UpSeconds1(object sender, EventArgs args)
    {
        if (seconds1.Count > seconds1Index + 1)
        {
            seconds1Index++;
        }
        else
        {
            seconds1Index = 0;
        }
        Seconds1.Text = Convert.ToString(seconds1[seconds1Index]);
    }

    async void UpSeconds2(object sender, EventArgs args)
    {
        if (seconds2.Count > seconds2Index + 1)
        {
            seconds2Index++;
        }
        else
        {
            seconds2Index = 0;
        }
        Seconds2.Text = Convert.ToString(seconds2[seconds2Index]);
    }

    async void DownHours1(object sender, EventArgs args)
    {
        if(hours1Index > 0)
        {
            hours1Index--;
        }
        else
        {
            hours1Index = hours1[hours1.Count - 1];
        }
        Hours1.Text = Convert.ToString(hours1[hours1Index]);
    }

    async void DownHours2(object sender, EventArgs args)
    {
        if (hours2Index > 0)
        {
            hours2Index--;
        }
        else
        {
            hours2Index = hours2[hours2.Count - 1];
        }
        Hours2.Text = Convert.ToString(hours2[hours2Index]);
    }

    async void DownMinutes1(object sender, EventArgs args)
    {
        if (minutes1Index > 0)
        {
            minutes1Index--;
        }
        else
        {
            minutes1Index = minutes1[minutes1.Count - 1];
        }
        Minutes1.Text = Convert.ToString(minutes1[minutes1Index]);
    }

    async void DownMinutes2(object sender, EventArgs args)
    {
        if (minutes2Index > 0)
        {
            minutes2Index--;
        }
        else
        {
            minutes2Index = minutes2[minutes2.Count - 1];
        }
        Minutes2.Text = Convert.ToString(minutes2[minutes2Index]);
    }

    async void DownSeconds1(object sender, EventArgs args)
    {
        if (seconds1Index > 0)
        {
            seconds1Index--;
        }
        else
        {
            seconds1Index = seconds1[seconds1.Count - 1];
        }
        Seconds1.Text = Convert.ToString(seconds1[seconds1Index]);
    }

    async void DownSeconds2(object sender, EventArgs args)
    {
        if(seconds2Index > 0)
        {
            seconds2Index--;
        }
        else
        {
            seconds2Index = seconds2[seconds2.Count - 1];
        }
        Seconds2.Text = Convert.ToString(seconds2[seconds2Index]);
    }
}