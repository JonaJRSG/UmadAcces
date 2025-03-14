using UmadAcces.Pages;

namespace UmadAcces
{
    public partial class App : Application
    {
        [Obsolete]
        public App()
        {
            InitializeComponent();
            MainPage = new LogInTabbedPage();
        }

        //protected override Window CreateWindow(IActivationState? activationState)
        //{
        //    return new Window(new LogInTabbedPage());
        //}
    }
}