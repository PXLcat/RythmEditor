namespace EditeurRythme
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.lblTitle = new System.Windows.Forms.Label();
            this.timerSeconds = new System.Windows.Forms.Timer(this.components);
            this.btnPlay = new System.Windows.Forms.Button();
            this.rbMusicLine = new System.Windows.Forms.RadioButton();
            this.rbRythmLine = new System.Windows.Forms.RadioButton();
            this.gbRythmLine = new System.Windows.Forms.GroupBox();
            this.btnClearRythm = new System.Windows.Forms.Button();
            this.rtbRythmLine = new System.Windows.Forms.RichTextBox();
            this.gbMusicLine = new System.Windows.Forms.GroupBox();
            this.btnClearMusic = new System.Windows.Forms.Button();
            this.rtbMusicLine = new System.Windows.Forms.RichTextBox();
            this.btnExportMusic = new System.Windows.Forms.Button();
            this.lblTimeSeconds = new System.Windows.Forms.Label();
            this.lblSpace = new System.Windows.Forms.Label();
            this.lblBPM = new System.Windows.Forms.Label();
            this.lblDisplayBPM = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblElapsedBPM = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            this.timerBPM = new System.Timers.Timer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.gbRythmLine.SuspendLayout();
            this.gbMusicLine.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timerBPM)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(77, 21);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(628, 23);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "No music selected";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerSeconds
            // 
            this.timerSeconds.Interval = 1000;
            this.timerSeconds.Tick += new System.EventHandler(this.timerSeconds_Tick);
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(12, 66);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(75, 23);
            this.btnPlay.TabIndex = 7;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // rbMusicLine
            // 
            this.rbMusicLine.AutoSize = true;
            this.rbMusicLine.Checked = true;
            this.rbMusicLine.Location = new System.Drawing.Point(3, 5);
            this.rbMusicLine.Name = "rbMusicLine";
            this.rbMusicLine.Size = new System.Drawing.Size(92, 17);
            this.rbMusicLine.TabIndex = 8;
            this.rbMusicLine.TabStop = true;
            this.rbMusicLine.Text = "Edit music line";
            this.rbMusicLine.UseVisualStyleBackColor = true;
            this.rbMusicLine.CheckedChanged += new System.EventHandler(this.rbMusicLine_CheckedChanged);
            // 
            // rbRythmLine
            // 
            this.rbRythmLine.AutoSize = true;
            this.rbRythmLine.Location = new System.Drawing.Point(137, 5);
            this.rbRythmLine.Name = "rbRythmLine";
            this.rbRythmLine.Size = new System.Drawing.Size(90, 17);
            this.rbRythmLine.TabIndex = 9;
            this.rbRythmLine.Text = "Edit rythm line";
            this.rbRythmLine.UseVisualStyleBackColor = true;
            this.rbRythmLine.CheckedChanged += new System.EventHandler(this.rbRythmLine_CheckedChanged);
            // 
            // gbRythmLine
            // 
            this.gbRythmLine.Controls.Add(this.btnClearRythm);
            this.gbRythmLine.Controls.Add(this.rtbRythmLine);
            this.gbRythmLine.Location = new System.Drawing.Point(399, 163);
            this.gbRythmLine.Name = "gbRythmLine";
            this.gbRythmLine.Size = new System.Drawing.Size(373, 381);
            this.gbRythmLine.TabIndex = 10;
            this.gbRythmLine.TabStop = false;
            // 
            // btnClearRythm
            // 
            this.btnClearRythm.Location = new System.Drawing.Point(261, 333);
            this.btnClearRythm.Name = "btnClearRythm";
            this.btnClearRythm.Size = new System.Drawing.Size(75, 23);
            this.btnClearRythm.TabIndex = 12;
            this.btnClearRythm.Text = "Clear";
            this.btnClearRythm.UseVisualStyleBackColor = true;
            this.btnClearRythm.Click += new System.EventHandler(this.btnClearRythm_Click);
            // 
            // rtbRythmLine
            // 
            this.rtbRythmLine.Location = new System.Drawing.Point(18, 33);
            this.rtbRythmLine.Name = "rtbRythmLine";
            this.rtbRythmLine.Size = new System.Drawing.Size(336, 294);
            this.rtbRythmLine.TabIndex = 11;
            this.rtbRythmLine.Text = "";
            // 
            // gbMusicLine
            // 
            this.gbMusicLine.Controls.Add(this.btnClearMusic);
            this.gbMusicLine.Controls.Add(this.rtbMusicLine);
            this.gbMusicLine.Location = new System.Drawing.Point(12, 163);
            this.gbMusicLine.Name = "gbMusicLine";
            this.gbMusicLine.Size = new System.Drawing.Size(365, 381);
            this.gbMusicLine.TabIndex = 0;
            this.gbMusicLine.TabStop = false;
            // 
            // btnClearMusic
            // 
            this.btnClearMusic.Location = new System.Drawing.Point(260, 333);
            this.btnClearMusic.Name = "btnClearMusic";
            this.btnClearMusic.Size = new System.Drawing.Size(75, 23);
            this.btnClearMusic.TabIndex = 11;
            this.btnClearMusic.Text = "Clear";
            this.btnClearMusic.UseVisualStyleBackColor = true;
            this.btnClearMusic.Click += new System.EventHandler(this.btnClearMusic_Click);
            // 
            // rtbMusicLine
            // 
            this.rtbMusicLine.Location = new System.Drawing.Point(17, 33);
            this.rtbMusicLine.Name = "rtbMusicLine";
            this.rtbMusicLine.Size = new System.Drawing.Size(332, 294);
            this.rtbMusicLine.TabIndex = 10;
            this.rtbMusicLine.Text = "";
            // 
            // btnExportMusic
            // 
            this.btnExportMusic.Location = new System.Drawing.Point(352, 531);
            this.btnExportMusic.Margin = new System.Windows.Forms.Padding(2);
            this.btnExportMusic.Name = "btnExportMusic";
            this.btnExportMusic.Size = new System.Drawing.Size(73, 23);
            this.btnExportMusic.TabIndex = 14;
            this.btnExportMusic.Text = "Export";
            this.btnExportMusic.UseVisualStyleBackColor = true;
            this.btnExportMusic.Click += new System.EventHandler(this.btnExportMusic_Click);
            // 
            // lblTimeSeconds
            // 
            this.lblTimeSeconds.AutoSize = true;
            this.lblTimeSeconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeSeconds.Location = new System.Drawing.Point(656, 66);
            this.lblTimeSeconds.Name = "lblTimeSeconds";
            this.lblTimeSeconds.Size = new System.Drawing.Size(49, 20);
            this.lblTimeSeconds.TabIndex = 11;
            this.lblTimeSeconds.Text = "00:00";
            // 
            // lblSpace
            // 
            this.lblSpace.AutoSize = true;
            this.lblSpace.Location = new System.Drawing.Point(327, 113);
            this.lblSpace.Name = "lblSpace";
            this.lblSpace.Size = new System.Drawing.Size(131, 13);
            this.lblSpace.TabIndex = 12;
            this.lblSpace.Text = "Press space for each beat";
            // 
            // lblBPM
            // 
            this.lblBPM.AutoSize = true;
            this.lblBPM.Location = new System.Drawing.Point(617, 113);
            this.lblBPM.Name = "lblBPM";
            this.lblBPM.Size = new System.Drawing.Size(36, 13);
            this.lblBPM.TabIndex = 13;
            this.lblBPM.Text = "BPM :";
            // 
            // lblDisplayBPM
            // 
            this.lblDisplayBPM.AutoSize = true;
            this.lblDisplayBPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayBPM.Location = new System.Drawing.Point(678, 106);
            this.lblDisplayBPM.Name = "lblDisplayBPM";
            this.lblDisplayBPM.Size = new System.Drawing.Size(27, 20);
            this.lblDisplayBPM.TabIndex = 14;
            this.lblDisplayBPM.Text = "60";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(534, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "elasped BPM fractions :";
            // 
            // lblElapsedBPM
            // 
            this.lblElapsedBPM.AutoSize = true;
            this.lblElapsedBPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblElapsedBPM.Location = new System.Drawing.Point(687, 142);
            this.lblElapsedBPM.Name = "lblElapsedBPM";
            this.lblElapsedBPM.Size = new System.Drawing.Size(18, 20);
            this.lblElapsedBPM.TabIndex = 16;
            this.lblElapsedBPM.Text = "0";
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(93, 66);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 17;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // timerBPM
            // 
            this.timerBPM.SynchronizingObject = this;
            this.timerBPM.Elapsed += new System.Timers.ElapsedEventHandler(this.timerBPM_Elapsed);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.rbMusicLine);
            this.panel1.Controls.Add(this.rbRythmLine);
            this.panel1.Location = new System.Drawing.Point(272, 162);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 28);
            this.panel1.TabIndex = 11;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 575);
            this.Controls.Add(this.btnExportMusic);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.lblElapsedBPM);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDisplayBPM);
            this.Controls.Add(this.lblBPM);
            this.Controls.Add(this.lblSpace);
            this.Controls.Add(this.lblTimeSeconds);
            this.Controls.Add(this.gbMusicLine);
            this.Controls.Add(this.gbRythmLine);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.lblTitle);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.Text = "Editor";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form2_KeyDown);
            this.gbRythmLine.ResumeLayout(false);
            this.gbMusicLine.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.timerBPM)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Timer timerSeconds;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.RadioButton rbMusicLine;
        private System.Windows.Forms.RadioButton rbRythmLine;
        private System.Windows.Forms.GroupBox gbRythmLine;
        private System.Windows.Forms.GroupBox gbMusicLine;
        private System.Windows.Forms.Label lblTimeSeconds;
        private System.Windows.Forms.RichTextBox rtbRythmLine;
        private System.Windows.Forms.RichTextBox rtbMusicLine;
        private System.Windows.Forms.Label lblSpace;
        private System.Windows.Forms.Label lblBPM;
        private System.Windows.Forms.Label lblDisplayBPM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblElapsedBPM;
        private System.Windows.Forms.Button btnStop;
        private System.Timers.Timer timerBPM;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClearRythm;
        private System.Windows.Forms.Button btnClearMusic;
        private System.Windows.Forms.Button btnExportMusic;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}