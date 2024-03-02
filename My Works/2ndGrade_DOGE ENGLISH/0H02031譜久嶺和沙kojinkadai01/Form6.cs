using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0H02031譜久嶺和沙kojinkadai01
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            Size = new Size(1280, 720);
        }

        private void button1_Click(object sender, EventArgs e)
        {


            if (radioButton4.Checked == false && radioButton5.Checked == false && radioButton6.Checked == false && radioButton7.Checked == false)
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
                    label1.Text = "東\nHigashi";
                    SoundPlayer simpleSound = new SoundPlayer("Higashi.wav");
                    simpleSound.Play();
                }
                if (radioButton5.Checked)
                {
                    label1.ForeColor = Color.Black;
                    label1.Text = "西\nNishi";
                    SoundPlayer simpleSound = new SoundPlayer("Nishi.wav");
                    simpleSound.Play();
                }
                if (radioButton6.Checked)
                {
                    label1.ForeColor = Color.Black;
                    label1.Text = "南\nMinami";
                    SoundPlayer simpleSound = new SoundPlayer("Minami.wav");
                    simpleSound.Play();
                }
                if (radioButton7.Checked)
                {
                    label1.ForeColor = Color.Black;
                    label1.Text = "北\nKita";
                    SoundPlayer simpleSound = new SoundPlayer("Kita.wav");
                    simpleSound.Play();
                }
            }
            if (radioButton2.Checked)
            {
                if (radioButton4.Checked)
                {
                    label1.ForeColor = Color.Black;
                    label1.Text = "ひがし\nHigashi";
                    SoundPlayer simpleSound = new SoundPlayer("Higashi.wav");
                    simpleSound.Play();
                }
                if (radioButton5.Checked)
                {
                    label1.ForeColor = Color.Black;
                    label1.Text = "にし\nNishi";
                    SoundPlayer simpleSound = new SoundPlayer("Nishi.wav");
                    simpleSound.Play();
                }
                if (radioButton6.Checked)
                {
                    label1.ForeColor = Color.Black;
                    label1.Text = "みなみ\nMinami";
                    SoundPlayer simpleSound = new SoundPlayer("Minami.wav");
                    simpleSound.Play();
                }
                if (radioButton7.Checked)
                {
                    label1.ForeColor = Color.Black;
                    label1.Text = "きた\nKita";
                    SoundPlayer simpleSound = new SoundPlayer("Kita.wav");
                    simpleSound.Play();
                }
            }
            if (radioButton3.Checked)
            {
                if (radioButton4.Checked)
                {
                    label1.ForeColor = Color.Black;
                    label1.Text = "ヒガシ\nHigashi";
                    SoundPlayer simpleSound = new SoundPlayer("Higashi.wav");
                    simpleSound.Play();
                }
                if (radioButton5.Checked)
                {
                    label1.ForeColor = Color.Black;
                    label1.Text = "ニシ\nNishi";
                    SoundPlayer simpleSound = new SoundPlayer("Nishi.wav");
                    simpleSound.Play();
                }
                if (radioButton6.Checked)
                {
                    label1.ForeColor = Color.Black;
                    label1.Text = "ミナミ\nMinami";
                    SoundPlayer simpleSound = new SoundPlayer("Minami.wav");
                    simpleSound.Play();
                }
                if (radioButton7.Checked)
                {
                    label1.ForeColor = Color.Black;
                    label1.Text = "キタ\nKita";
                    SoundPlayer simpleSound = new SoundPlayer("Kita.wav");
                    simpleSound.Play();
                }
            }
        }
    }
}
