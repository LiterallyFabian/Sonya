using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using WMPLib;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterruptedSilence
{
    public partial class Form1 : Form
    {
        private bool _isActive = false;
        private bool _shareDelay = false;
        private const string AudioDirectory = "audio";
        private static readonly Random Random = new Random(); 
        private readonly List<string> _audioFiles = new List<string>();
        
        public Form1()
        {
            InitializeComponent();
        }

        #region Event functions
        
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadAudio();
            minDelayNumber.Value = Properties.Settings.Default.minDelay;
            maxDelayNumber.Value = Properties.Settings.Default.maxDelay;
            shareDelayCheckbox.Checked = Properties.Settings.Default.shareDelay;
            volumeTrackbar.Value = Properties.Settings.Default.volume;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            _isActive = true;
            startButton.Enabled = false;
            stopButton.Enabled = true;
            reloadAudioButton.Enabled = false;
            
            Text = "Interrupted Silence - Active";
            
            StartLoop();
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            _isActive = false;
            startButton.Enabled = true;
            stopButton.Enabled = false;
            reloadAudioButton.Enabled = true;
            
            Text = "Interrupted Silence";
        }

        private void openAudioDirButton_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(AudioDirectory))
                Directory.CreateDirectory(AudioDirectory);

            Process.Start(AudioDirectory);
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
        
        private void exitButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.shareDelay = _shareDelay;
            Properties.Settings.Default.minDelay = minDelayNumber.Value;
            Properties.Settings.Default.maxDelay = maxDelayNumber.Value;
            Properties.Settings.Default.volume = volumeTrackbar.Value;
            Properties.Settings.Default.Save();
            Application.Exit();
        }
        
        #endregion

        private void LoadAudio()
        {
            if (!Directory.Exists(AudioDirectory))
                Directory.CreateDirectory(AudioDirectory);
            
            _audioFiles.Clear();
            audioListBox.Items.Clear();
            
            foreach (var file in Directory.GetFiles(AudioDirectory, "*.mp3"))
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
                
                PlaySound(_audioFiles[Random.Next(0, _audioFiles.Count)]);
            }
            
            while(_isActive && !_shareDelay)
            {
                // ReSharper disable once ForCanBeConvertedToForeach
                for (int i = 0; i < _audioFiles.Count; i++)
                {
                    double delay = RandomDouble((double) minDelayNumber.Value, (double) maxDelayNumber.Value);
                    await Task.Delay((int) (delay * 1000));

                    if (!_isActive || _shareDelay)
                        break;

                    PlaySound(_audioFiles[i]);
                }
            }
        }

        private void PlaySound(string url)
        {
            WindowsMediaPlayer player = new WindowsMediaPlayer();

            player.URL = url;
            player.settings.volume = volumeTrackbar.Value;
            player.controls.play();
        }
        
        public double RandomDouble(double minimum, double maximum)
        { 
            return Random.NextDouble() * (maximum - minimum) + minimum;
        }
    }
}