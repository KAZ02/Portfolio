using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0H02031譜久嶺和沙kojinkadai01
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            Size = new Size(1280, 720);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (radioButton4.Checked == false && radioButton5.Checked == false && radioButton6.Checked == false && radioButton7.Checked == false && radioButton8.Checked == false && radioButton9.Checked == false && radioButton10.Checked == false && radioButton11.Checked == false && radioButton12.Checked == false && radioButton13.Checked == false)
            {
                SoundPlayer simpleSound = new SoundPlayer("Pcaw.wav");
                simpleSound.Play();
                MessageBox.Show("Please chose a word!");
            }

            if (radioButton1.Checked)
            {
                if (radioButton4.Checked)
                {
                    label1.ForeColor = Color.Black;
                    label1.Text = "一\nIchi";
                    SoundPlayer simpleSound = new SoundPlayer("Ichi.wav");
                    simpleSound.Play();
                }
                if (radioButton5.Checked)
                {
                    label1.ForeColor = Color.Black;
                    label1.Text = "二\nNi";
                    SoundPlayer simpleSound = new SoundPlayer("Ni.wav");
                    simpleSound.Play();
                }
                if (radioButton6.Checked)
                {
                    label1.ForeColor = Color.Black;
                    label1.Text = "三\nSan";
                    SoundPlayer simpleSound = new SoundPlayer("San.wav");
                    simpleSound.Play();
                }
                if (radioButton7.Checked)
                {
                    label1.ForeColor = Color.Black;
                    label1.Text = "四\nYon";
                    SoundPlayer simpleSound = new SoundPlayer("Yon.wav");
                    simpleSound.Play();
                }
                if (radioButton8.Checked)
                {
                    label1.ForeColor = Color.Black;
                    label1.Text = "五\nGo";
                    SoundPlayer simpleSound = new SoundPlayer("Go.wav");
                    simpleSound.Play();
                }
                if (radioButton9.Checked)
                {
                    label1.ForeColor = Color.Black;
                    label1.Text = "六\nRoku";
                    SoundPlayer simpleSound = new SoundPlayer("Roku.wav");
                    simpleSound.Play();
                }
                if (radioButton10.Checked)
                {
                    label1.ForeColor = Color.Black;
                    label1.Text = "七\nNana";
                    SoundPlayer simpleSound = new SoundPlayer("Nana.wav");
                    simpleSound.Play();
                }
                if (radioButton11.Checked)
                {
                    label1.ForeColor = Color.Black;
                    label1.Text = "八\nHachi";
                    SoundPlayer simpleSound = new SoundPlayer("Hachi.wav");
                    simpleSound.Play();
                }
                if (radioButton12.Checked)
                {
                    label1.ForeColor = Color.Black;
                    label1.Text = "九\nKyū";
                    SoundPlayer simpleSound = new SoundPlayer("Kyu.wav");
                    simpleSound.Play();
                }
                if (radioButton13.Checked)
                {
                    label1.ForeColor = Color.Black;
                    label1.Text = "十\nJū";
                    SoundPlayer simpleSound = new SoundPlayer("Zyu.wav");
                    simpleSound.Play();
                }
            }
            if (radioButton2.Checked)
            {
                if (radioButton4.Checked)
                {
                    label1.ForeColor = Color.Black;
                    label1.Text = "いち\nIchi";
                    SoundPlayer simpleSound = new SoundPlayer("Ichi.wav");
                    simpleSound.Play();

                }
                if (radioButton5.Checked)
                {
                    label1.ForeColor = Color.Black;
                    label1.Text = "に\nNi";
                    SoundPlayer simpleSound = new SoundPlayer("Ni.wav");
                    simpleSound.Play();
                }
                if (radioButton6.Checked)
                {
                    label1.ForeColor = Color.Black;
                    label1.Text = "さん\nSan";
                    SoundPlayer simpleSound = new SoundPlayer("San.wav");
                    simpleSound.Play();
                }
                if (radioButton7.Checked)
                {
                    label1.ForeColor = Color.Black;
                    label1.Text = "よん\nYon";
                    SoundPlayer simpleSound = new SoundPlayer("Yon.wav");
                    simpleSound.Play();
                }
                if (radioButton8.Checked)
                {
                    label1.ForeColor = Color.Black;
                    label1.Text = "ご\nGo";
                    SoundPlayer simpleSound = new SoundPlayer("Go.wav");
                    simpleSound.Play();
                }
                if (radioButton9.Checked)
                {
                    label1.ForeColor = Color.Black;
                    label1.Text = "ろく\nRoku";
                    SoundPlayer simpleSound = new SoundPlayer("Roku.wav");
                    simpleSound.Play();
                }
                if (radioButton10.Checked)
                {
                    label1.ForeColor = Color.Black;
                    label1.Text = "なな\nNana";
                    SoundPlayer simpleSound = new SoundPlayer("Nana.wav");
                    simpleSound.Play();
                }
                if (radioButton11.Checked)
                {
                    label1.ForeColor = Color.Black;
                    label1.Text = "はち\nHachi";
                    SoundPlayer simpleSound = new SoundPlayer("Hachi.wav");
                    simpleSound.Play();
                }
                if (radioButton12.Checked)
                {
                    label1.ForeColor = Color.Black;
                    label1.Text = "きゅう\nKyū";
                    SoundPlayer simpleSound = new SoundPlayer("Kyu.wav");
                    simpleSound.Play();
                }
                if (radioButton13.Checked)
                {
                    label1.ForeColor = Color.Black;
                    label1.Text = "じゅう\nJū";
                    SoundPlayer simpleSound = new SoundPlayer("Zyu.wav");
                    simpleSound.Play();
                }
            }
            if (radioButton3.Checked)
            {
                if (radioButton4.Checked)
                {
                    label1.ForeColor = Color.Black;
                    label1.Text = "イチ\nIchi";
                    SoundPlayer simpleSound = new SoundPlayer("Ichi.wav");
                    simpleSound.Play();
                }
                if (radioButton5.Checked)
                {
                    label1.ForeColor = Color.Black;
                    label1.Text = "ニ\nNi";
                    SoundPlayer simpleSound = new SoundPlayer("Ni.wav");
                    simpleSound.Play();
                }
                if (radioButton6.Checked)
                {
                    label1.ForeColor = Color.Black;
                    label1.Text = "サン\nSan";
                    SoundPlayer simpleSound = new SoundPlayer("San.wav");
                    simpleSound.Play();
                }
                if (radioButton7.Checked)
                {
                    label1.ForeColor = Color.Black;
                    label1.Text = "ヨン\nYon";
                    SoundPlayer simpleSound = new SoundPlayer("Yon.wav");
                    simpleSound.Play();
                }
                if (radioButton8.Checked)
                {
                    label1.ForeColor = Color.Black;
                    label1.Text = "ゴ\nGo";
                    SoundPlayer simpleSound = new SoundPlayer("Go.wav");
                    simpleSound.Play();
                }
                if (radioButton9.Checked)
                {
                    label1.ForeColor = Color.Black;
                    label1.Text = "ロク\nRoku";
                    SoundPlayer simpleSound = new SoundPlayer("Roku.wav");
                    simpleSound.Play();
                }
                if (radioButton10.Checked)
                {
                    label1.ForeColor = Color.Black;
                    label1.Text = "ナナ\nNana";
                    SoundPlayer simpleSound = new SoundPlayer("Nana.wav");
                    simpleSound.Play();
                }
                if (radioButton11.Checked)
                {
                    label1.ForeColor = Color.Black;
                    label1.Text = "ハチ\nHachi";
                    SoundPlayer simpleSound = new SoundPlayer("Hachi.wav");
                    simpleSound.Play();
                }
                if (radioButton12.Checked)
                {
                    label1.ForeColor = Color.Black;
                    label1.Text = "キュウ\nKyū";
                    SoundPlayer simpleSound = new SoundPlayer("Kyu.wav");
                    simpleSound.Play();
                }
                if (radioButton13.Checked)
                {
                    label1.ForeColor = Color.Black;
                    label1.Text = "ジュウ\nJū";
                    SoundPlayer simpleSound = new SoundPlayer("Zyu.wav");
                    simpleSound.Play();
                }
            }

        }
    }
}
