using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
using Label = System.Windows.Forms.Label;

namespace _0J01027譜久嶺和沙kojinkadai01
{
    

    public partial class Form1 : Form
    {
        //コントロールのタグ
        int tag = 0;
        //タグカウンター
        int daycount = 1;
        //現在の年データ
        int yeardata = 0;
        //現在の月データ
        int monthdata = 0;
        //現在の日データ
        int daydata = 0;
        //月の日数
        int maxdata = 0;


        public Form1()
        {
            InitializeComponent();
        }

        int calyear = 0;
        int calmonth = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            tag = 0;
            daycount = 1;

            TodayIs.Text = "本日は" + dateTimePicker1.Value.ToLongDateString() + "です。\n" + "今月は" + "日過ぎました。\n" + "今年は" + "日過ぎました。";

            //イベント情報
            label9.Text = "日時\n" + "";
            label10.Text = "イベント名\n" + "";
            label11.Text = "優先度\n" + "";

            StreamReader sr = new StreamReader("event.csv", Encoding.GetEncoding("utf-8"));
            String[] items = new string[3];
            String bline = sr.ReadLine();

            while (sr.Peek() != -1)
            {
                items = bline.Split(',');
                if ("" != items[0] && "a" != items[0])
                {

                    label9.Text += items[0] + "\r\n";
                    label10.Text += items[1] + "\r\n";
                    label11.Text += items[2] + "\r\n";
                }
                //次の行
                bline = sr.ReadLine();
            }
            //ファイルを閉じる
            sr.Close();

            //現在の年データを取得
            string year = dateTimePicker1.Value.ToString("yyyy");
            yeardata = int.Parse(year);
            calyear = yeardata;

            //現在の月データを取得
            string month = dateTimePicker1.Value.ToString("MM");
            monthdata = int.Parse(month);
            calmonth = monthdata;
            label1.Text = monthdata.ToString() + "月";

            //現在の日データを取得
            string day = dateTimePicker1.Value.ToString("dd");
            daydata = int.Parse(day);

            //月の日数を取得
            maxdata = DateTime.DaysInMonth(yeardata, monthdata);

            // DateTimePickerから選択された日付を取得
            DateTime selectedDate = dateTimePicker1.Value;

            //曜日取得
            DayOfWeek dayOfWeek = selectedDate.DayOfWeek;
            string dayOfWeekString = dayOfWeek.ToString();
            string days = "";

            //曜日の英語表記を日本語に変換
            string[,] data = new string[7, 2];
            data[0, 0] = "Sunday"; data[0, 1] = "日曜日";
            data[1, 0] = "Monnday"; data[1, 1] = "月曜日";
            data[2, 0] = "Tuesday"; data[2, 1] = "火曜日";
            data[3, 0] = "Wednesday"; data[3, 1] = "水曜日";
            data[4, 0] = "Thursday"; data[4, 1] = "木曜日";
            data[5, 0] = "Friday"; data[5, 1] = "金曜日";
            data[6, 0] = "Saturday"; data[6, 1] = "土曜日";
            int i;
            for (i = 0; i < 7; i++)
            {
                if (dayOfWeek.ToString() == data[i, 0])
                {

                    days = data[i, 1];
                }
            }

            // 今日の日付を取得
            DateTime today = DateTime.Today;
            // 今月の初めの日付を取得
            DateTime firstDayOfMonth = new DateTime(today.Year, today.Month, 1);
            // 月初めの曜日を取得
            DayOfWeek firstDayOfWeek = firstDayOfMonth.DayOfWeek;

