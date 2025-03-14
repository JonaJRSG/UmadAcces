namespace UmadAcces.Pages;

public partial class LogInGuestPage : ContentPage
{
	public LogInGuestPage()
	{
		InitializeComponent();
	}

    private void LogInGuest(object sender, EventArgs e)
    {
		Application.Current.MainPage = new AppShell();
    }
}