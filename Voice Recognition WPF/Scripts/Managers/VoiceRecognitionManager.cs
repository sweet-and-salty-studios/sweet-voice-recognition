using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Speech.Recognition;
using System.Speech.Synthesis;

namespace Voice_Recognition_WPF.Scripts.Managers
{
    public static class VoiceRecognitionManager
    {
        public static SpeechRecognitionEngine SpeechRecognitionEngine { get; private set; } = default;
        public static SpeechSynthesizer SpeechSynthesizer { get; private set; } = default;
        public static bool Initialized { get; private set; } = default;

        public static void Initialize()
        {
            if(Initialized) return;

            SpeechRecognitionEngine = new SpeechRecognitionEngine();
            SpeechSynthesizer = new SpeechSynthesizer();

            Initialized = true;
        }

        private static void SpeechRecognitionEngine_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            switch(e.Result.Text)
            {
                case "red": break;
                case "green": break;
                case "blue": break;
                default: break;
            }
        }
    }
}
