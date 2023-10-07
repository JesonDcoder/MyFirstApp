using MyFirstApp.Pages;

namespace MyFirstApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Signup();
        }
    }
}