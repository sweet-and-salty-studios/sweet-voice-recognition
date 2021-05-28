using System.Windows;
using System.Speech.Recognition;
using Voice_Recognition_WPF.Scripts.Managers;
using System;
using System.Speech.Synthesis;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Voice_Recognition_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            VoiceRecognitionManager.Initialize();
            VoiceRecognitionManager.SpeechSynthesizer.Speak("Sweet & Salty Studios");

        }

        private void CustomToggleButton_Checked(object sender, RoutedEventArgs e)
        {
            VoiceRecognitionManager.SpeechRecognitionEngine.RecognizeAsync(RecognizeMode.Multiple);
        }

        private void CustomToggleButton_Unchecked(object sender, RoutedEventArgs e)
        {
            VoiceRecognitionManager.SpeechRecognitionEngine.RecognizeAsyncStop();
        }
    }
}
