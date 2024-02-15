using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Operators
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new OperatorsPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