            if (firstDayOfWeek == DayOfWeek.Sunday)
            {
                //日曜日なら0
                tag = 0;
            }
            else if (firstDayOfWeek == DayOfWeek.Monday)
            {
                //🈷曜日なら1
                tag = 1;
            }
            else if (firstDayOfWeek == DayOfWeek.Tuesday)
            {
                //火曜日なら2
                tag = 2;
            }
            else if (firstDayOfWeek == DayOfWeek.Wednesday)
            {
                //水曜日なら3
                tag = 3;
            }
            else if (firstDayOfWeek == DayOfWeek.Thursday)
            {
                //木曜日なら4
                tag = 4;
            }
            else if (firstDayOfWeek == DayOfWeek.Friday)
            {
                //金曜日なら5
                tag = 5;
            }
            else if (firstDayOfWeek == DayOfWeek.Saturday)
            {
                //土曜日なら6
                tag = 6;
            }

            while (daycount <= maxdata)
            {
                foreach (Control control in Controls)
                {
                    //日数カウンターが月の最終日と同じになるまでループ
                    if (control.Tag != null && control.Tag.ToString() == tag.ToString())
                    {
                        if (control is Label label)
                        {
                            label.Text = daycount.ToString();

                            if (daydata >= daycount)
                            {
                                label.BackColor = Color.Red;
                            }

                        }

                    }

                }
                tag++;
                daycount++;
            }

            // 選択された日付が閏年かどうかを判定
            bool isLeapYear = DateTime.IsLeapYear(selectedDate.Year);

