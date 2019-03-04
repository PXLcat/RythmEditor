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
using System.Timers;
using System.IO;
using Newtonsoft.Json;

namespace EditeurRythme
{
    public partial class Form2 : Form
    {
        public string currentFile;
        public string currentFileDirectory;
        public int bpm;
        public int intervalsByBPM;
        private SoundPlayer currentSong = null;
        private int secondsElapsed;
        private int elapsedBPM;
        

        private string musicLine = ""; //utiliser StringBuilder?
        private string rythmLine = "";
        private int currentEdit = 1; //0= nothing, 1=music, 2= rythm

        //List<int> musicTempoList = new List<int>();
        //List<int> rythmTempoList = new List<int>();


        StringBuilder sbMusic = new StringBuilder();
        StringBuilder sbRythm = new StringBuilder();
        //TODO faire deux sb différents



        public Form2()
        {
            InitializeComponent();
            KeyPreview = true;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            lblTitle.Text = currentFile;
            currentSong = new SoundPlayer(currentFileDirectory);
            currentSong.Load();
            lblDisplayBPM.Text = bpm.ToString();


            //disable editing elements
            rtbMusicLine.Enabled = true;
            rtbRythmLine.Enabled = false;
            lblSpace.Visible = false;

            // double secFromBpm = 60000(nombre de milisecondes dans une minute) / ex:112 (les bpm de la musique choisie);
            double secFromBpm = 60000 / (double)bpm;
            //timerBPM.Interval(le nombre de millisecondes entre chaque incrémentation du timer) = secFromBpm / intervalsByBPM(le nombre d'intervalles dans un temps)
            timerBPM.Interval = secFromBpm / intervalsByBPM; //TODO vérifs
            //  /1 = demi-seconde, /2= quart-seconde, /4= huitième-seconde




        }


        private void btnPlay_Click(object sender, EventArgs e)
        {
            currentSong.Play();
            timerSeconds.Enabled = true;
            timerBPM.Enabled = true;
            lblSpace.Visible = true;
            btnPlay.Enabled = false; //c'est ici que ça passe l 117, pourquoi?
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            currentSong.Stop();
            timerSeconds.Enabled = false;
            secondsElapsed = 0;
            timerSeconds.Stop();
            timerBPM.Enabled = false;
            timerBPM.Stop();
            elapsedBPM = 0;
            lblSpace.Visible = false;

            lblTimeSeconds.Text = timeDisplay();
            lblElapsedBPM.Text = elapsedBPM.ToString();

            btnPlay.Enabled = true;
        }

        private void timerSeconds_Tick(object sender, EventArgs e)
        {
            secondsElapsed++;
            lblTimeSeconds.Text = timeDisplay();
        }

        private string timeDisplay()
        {
            int seconds, minutes;
            minutes = secondsElapsed / 60;
            seconds = secondsElapsed % 60;

            return string.Format("{0:00}:{1:00}", minutes, seconds);

        }

        private void rbMusicLine_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMusicLine.Checked)
            {
                rtbMusicLine.Enabled = true;
                rtbRythmLine.Enabled = false;
                //rbRythmLine.Checked = true;
                currentEdit = 1;
            }

        }

        private void rbRythmLine_CheckedChanged(object sender, EventArgs e)
        {
            if (rbRythmLine.Checked)
            {
                rtbMusicLine.Enabled = false;
                rtbRythmLine.Enabled = true;
                //rbMusicLine.Checked = false; //appel l106
                currentEdit = 2;
            }

        }


        private void timerBPM_Elapsed(object sender, EventArgs e)
        {
            elapsedBPM++;
            lblElapsedBPM.Text = elapsedBPM.ToString();
        }

        //TODO bouton Clean

        private void EditRtb(RichTextBox rtb)
        { //possible de factoriser?
            if (rtb == rtbMusicLine)
            {
                sbMusic.Append(elapsedBPM.ToString());
                sbMusic.Append("\n");
                rtb.Text = sbMusic.ToString(); //TODO besoin de séparer entre rtbMusic et rtbRythm ?

                //musicTempoList.Add(elapsedBPM); //TODO attention, l'édit de la rtb ne changera pas ce qui sera envoyé dans le json. Il faut que ce qui est dans la rtb soit sauvé à l'enregistrement et pas le tempo direct

            }

            else if (rtb == rtbRythmLine)
            {
                sbRythm.Append(elapsedBPM.ToString());
                sbRythm.Append("\n");
                rtb.Text = sbRythm.ToString(); //TODO besoin de séparer entre rtbMusic et rtbRythm ?

                //rythmTempoList.Add(elapsedBPM);
            }

            rtb.Invalidate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EditRtb(rtbMusicLine);
        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                switch (currentEdit)
                {
                    case 0:

                        break;
                    case 1:
                        EditRtb(rtbMusicLine);
                        break;
                    case 2:
                        EditRtb(rtbRythmLine);
                        break;
                    default:
                        break;
                }
            }
        }

        private void btnClearMusic_Click(object sender, EventArgs e)
        {
            sbMusic.Clear();
            rtbMusicLine.Clear();
        }

        private void btnClearRythm_Click(object sender, EventArgs e)
        {
            sbRythm.Clear();
            rtbRythmLine.Clear();
        }

        private void btnExportMusic_Click(object sender, EventArgs e)
        {
            //TODO nom de la chanson comme proposition de base
            //TODO taille de la fenêtre

            saveFileDialog1.AddExtension = true;
            saveFileDialog1.Filter = "Fichiers JSON (*.json)|*.json";
            saveFileDialog1.ShowDialog();


            //MessageBox.Show(saveFileDialog1.FileName);  //filename = chemin+ nom fichier

            //File.Create(saveFileDialog1.FileName);

            ////File.AppendAllText(saveFileDialog1.FileName, rtbMusicLine.Text,); //TODO factoriser pour MusicLine
            ////File.AppendAllLines(saveFileDialog1.FileName,rtbMusicLine.Text);
            //File.WriteAllText(saveFileDialog1.FileName, rtbMusicLine.Text);
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            SongDTO file = new SongDTO();
            file.Name = currentFile;
            file.BPM = bpm;
            file.IntervalsByBPM = intervalsByBPM;


            List<int> musicBeatsList = new List<int>();
            List<int> rythmBeatsList = new List<int>();

            foreach (string line in rtbMusicLine.Lines)
            {
                if (!String.IsNullOrWhiteSpace(line))
                {
                    bool success = Int32.TryParse(line, out int beat);
                    if (success)
                    {
                        musicBeatsList.Add(beat);
                    }
                    else
                    {
                        MessageBox.Show("One of the lines cannot be converted to a number");
                    }
                }
            }
            foreach (string line in rtbRythmLine.Lines)
            {
                if (!String.IsNullOrWhiteSpace(line))
                {
                    bool success = Int32.TryParse(line, out int beat);
                    if (success)
                    {
                        rythmBeatsList.Add(beat);
                    }
                    else
                    {
                        MessageBox.Show("One of the lines cannot be converted to a number");
                    }
                }
            }

            file.MusicLine = musicBeatsList.ToArray<int>();
            file.RythmLine = rythmBeatsList.ToArray<int>();

            File.WriteAllText(saveFileDialog1.FileName, JsonConvert.SerializeObject(file, Formatting.Indented));
        }
    }
}
