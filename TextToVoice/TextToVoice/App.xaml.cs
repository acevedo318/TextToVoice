using System;
using TextToVoice.Services;
using TextToVoice.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TextToVoice
{
    public partial class App : Application
    {
        public static object Application { get; set; }

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
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