            //閏年判定(閏年)
            if (isLeapYear)
            {
                //月をケースに分け、DateTimePickerで指定された日がx日目 / 365(平年)かを求める。
                int daysToAdd1 = 0;
                int days1 = selectedDate.Month;

                switch (days1)
                {
                    case 2: daysToAdd1 = 31; break;
                    case 3: daysToAdd1 = 60; break;
                    case 4: daysToAdd1 = 91; break;
                    case 5: daysToAdd1 = 121; break;
                    case 6: daysToAdd1 = 152; break;
                    case 7: daysToAdd1 = 182; break;
                    case 8: daysToAdd1 = 213; break;
                    case 9: daysToAdd1 = 244; break;
                    case 10: daysToAdd1 = 275; break;
                    case 11: daysToAdd1 = 305; break;
                    case 12: daysToAdd1 = 335; break;
                }

                int monthdays1 = 0;
                int month1 = selectedDate.Month;

                switch (month1)
                {
                    case 1: monthdays1 = 31; break;
                    case 2: monthdays1 = 28; break;
                    case 3: monthdays1 = 31; break;
                    case 4: monthdays1 = 30; break;
                    case 5: monthdays1 = 31; break;
                    case 6: monthdays1 = 30; break;
                    case 7: monthdays1 = 31; break;
                    case 8: monthdays1 = 31; break;
                    case 9: monthdays1 = 30; break;
                    case 10: monthdays1 = 31; break;
                    case 11: monthdays1 = 30; break;
                    case 12: monthdays1 = 31; break;
                }

                //Day/Yearのパーセンテージを計算
                int DaysPassed1 = daysToAdd1 + daydata;
                int TodaysPercentage1 = (int)Math.Round((double)DaysPassed1 * 100 / 366);

                //Day/Yearの日数(今年は何日経ったか)を計算
                int RDY1 = 366 - DaysPassed1;

                //Day/Monthの日数(今月は何日経ったか)を計算
                int DM1 = monthdays1 - daydata;

                TodayIs.Text = "今日は" + monthdata + "月" + daydata + "日"+ days +"です。\n" + "今月は残り" + DM1.ToString() + "日です。\n" + "今年は" + DaysPassed1 + "日過ぎました、残り" + RDY1 + "日です。\n";
                PercentageProgressBar1.Value = TodaysPercentage1;
                Thread.Sleep(10);
            }
            else//(平年)
           {
                //月をケースに分け、DateTimePickerで指定された日がx日目/365(平年)かを求める。
                int daysToAdd2 = 0;
                int days2 = selectedDate.Month;

                switch (days2)
                {
                    case 2: daysToAdd2 = 31; break;
                    case 3: daysToAdd2 = 59; break;
                    case 4: daysToAdd2 = 90; break;
                    case 5: daysToAdd2 = 120; break;
                    case 6: daysToAdd2 = 151; break;
                    case 7: daysToAdd2 = 181; break;
                    case 8: daysToAdd2 = 212; break;
                    case 9: daysToAdd2 = 243; break;
                    case 10: daysToAdd2 = 273; break;
                    case 11: daysToAdd2 = 304; break;
                    case 12: daysToAdd2 = 334; break;
                }
                //label2.Text = ("選択された日付は閏年ではありません。");

                int monthdays2 = 0;
                int month2 = selectedDate.Month;

                switch (month2)
                {
                    case 1: monthdays2 = 31; break;
                    case 2: monthdays2 = 29; break;
                    case 3: monthdays2 = 31; break;
                    case 4: monthdays2 = 30; break;
                    case 5: monthdays2 = 31; break;
                    case 6: monthdays2 = 30; break;
                    case 7: monthdays2 = 31; break;
                    case 8: monthdays2 = 31; break;
                    case 9: monthdays2 = 30; break;
                    case 10: monthdays2 = 31; break;
                    case 11: monthdays2 = 30; break;
                    case 12: monthdays2 = 31; break;
                }

                //Day/Yearのパーセンテージを計算
                int DaysPassed2 = daysToAdd2 + daydata;
                int TodaysPercentage2 = (int)Math.Round((double)DaysPassed2 * 100 / 366);

                //Day/Yearの日数(今年は何日経ったか)を計算
                int RDY2 = 365 - DaysPassed2;

                //Day/Monthの日数(今月は何日経ったか)を計算
                int DM2 = monthdays2 - daydata;

                TodayIs.Text = "今日は" + monthdata + "月" + daydata + "日"+ days +"です。\n" + "今月は残り" + DM2.ToString() + "日です。\n" + "今年は" + DaysPassed2 + "日過ぎました、残り" + RDY2 + "日です。\n";
                PercentageProgressBar1.Value = TodaysPercentage2;
                Thread.Sleep(10);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //12月を超えたら、
            DateTime today = DateTime.Today;
            calmonth -= 1;
            daycount = 1;
            if (calmonth == 0)
            {
                calmonth = 12;
                calyear -= 1;
            }
            label1.Text = calmonth + "月";

            // 指定した月初めの日付を取得
            DateTime firstDayOfMonth = new DateTime(calyear, calmonth, 1);
            // 月初めの曜日を取得
            DayOfWeek firstDayOfWeek = firstDayOfMonth.DayOfWeek;

            foreach (Control control in Controls)
            {
                //日数カウンターが月の最終日と同じになるまでループ
                if (control.Tag != null)
                {
                    if (control is Label label)
                    {
                        label.Text = "";
                        label.BackColor = Color.White;

                    }


                }
            }
            // 月の日数を取得
            maxdata = DateTime.DaysInMonth(calyear, calmonth);

            if (firstDayOfWeek == DayOfWeek.Sunday)
            {
                //日曜日なら0
                tag = 0;
            }
            else if (firstDayOfWeek == DayOfWeek.Monday)
            {
                //🈷曜日なら1
                tag = 1;
            }
            else if (firstDayOfWeek == DayOfWeek.Tuesday)
            {
                //火曜日なら2
                tag = 2;
            }
            else if (firstDayOfWeek == DayOfWeek.Wednesday)
            {
                //水曜日なら3
                tag = 3;
            }
            else if (firstDayOfWeek == DayOfWeek.Thursday)
            {
                //木曜日なら4
                tag = 4;
            }
            else if (firstDayOfWeek == DayOfWeek.Friday)
            {
                //金曜日なら5
                tag = 5;
            }
            else if (firstDayOfWeek == DayOfWeek.Saturday)
            {
                //土曜日なら6
                tag = 6;
            }
            while (daycount <= maxdata)
            {
                foreach (Control control in Controls)
                {
                    //日数カウンターが月の最終日と同じになるまでループ
                    if (control.Tag != null && control.Tag.ToString() == tag.ToString())
                    {
                        if (control is Label label)
                        {
                            label.Text = daycount.ToString();

                            if (today.Year == calyear)
                            {
                                if (today.Month <= calmonth)
                                {
                                    if (today.Day >= daycount && today.Month >= calmonth && today.Year >= calyear)
                                    {
                                        label.BackColor = Color.Red;
                                    }
                                }
                                else
                                {
                                    label.BackColor = Color.Red;
                                }
                            }
                            else if (today.Year >= calyear)
                            {
                                label.BackColor = Color.Red;
                            }

                        }
                        

                    }

                }
                tag++;
                daycount++;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //12月を超えたら、
            DateTime today = DateTime.Today; 
            calmonth += 1;
            daycount = 1;
            if (calmonth == 13)
            {
                calmonth = 1;
                calyear += 1;
            }
            label1.Text = calmonth + "月";

            // 指定した月初めの日付を取得
            DateTime firstDayOfMonth = new DateTime(calyear,calmonth, 1);
            // 月初めの曜日を取得
            DayOfWeek firstDayOfWeek = firstDayOfMonth.DayOfWeek;

            foreach (Control control in Controls)
            {
                //日数カウンターが月の最終日と同じになるまでループ
                if (control.Tag != null)
                {
                    if (control is Label label)
                    {
                        label.Text = "";
                        label.BackColor = Color.White;

                    }
                }
            }
            // 月の日数を取得
            maxdata = DateTime.DaysInMonth(calyear, calmonth);

            if (firstDayOfWeek == DayOfWeek.Sunday)
            {
                //日曜日なら0
                tag = 0;
            }
            else if (firstDayOfWeek == DayOfWeek.Monday)
            {
                //🈷曜日なら1
                tag = 1;
            }
            else if (firstDayOfWeek == DayOfWeek.Tuesday)
            {
                //火曜日なら2
                tag = 2;
            }
            else if (firstDayOfWeek == DayOfWeek.Wednesday)
            {
                //水曜日なら3
                tag = 3;
            }
            else if (firstDayOfWeek == DayOfWeek.Thursday)
            {
                //木曜日なら4
                tag = 4;
            }
            else if (firstDayOfWeek == DayOfWeek.Friday)
            {
                //金曜日なら5
                tag = 5;
            }
            else if (firstDayOfWeek == DayOfWeek.Saturday)
            {
                //土曜日なら6
                tag = 6;
            }
            while (daycount <= maxdata)
            {
                foreach (Control control in Controls)
                {
                    //日数カウンターが月の最終日と同じになるまでループ
                    if (control.Tag != null && control.Tag.ToString() == tag.ToString())
                    {
                        if (control is Label label)
                        {
                            label.Text = daycount.ToString();

                            if (today.Year == calyear)
                            {
                                if(today.Month <= calmonth)
                                {
                                    if (today.Day >= daycount && today.Month >= calmonth && today.Year >= calyear)
                                    {
                                        label.BackColor = Color.Red;
                                    }

                                }
                                else
                                {
                                    label.BackColor = Color.Red;
                                }
                            }
                            else if(today.Year >= calyear)
                            {
                                label.BackColor = Color.Red;
                            }

                        }
                        

                    }

                }
                tag++;
                daycount++;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label9.Text = "日時\n" + "";
            label10.Text = "イベント名\n" + "";
            label11.Text = "優先度\n" + "";

            StreamReader sr = new StreamReader("event.csv",Encoding.GetEncoding("utf-8"));
            String[] items = new string[3];
            String bline = sr.ReadLine();

            while(sr.Peek() != -1)
            {
                items = bline.Split(',');
                if ("" != items[0] && "a" != items[0])
                {
                    
                    label9.Text += items[0] + "\r\n";
                    label10.Text +=items[1] + "\r\n";
                    label11.Text +=items[2] +"\r\n";
                }
                //次の行
                bline = sr.ReadLine();
            }
            //ファイルを閉じる
            sr.Close();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}