using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Speech.Tts;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TextToVoice.DependensyServices;
using TextToVoice.Droid.DependencyService;
using Xamarin.Forms;
using static Android.Speech.Tts.TextToSpeech;

[assembly:Dependency(typeof(TextToSpeechAndroid))]
namespace TextToVoice.Droid.DependencyService
{
    public class TextToSpeechAndroid : Java.Lang.Object,ITextToSpeech,IOnInitListener
    {
        private TextToSpeech speaker;
        private string toSpeak;

        public void OnInit([GeneratedEnum] OperationResult status)
        {
            speaker.Speak(toSpeak, QueueMode.Flush, null, null);
        }

        public void Speech(string text)
        {
            toSpeak = text;
            if(speaker == null){
                speaker = new TextToSpeech(Android.App.Application.Context, this);
            }
            else
            {
                if (Build.VERSION.SdkInt >= BuildVersionCodes.Lollipop)
                {
                    speaker.Speak(toSpeak, QueueMode.Flush, null, null);
                }
            }
            
        }
    }
}