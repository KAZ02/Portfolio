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
using System.Net.NetworkInformation;
using System.Reflection.Emit;

namespace KanijiQuiz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //プレイ画面の非表示
            label1.Visible = false;
            label2.Visible = false;
            label4.Visible = false;
            //label3.Visible = false;
            label5.Visible = false;
            textBox1.Visible = false;
            button1.Visible = false;
            button3.Visible = false;
            button4.Visible = false;    //ゲーム説明
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;

            Color transparentColor = Color.FromArgb(128, 116, 0, 156); // 128は透明度を示します（0が完全透明、255が不透明）
            label3.Font = new Font("游明朝", 20);
            label3.Text = "漢字クイズ\r\n「御座候」";
            label3.BackColor = transparentColor;
        }

        //画面遷移メソッド
        public void change()
        {
            //プレイ画面の表示
            label1.Visible = true;
            label2.Visible = true;
            label4.Visible = true;
            textBox1.Visible = true;
            button1.Visible = true;
            button3.Visible = true;
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;

            //トップページの非表示
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            button2.Visible = false;

            //問題の非表示
            label1.Text = "";

        }

        //string lv = "";
        string course = "";
        public void page()
        {
            this.BackgroundImage = System.Drawing.Image.FromFile("playpage.png");
            Color transparentColor = Color.FromArgb(128, 116, 0, 156); // 128は透明度を示します（0が完全透明、255が不透明）
            label3.Text = "テキストボックスにカーソルを入れ\r\n「全角スペースキー」で開始してください。";
            label3.BackColor = transparentColor;
        }
        //レベルとコースの選択メソッド
        public void select()
        {
            //レベルとコースの選択
            //レベルとコースの選択

            //Lv.HARD
            if (radioButton1.Checked)
            {
                if (radioButton4.Checked)
                {
                    //lv = "HARD";
                    course = "A";    //空・天気編
                    this.Text = "空・天気編";
                    t = 100;
                    change();
                    page();
                }
                else if (radioButton5.Checked)
                {
                    //lv = "HARD";
                    course = "B";   //植物編
                    this.Text = "植物編";
                    t = 100;
                    change();
                    page();
                }
                else if (radioButton6.Checked)
                {
                    //lv = "HARD";
                    course = "C";   //模様・色編
                    this.Text = "模様・色編";
                    t = 100;
                    change();
                    page();
                }
                else
                {
                    MessageBox.Show("コースを選択して下さい。");
                }
            }
            //Lv.VERY HARD
            else if (radioButton2.Checked)
            {
                if (radioButton4.Checked)
                {
                    //lv = "VERYHARD";
                    course = "A";    //空・天気編
                    this.Text = "空・天気編";
                    t = 90;
                    change();
                    page();
                }
                else if (radioButton5.Checked)
                {
                    //lv = "VERYHARD";
                    course = "B";   //植物編this.Text = "植物編";
                    t = 90;
                    change();
                    page();
                }
                else if (radioButton6.Checked)
                {
                    //lv = "VERYHARD";
                    course = "C";   //模様・色編
                    this.Text = "模様・色編";
                    t = 90;
                    change();
                    page();
                }
                else
                {
                    MessageBox.Show("コースを選択して下さい。");
                }
            }
            //Lv.NIGHTMARE
            else if (radioButton3.Checked)
            {
                if (radioButton4.Checked)
                {
                    //lv = "NIGHTMARE";
                    course = "A";    //空・天気編
                    this.Text = "空・天気編";
                    t = 60;
                    change();
                    page();
                }
                else if (radioButton5.Checked)
                {
                    //lv = "NIGHTMARE";
                    course = "B";   //植物編
                    this.Text = "植物編";
                    t = 60;
                    change();
                    page();
                }
                else if (radioButton6.Checked)
                {
                    //lv = "NIGHTMARE";
                    course = "C";   //模様・色編
                    this.Text = "模様・色編";
                    t = 60;
                    change();
                    page();
                }
                else
                {
                    //コース選択を促すメッセージボックスの表示
                    MessageBox.Show("コースを選択して下さい。");
                }
            }
            else
            {
                //レベル選択を促すメッセージボックスの表示
                MessageBox.Show("レベルを選択して下さい。");
            }
        }





        private void button3_Click(object sender, EventArgs e)
        {
            Color transparentColor = Color.FromArgb(128, 116, 0, 156); // 128は透明度を示します（0が完全透明、255が不透明）
            label3.Font = new Font("游明朝", 20);
            label3.Text = "漢字クイズ\r\n「御座候」";
            label3.BackColor = transparentColor;

            //トップページ表示
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            textBox1.Visible = true;
            this.BackgroundImage = System.Drawing.Image.FromFile("toppage.png");

            //プレイ画面の非表示
            label1.Visible = false;
            label2.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            textBox1.Visible = false;
            button1.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;

            groupBox1.Visible = true;
            groupBox2.Visible = true;
            button2.Visible = true;
        }

        //問題番号の定義
        int qnum = 0;
        List<string> kanji = new List<string>();    //CSVから読み込んだ漢字を格納
        List<string> yomi = new List<string>();     //CSVから読み込んだ読みを格納
        //List<string> imi = new List<string>();     //CSVから読み込んだ読みを格納
        //
        int count = 0;



        //読み番地
        int data = 0;

        //ライフ
        int life = 3;

        //ポイント
        int p = 0;

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {

                case Keys.Enter:
                    textBox1.Text = textBox1.Text.Replace("　", "");

                    if (yomi.Count > 0 && qnum >= 0 && qnum < yomi.Count)
                    {
                        if (yomi[qnum] == textBox1.Text.Replace(" ", ""))
                        {
                            //一度出題された漢字を出力させない処理
                            kanji.RemoveAt(qnum);
                            yomi.RemoveAt(qnum);

                            //意味の表示
                            //imi.RemoveAt(qnum);

                            //ランダム
                            count -= 1;
                            Random rd1 = new Random();
                            qnum = rd1.Next(count);
                            label1.Text = kanji[qnum];
                            //label5.Text = imi[qnum];

                            //テキストボックスの初期化
                            textBox1.Text = "";

                            //ラベルの初期化
                            label3.Text = "";
                            data = 0;
                            //ゲーム開始後「ヒント」
                            label3.Text = "Spaceキーでヒントの表示\r\n";

                            //ポイントの加算
                            p += 3;
                            label2.Text = p.ToString() + "P";
                        }
                        else
                        {
                            if (p > 0)
                            {
                                //ポイントの減算
                                p--;
                                label2.Text = p.ToString() + "P";
                            }
                            else
                            {
                                //ライフの減少
                                life -= 1;

                                switch (life)
                                {
                                    case 2:
                                        pictureBox1.Visible = false;
                                        break;

                                    case 1:
                                        pictureBox2.Visible = false;
                                        break;

                                    case 0:
                                        pictureBox3.Visible = false;
                                        timer1.Enabled = false;
                                        label4.Text = t.ToString() + "秒";
                                        MessageBox.Show("ゲームオーバー");

                                        //プレイ画面への遷移
                                        select();
                                        timer1.Enabled = false;
                                        life = 3;
                                        p = 0;
                                        label2.Text = p.ToString() + "P";
                                        label4.Text = t.ToString() + "秒";
                                        textBox1.Text = "";
                                        this.BackgroundImage = System.Drawing.Image.FromFile("playpage.png");
                                        label3.Text = "テキストボックスにカーソルを入れ\r\n「全角スペースキー」で再プレイできます。";
                                        label1.Font = new Font(label1.Font.FontFamily, 15);
                                        label1.Text = "答えは「" + yomi[qnum].ToString() + "」です。";
                                        break;
                                }
                            }

                        }
                    }
                    break;
            }
            if (yomi.Count > 0 && qnum >= 0 && qnum < yomi.Count)
            {
                //「Shiftキー」でヒントの表示
                if (e.Shift)
                {
                    string hint1 = yomi[qnum].ToString();
                    string hint = hint1.Substring(data, 1);

                    if (data < hint1.Length - 1)
                    {

                        label3.Text = (data + 1).ToString() + "文字目の読みは「" + hint + "」です。";

                        /*data++;
                        t -= 5;
                        label4.Text = t.ToString();*/

                        if (t - 5 >= 0)
                        {
                            t -= 5;
                        }
                        else
                        {
                            t = 0;
                        }

                        label4.Text = t.ToString() + "秒";
                        data++;
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            p = 0;

            //プレイ画面への遷移
            label3.Font = new Font(label1.Font.FontFamily, 15);
            select();
            timer1.Enabled = false;
            label2.Text = p.ToString() + "P";
            label4.Text = t.ToString() + "秒";
            textBox1.Text = "";
        }
        //タイム
        int t = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            t--;

            if (t < 0)
            {
                t = 0;
            }
            label4.Text = t.ToString() + "秒";

            if (t <= 0)
            {
                timer1.Enabled = false;
                MessageBox.Show("タイムアウト");

                //プレイ画面への遷移
                select();
                timer1.Enabled = false;
                life = 3;
                p = 0;
                t = 0;
                label2.Text = p.ToString() + "P";
                label4.Text = t.ToString() + "秒";
                textBox1.Text = "";
                this.BackgroundImage = System.Drawing.Image.FromFile("playpage.png");
                label3.Text = "テキストボックスにカーソルを入れ\r\n「全角スペースキー」で再プレイできます。";
                label1.Font = new Font(label1.Font.FontFamily, 15);
                label1.Text = "答えは「" + yomi[qnum].ToString() + "」です。";
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

                if (e.KeyChar == '　')
                {
                    //プレイ画面への遷移
                    select();
                    timer1.Enabled = true;
                    textBox1.Focus();
                    label2.Text = p.ToString() + "P";
                    label4.Text = t.ToString() + "秒";
                    this.BackgroundImage = System.Drawing.Image.FromFile("playpage.png");
                    label3.Text = "テキストボックスにカーソルを入れ\r\n「全角スペースキー」で開始してください。";

                    //ヒント表示の初期化
                    data = 0;
                    label3.Text = "Spaceキーでヒントの表示";

                    //ライフとポイントの初期化
                    life = 3;
                    p = 0;

                    //フォントサイズの再設定
                    label1.Font = new Font(label1.Font.FontFamily, 35);

                    //CSVファイルの読み込み
                    StreamReader sr = new StreamReader("KanjiQuiz.csv", Encoding.GetEncoding("UTF-8"));
                    //ランダム
                    Random rd = new Random();
                    //
                    string[] items = new string[1000];
                    string bline = sr.ReadLine();

                    kanji.Clear();
                    yomi.Clear();

                    while (sr.Peek() != -1) //一行ずつ読み込み、ファイルの終端に達するまでループを実行する
                    {
                        items = bline.Split(',');   //','で要素を区切る


                        if (course == items[4])
                        {
                            kanji.Add(items[0]);
                            yomi.Add(items[1]);
                            //imi.Add(items[2]);
                            count += 1;
                        }

                        bline = sr.ReadLine();
                    }
                    sr.Close();

                    qnum = rd.Next(count);
                    label1.Text = kanji[qnum];
                    e.Handled = true;
                }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //プレイ画面への遷移
            select();
            change();
            this.Text = "ルール";
            timer1.Enabled = false;
            label2.Text = p.ToString() + "P";
            label4.Text = t.ToString() + "秒";
            this.BackgroundImage = System.Drawing.Image.FromFile("playpage.png");
            label3.Text = "テキストボックスにカーソルを入れ\r\n「全角スペースキー」で開始してください。";

            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = true;

            button2.Visible = false;
            button3.Visible = false;

            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;

            textBox1.Visible = false;

            button4.Visible = true;

            Color transparentColor = Color.FromArgb(128, 116, 0, 156); // 128は透明度を示します（0が完全透明、255が不透明）
            label5.ForeColor = Color.White;
            label5.BackColor = transparentColor;
            label5.Text = "[操作方法]\r\n1.テキストボックスにカーソルを入れて、「全角スペース」でゲームスタート(またはやりなおし)\r\n2.キーボード上で入力\r\n3.「Enterキー」で送信\r\n4.「Shiftキー」でヒントの表示\r\n\r\n[ルール]\r\n1.レベルにあわせて制限時間が設定されています。\r\n2.ヒントを一文字見るごとに、5秒のロスタイムが発生します。\r\n3.問題に正解するとポイントが3ポイント加点され、間違えると1ポイント減点されます。\r\n4.ポイントが0のまま、問題に間違えるとライフが1つずつ減り、3つ減るとゲーム終了となります。";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //page();

            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = false;

            button3.Visible = true;

            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;

            textBox1.Visible = true;
            button4.Visible = false;
        }
    }
}