using System;
using System.Speech.Synthesis;
using System.Windows.Forms;

namespace SpeechFun
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonSpeak_Click(object sender, EventArgs e)
        {
            SpeechSynthesizer synthVoice = new SpeechSynthesizer();
            synthVoice.Speak(textBoxPhrase.Text);            
        }
    }
}
