using System.Windows;
using System.Speech.Recognition;
using Voice_Recognition_WPF.Scripts.Managers;
using System;

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
            VoiceRecognitionManager.SpeechSynthesizer.SpeakAsync("Sweet & Salty Studios");

            SpeakButton.Click += SpeakButton_Click;

            DataContext = this;
        }

        private void SpeakButton_Click(object sender, RoutedEventArgs e)
        {
            VoiceRecognitionManager.SpeechSynthesizer.SpeakAsync(TextBox.Text);
        }
        
        private void CustomToggleButton_Checked(object sender, RoutedEventArgs e)
        {
            VoiceRecognitionManager.SpeechRecognitionEngine.RecognizeAsync(RecognizeMode.Multiple);
            VoiceRecognitionManager.SpeechSynthesizer.SpeakAsync("Toggle checked");
        }

        private void CustomToggleButton_Unchecked(object sender, RoutedEventArgs e)
        {
            VoiceRecognitionManager.SpeechRecognitionEngine.RecognizeAsyncStop();
            VoiceRecognitionManager.SpeechSynthesizer.SpeakAsync("Toggle unchecked");
        }
    }
}
