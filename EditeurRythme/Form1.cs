using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace EditeurRythme
{
    public partial class Form1 : Form
    {
        static string currentFile;
        static string currentFileDirectory;


        public Form1()
        {
            InitializeComponent();
        }

        private void btnFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            currentFile = System.IO.Path.GetFileNameWithoutExtension(openFileDialog1.FileName);
            tbDirectory.Text = openFileDialog1.FileName;
            currentFileDirectory = openFileDialog1.FileName;
            lblTitle.Text = currentFile;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (currentFile == null)
            {
                MessageBox.Show("An audio file must be selected.");
            }
            else if (nudBPM.Value==0)
            {
                MessageBox.Show("Must type a BPM. Try songbpm.com .");
            }
            else
            {
                Form2 frm2 = new Form2();
                frm2.currentFile = currentFile;
                frm2.currentFileDirectory = currentFileDirectory;
                frm2.bpm = (int)nudBPM.Value;
                frm2.intervalsByBPM = (int)nudIntervals.Value;
                frm2.Show(); 
            }
        }
    }
}
