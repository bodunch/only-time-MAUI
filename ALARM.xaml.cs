namespace MAUI_Lessons;

public partial class ALARM : ContentPage
{
	public ALARM()
	{
		InitializeComponent();
	}

	async void BackToClocks(object sender, EventArgs args)
	{
		await Navigation.PushAsync(new StartPage());
	}
}