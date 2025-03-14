using System.Threading.Tasks;

namespace UmadAcces.Pages;

public partial class InvitationPage : ContentPage
{
	public InvitationPage()
	{
		InitializeComponent();
	}

    private async void newInvitation(object sender, EventArgs e)
    {
		await Navigation.PushAsync(new NewInvitationPage());
    }
}