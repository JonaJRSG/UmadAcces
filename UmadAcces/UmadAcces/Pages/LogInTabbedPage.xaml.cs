namespace UmadAcces.Pages;

public partial class LogInTabbedPage : TabbedPage
{
	public LogInTabbedPage()
	{
		InitializeComponent();
	}

    [Obsolete]
    private void LogIn(object sender, EventArgs e)
    {
		Application.Current.MainPage = new AppShell();
    }
}