using System;
using System.Collections.Generic;
using System.Text;

namespace TextToVoice.DependensyServices
{
    public interface ITextToSpeech
    {
        void Speech(string text);
    }
}
