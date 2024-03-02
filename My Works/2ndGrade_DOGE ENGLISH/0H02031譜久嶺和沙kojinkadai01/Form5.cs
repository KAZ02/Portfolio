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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace _0H02031譜久嶺和沙kojinkadai01
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            Size = new Size(1280, 720);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton4.Checked == false && radioButton5.Checked == false && radioButton6.Checked == false  && radioButton7.Checked == false)
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
                    label1.Text = "春\nHaru";
                    SoundPlayer simpleSound = new SoundPlayer("Haru.wav");
                    simpleSound.Play();
                }
                if (radioButton5.Checked)
                {
                    label1.ForeColor = Color.Black;
                    label1.Text = "夏\nNatsu";
                    SoundPlayer simpleSound = new SoundPlayer("Natsu.wav");
                    simpleSound.Play();

                }
                if (radioButton6.Checked)
                {
                    label1.ForeColor = Color.Black;
                    label1.Text = "秋\nAki";
                    SoundPlayer simpleSound = new SoundPlayer("Aki.wav");
                    simpleSound.Play();
                }
                if (radioButton7.Checked)
                {
                    label1.ForeColor = Color.Black;
                    label1.Text = "冬\nFuyu";
                    SoundPlayer simpleSound = new SoundPlayer("Fuyu.wav");
                    simpleSound.Play();
                }
            }
            if (radioButton2.Checked)
            {
                if (radioButton4.Checked)
                {
                    label1.ForeColor = Color.Black;
                    label1.Text = "はる\nHaru";
                    SoundPlayer simpleSound = new SoundPlayer("Haru.wav");
                    simpleSound.Play();
                }
                if (radioButton5.Checked)
                {
                    label1.ForeColor = Color.Black;
                    label1.Text = "なつ\nNatsu";
                    SoundPlayer simpleSound = new SoundPlayer("Natsu.wav");
                    simpleSound.Play();
                }
                if (radioButton6.Checked)
                {
                    label1.ForeColor = Color.Black;
                    label1.Text = "あき\nAki";
                    SoundPlayer simpleSound = new SoundPlayer("Aki.wav");
                    simpleSound.Play();
                }
                if (radioButton7.Checked)
                {
                    label1.ForeColor = Color.Black;
                    label1.Text = "ふゆ\nFuyu";
                    SoundPlayer simpleSound = new SoundPlayer("Fuyu.wav");
                    simpleSound.Play();
                }
            }
            if (radioButton3.Checked)
            {
                if (radioButton4.Checked)
                {
                    label1.ForeColor = Color.Black;
                    label1.Text = "ハル\nHaru";
                    SoundPlayer simpleSound = new SoundPlayer("Haru.wav");
                    simpleSound.Play();
                }
                if (radioButton5.Checked)
                {
                    label1.ForeColor = Color.Black;
                    label1.Text = "ナツ\nNatsu";
                    SoundPlayer simpleSound = new SoundPlayer("Natsu.wav");
                    simpleSound.Play();
                }
                if (radioButton6.Checked)
                {
                    label1.ForeColor = Color.Black;
                    label1.Text = "アキ\nAki";
                    SoundPlayer simpleSound = new SoundPlayer("Aki.wav");
                    simpleSound.Play();
                }
                if (radioButton7.Checked)
                {
                    label1.ForeColor = Color.Black;
                    label1.Text = "フユ\nFuyu";
                    SoundPlayer simpleSound = new SoundPlayer("Fuyu.wav");
                    simpleSound.Play();
                }
            }

        }
    }
}
