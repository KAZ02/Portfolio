﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0H02031譜久嶺和沙ckadai01
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int month;

            if (int.TryParse(textBox1.Text, out month))
            {
                switch (month)
                {
                    case 3:
                    case 4:
                    case 5:
                        SoundPlayer simpleSound1 = new SoundPlayer("SSpring.wav");
                        simpleSound1.Play();
                        label2.Text = "季節は春です";
                        pictureBox1.Image = Image.FromFile("haru.jpg");
                        pointer.Left = pictureBox2.Left;
                        panel2.BackColor = Color.FromArgb(222, 148, 156);
                        label2.BackColor = Color.FromArgb(133, 197, 66);
                        break;

                    case 6:
                    case 7:
                    case 8:
                        SoundPlayer simpleSound2 = new SoundPlayer("SSummer.wav");
                        simpleSound2.Play();
                        label2.Text = "季節は夏です";
                        pictureBox1.Image = Image.FromFile("natsu.jpg");
                        pointer.Left = pictureBox2.Width + 18;
                        panel2.BackColor = Color.FromArgb(2, 157, 231);
                        label2.BackColor = Color.FromArgb(182, 215, 203);
                        break;

                    case 9:
                    case 10:
                    case 11:
                        SoundPlayer simpleSound3 = new SoundPlayer("SAutumn.wav");
                        simpleSound3.Play();
                        label2.Text = "季節は秋です";
                        pictureBox1.Image = Image.FromFile("aki.jpg");
                        pointer.Left = pictureBox2.Width + pictureBox3.Width + 38;
                        panel2.BackColor = Color.FromArgb(218, 52, 31);
                        label2.BackColor = Color.FromArgb(223, 156, 44);
                        break;

                    case 12:
                    case 1:
                    case 2:
                        SoundPlayer simpleSound4 = new SoundPlayer("SWinter.wav");
                        simpleSound4.Play();
                        label2.Text = "季節は冬です";
                        pictureBox1.Image = Image.FromFile("fuyu.jpg");
                        pointer.Left = pictureBox2.Width + pictureBox3.Width + pictureBox4.Width + 56;
                        panel2.BackColor = Color.FromArgb(84, 108, 203);
                        label2.BackColor = Color.FromArgb(191, 114, 205);
                        break;

                    default:
                        SoundPlayer simpleSound5 = new SoundPlayer("EW1.wav");
                        simpleSound5.Play();
                        MessageBox.Show("Please enter a number less than or equal to 12");
                        break;
                }
            }
            else
            {
                SoundPlayer simpleSound5 = new SoundPlayer("EW2.wav");
                simpleSound5.Play();
                MessageBox.Show("Please enter an integer value.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
        }
    }
}
