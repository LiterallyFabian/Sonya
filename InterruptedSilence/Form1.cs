using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace InterruptedSilence
{
    public partial class Form1 : Form
    {
        private bool _isActive = false;
        private const string _audioDirectory = "audio";
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            _isActive = true;
            startButton.Enabled = false;
            stopButton.Enabled = true;
            
            Text = "Interrupted Silence - Active";
            
            // TODO: Start the timer
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            _isActive = false;
            startButton.Enabled = true;
            stopButton.Enabled = false;
            
            Text = "Interrupted Silence";
        }

        private void openAudioDirButton_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(_audioDirectory))
                Directory.CreateDirectory(_audioDirectory);

            Process.Start(_audioDirectory);
        }
    }
}