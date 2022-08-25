using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using WMPLib;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterruptedSilence
{
    public partial class Form1 : Form
    {
        private bool _isActive = false;
        private bool _shareDelay = false;
        private const string _audioDirectory = "audio";
        private static Random _random = new Random(); 
        private List<string> _audioFiles = new List<string>();
        
        public Form1()
        {
            InitializeComponent();
        }

        #region Event functions
        
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadAudio();  
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            _isActive = true;
            startButton.Enabled = false;
            stopButton.Enabled = true;
            
            Text = "Interrupted Silence - Active";
            
            StartLoop();
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

        private void reloadAudioButton_Click(object sender, EventArgs e)
        {
            LoadAudio();   
        }
        
        private void shareDelayCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            _shareDelay = shareDelayCheckbox.Checked;
            
            if(_isActive)
                StartLoop();
        }
        #endregion

        private void LoadAudio()
        {
            if (!Directory.Exists(_audioDirectory))
                Directory.CreateDirectory(_audioDirectory);
            
            _audioFiles.Clear();
            audioListBox.Items.Clear();
            
            foreach (var file in Directory.GetFiles(_audioDirectory, "*.mp3"))
            {
                _audioFiles.Add(file);
                audioListBox.Items.Add(Path.GetFileName(file));
            }
        }

        /// <summary>
        /// Starts or restarts the loop.
        /// </summary>
        private async void StartLoop()
        {
            while (_isActive && _shareDelay)
            {
                double delay = RandomDouble((double) minDelayNumber.Value, (double) maxDelayNumber.Value);
                await Task.Delay((int)(delay*1000));
                
                if (!_isActive || !_shareDelay)
                    break;
                
                PlaySound(_audioFiles[_random.Next(0, _audioFiles.Count)]);
            }
            
            while(_isActive && !_shareDelay)
            {
                foreach (string file in _audioFiles)
                {
                    double delay = RandomDouble((double) minDelayNumber.Value, (double) maxDelayNumber.Value);
                    await Task.Delay((int)(delay*1000));
                    
                    if (!_isActive || _shareDelay)
                        break;
                
                    PlaySound(file);
                }
            }
        }

        private static void PlaySound(string url)
        {
            WindowsMediaPlayer player = new WindowsMediaPlayer();

            player.URL = url;
            player.controls.play();
        }
        
        public double RandomDouble(double minimum, double maximum)
        { 
            return _random.NextDouble() * (maximum - minimum) + minimum;
        }
    }
}