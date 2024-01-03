namespace MauiToolbarItemIssue
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            // Variant 1 - a bit more complex navigation structure
            MainPage = new NavigationPage(new MainPage());

            // Variant 2 - the most simple navigation structure
            //MainPage = new NavigationPage(new Page2());
        }
    }
}
