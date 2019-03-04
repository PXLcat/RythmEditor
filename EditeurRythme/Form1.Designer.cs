namespace EditeurRythme
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnFile = new System.Windows.Forms.Button();
            this.tbDirectory = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nudBPM = new System.Windows.Forms.NumericUpDown();
            this.lblTitle = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.InBBPM = new System.Windows.Forms.Label();
            this.nudIntervals = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudBPM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIntervals)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "WAV files|*.wav";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // btnFile
            // 
            this.btnFile.Location = new System.Drawing.Point(12, 21);
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(61, 23);
            this.btnFile.TabIndex = 0;
            this.btnFile.Text = "File :";
            this.btnFile.UseVisualStyleBackColor = true;
            this.btnFile.Click += new System.EventHandler(this.btnFile_Click);
            // 
            // tbDirectory
            // 
            this.tbDirectory.Location = new System.Drawing.Point(79, 23);
            this.tbDirectory.Name = "tbDirectory";
            this.tbDirectory.Size = new System.Drawing.Size(416, 20);
            this.tbDirectory.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(522, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "BPM :";
            // 
            // nudBPM
            // 
            this.nudBPM.Location = new System.Drawing.Point(564, 24);
            this.nudBPM.Maximum = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.nudBPM.Name = "nudBPM";
            this.nudBPM.Size = new System.Drawing.Size(76, 20);
            this.nudBPM.TabIndex = 3;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(12, 72);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(628, 23);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "No music selected";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(211, 118);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(230, 53);
            this.button1.TabIndex = 5;
            this.button1.Text = "START";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // InBBPM
            // 
            this.InBBPM.AutoSize = true;
            this.InBBPM.Location = new System.Drawing.Point(459, 59);
            this.InBBPM.Name = "InBBPM";
            this.InBBPM.Size = new System.Drawing.Size(91, 13);
            this.InBBPM.TabIndex = 6;
            this.InBBPM.Text = "Intervals by beat :";
            // 
            // nudIntervals
            // 
            this.nudIntervals.Location = new System.Drawing.Point(564, 52);
            this.nudIntervals.Maximum = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.nudIntervals.Name = "nudIntervals";
            this.nudIntervals.Size = new System.Drawing.Size(76, 20);
            this.nudIntervals.TabIndex = 7;
            this.nudIntervals.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 217);
            this.Controls.Add(this.nudIntervals);
            this.Controls.Add(this.InBBPM);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.nudBPM);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbDirectory);
            this.Controls.Add(this.btnFile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Rythm Editor";
            ((System.ComponentModel.ISupportInitialize)(this.nudBPM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIntervals)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnFile;
        private System.Windows.Forms.TextBox tbDirectory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudBPM;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label InBBPM;
        private System.Windows.Forms.NumericUpDown nudIntervals;
    }
}

