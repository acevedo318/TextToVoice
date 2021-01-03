using System;
using System.ComponentModel;
using TextToVoice.DependensyServices;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TextToVoice.Views
{
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();
        }

        private void btnSpeech_Clicked(object sender, EventArgs e)
        {
            var service = DependencyService.Get<ITextToSpeech>();
            service.Speech(inputText.Text);
        }
    }
}