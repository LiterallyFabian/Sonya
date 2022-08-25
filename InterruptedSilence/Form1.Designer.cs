namespace InterruptedSilence
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.minDelayLabel = new System.Windows.Forms.Label();
            this.maxDelayLabel = new System.Windows.Forms.Label();
            this.minDelayNumber = new System.Windows.Forms.NumericUpDown();
            this.maxDelayNumber = new System.Windows.Forms.NumericUpDown();
            this.openAudioDirButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.reloadAudioButton = new System.Windows.Forms.Button();
            this.shareDelayCheckbox = new System.Windows.Forms.CheckBox();
            this.audioListBox = new System.Windows.Forms.ListBox();
            this.exitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize) (this.minDelayNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.maxDelayNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // minDelayLabel
            // 
            this.minDelayLabel.Location = new System.Drawing.Point(12, 9);
            this.minDelayLabel.Name = "minDelayLabel";
            this.minDelayLabel.Size = new System.Drawing.Size(100, 23);
            this.minDelayLabel.TabIndex = 0;
            this.minDelayLabel.Text = "Min delay (sec)";
            // 
            // maxDelayLabel
            // 
            this.maxDelayLabel.Location = new System.Drawing.Point(12, 38);
            this.maxDelayLabel.Name = "maxDelayLabel";
            this.maxDelayLabel.Size = new System.Drawing.Size(100, 23);
            this.maxDelayLabel.TabIndex = 2;
            this.maxDelayLabel.Text = "Max delay (sec)";
            // 
            // minDelayNumber
            // 
            this.minDelayNumber.DecimalPlaces = 2;
            this.minDelayNumber.Location = new System.Drawing.Point(118, 7);
            this.minDelayNumber.Maximum = new decimal(new int[] {1000000, 0, 0, 0});
            this.minDelayNumber.Name = "minDelayNumber";
            this.minDelayNumber.Size = new System.Drawing.Size(120, 20);
            this.minDelayNumber.TabIndex = 3;
            this.minDelayNumber.Value = new decimal(new int[] {2, 0, 0, 0});
            // 
            // maxDelayNumber
            // 
            this.maxDelayNumber.DecimalPlaces = 2;
            this.maxDelayNumber.Location = new System.Drawing.Point(118, 36);
            this.maxDelayNumber.Maximum = new decimal(new int[] {1000000, 0, 0, 0});
            this.maxDelayNumber.Name = "maxDelayNumber";
            this.maxDelayNumber.Size = new System.Drawing.Size(120, 20);
            this.maxDelayNumber.TabIndex = 4;
            this.maxDelayNumber.Value = new decimal(new int[] {360, 0, 0, 0});
            // 
            // openAudioDirButton
            // 
            this.openAudioDirButton.Location = new System.Drawing.Point(12, 116);
            this.openAudioDirButton.Name = "openAudioDirButton";
            this.openAudioDirButton.Size = new System.Drawing.Size(123, 23);
            this.openAudioDirButton.TabIndex = 5;
            this.openAudioDirButton.Text = "Open audio directory";
            this.openAudioDirButton.UseVisualStyleBackColor = true;
            this.openAudioDirButton.Click += new System.EventHandler(this.openAudioDirButton_Click);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(12, 64);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 6;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Enabled = false;
            this.stopButton.Location = new System.Drawing.Point(93, 64);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(75, 23);
            this.stopButton.TabIndex = 7;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // reloadAudioButton
            // 
            this.reloadAudioButton.Location = new System.Drawing.Point(141, 116);
            this.reloadAudioButton.Name = "reloadAudioButton";
            this.reloadAudioButton.Size = new System.Drawing.Size(85, 23);
            this.reloadAudioButton.TabIndex = 8;
            this.reloadAudioButton.Text = "Reload audio";
            this.reloadAudioButton.UseVisualStyleBackColor = true;
            this.reloadAudioButton.Click += new System.EventHandler(this.reloadAudioButton_Click);
            // 
            // shareDelayCheckbox
            // 
            this.shareDelayCheckbox.Location = new System.Drawing.Point(174, 64);
            this.shareDelayCheckbox.Name = "shareDelayCheckbox";
            this.shareDelayCheckbox.Size = new System.Drawing.Size(104, 24);
            this.shareDelayCheckbox.TabIndex = 9;
            this.shareDelayCheckbox.Text = "Share delay";
            this.shareDelayCheckbox.UseVisualStyleBackColor = true;
            this.shareDelayCheckbox.CheckedChanged += new System.EventHandler(this.shareDelayCheckbox_CheckedChanged);
            // 
            // audioListBox
            // 
            this.audioListBox.FormattingEnabled = true;
            this.audioListBox.Location = new System.Drawing.Point(284, 9);
            this.audioListBox.Name = "audioListBox";
            this.audioListBox.Size = new System.Drawing.Size(149, 147);
            this.audioListBox.TabIndex = 10;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(232, 116);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(46, 23);
            this.exitButton.TabIndex = 11;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(445, 164);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.audioListBox);
            this.Controls.Add(this.shareDelayCheckbox);
            this.Controls.Add(this.reloadAudioButton);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.openAudioDirButton);
            this.Controls.Add(this.maxDelayNumber);
            this.Controls.Add(this.minDelayNumber);
            this.Controls.Add(this.maxDelayLabel);
            this.Controls.Add(this.minDelayLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Interrupted Silence";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize) (this.minDelayNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.maxDelayNumber)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button exitButton;

        private System.Windows.Forms.ListBox audioListBox;

        private System.Windows.Forms.CheckBox shareDelayCheckbox;

        private System.Windows.Forms.Button openAudioDirButton;

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button stopButton;

        private System.Windows.Forms.Button reloadAudioButton;

        private System.Windows.Forms.NumericUpDown minDelayNumber;
        private System.Windows.Forms.NumericUpDown maxDelayNumber;

        private System.Windows.Forms.Label minDelayLabel;
        private System.Windows.Forms.Label maxDelayLabel;

        #endregion
    }
}