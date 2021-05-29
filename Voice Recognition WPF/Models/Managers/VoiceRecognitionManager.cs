using System;
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

            SpeechRecognitionEngine.SetInputToDefaultAudioDevice();
            SpeechRecognitionEngine.LoadGrammar(new DictationGrammar());

            SpeechRecognitionEngine.SpeechDetected += OnSpeechDetected;
            SpeechRecognitionEngine.SpeechRecognized += OnSpeechRecognized;
            SpeechRecognitionEngine.SpeechHypothesized += OnSpeechHypothesized;
            SpeechRecognitionEngine.SpeechRecognitionRejected += OnSpeechRecognitionRejected;
        }

        private static void OnSpeechDetected(object sender, SpeechDetectedEventArgs e)
        {
            SpeechSynthesizer.Speak("Speech detected");
        }
        private static void OnSpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            SpeechSynthesizer.Speak("Speech recognized");
        }
        private static void OnSpeechHypothesized(object sender, SpeechHypothesizedEventArgs e)
        {
            SpeechSynthesizer.Speak("Speech hypothesized");
        }

        private static void OnSpeechRecognitionRejected(object sender, SpeechRecognitionRejectedEventArgs e)
        {
        }
    }
}
