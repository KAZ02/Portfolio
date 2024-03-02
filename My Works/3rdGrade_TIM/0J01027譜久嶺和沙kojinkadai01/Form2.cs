using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _0J01027譜久嶺和沙kojinkadai01
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string selectdate = dateTimePicker1.Value.ToString("yyyy-MM-dd");

 
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 5) // 最大5文字まで許可
            {
                textBox1.Text = textBox1.Text.Substring(0, 5);
                textBox1.SelectionStart = textBox1.Text.Length;
            }
            else
            {
                MessageBox.Show("5文字以下で入力して下さい。");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DateTime selectedDate = dateTimePicker1.Value;
            string selectdate = selectedDate.Year + "年" + selectedDate.Month + "月" + selectedDate.Day + "日";

           


                // TextBoxからテキストを取得
                string textBoxText = textBox1.Text;

            // 選択したRadioButtonから値を取得
            string radioButtonValue = "";
            if (radioButton1.Checked)
            {
                radioButtonValue = "★";
            }
            if (radioButton2.Checked)
            {
                radioButtonValue = "★★";
            }
            if (radioButton3.Checked)
            {
                radioButtonValue = "★★★";
            }
            if (radioButton4.Checked)
            {
                radioButtonValue = "★★★★";
            }
            // 他のRadioButtonの場合も同様に追加できます


            using (StreamWriter sw = new StreamWriter("event.csv", true, Encoding.GetEncoding("utf-8")))
            {
                sw.WriteLine(selectdate + "," + textBoxText + "," + radioButtonValue);
                sw.WriteLine("a");
            }
            // 取得した値を表示
            MessageBox.Show("日時: " + selectdate +
                            "\nイベント名: " + textBoxText.ToString() +
                            "\n優先度:" + radioButtonValue);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
