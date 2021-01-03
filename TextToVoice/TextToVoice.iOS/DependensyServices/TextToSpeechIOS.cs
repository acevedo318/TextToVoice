using AVFoundation;
using Foundation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TextToVoice.DependensyServices;
using TextToVoice.iOS.DependensyServices;
using UIKit;
using Xamarin.Forms;

[assembly: Dependency(typeof(TextToSpeechIOS))]
namespace TextToVoice.iOS.DependensyServices
{
    public class TextToSpeechIOS : ITextToSpeech
    {
        public void Speech(string text)
        {
            var speachSynthetizer = new AVSpeechSynthesizer();
            var speechUterance = new AVSpeechUtterance(text)
            {
                Rate = AVSpeechUtterance.MaximumSpeechRate / 4,
                Voice = AVSpeechSynthesisVoice.FromLanguage("es-MX"),
                Volume = 0.5f,
                PitchMultiplier = 1.0f
            };
            speachSynthetizer.SpeakUtterance(speechUterance);
        }
    }
}