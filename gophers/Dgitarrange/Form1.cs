using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dgitarrange
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //inGophers躲進去的時間 outGophers出來時間 scoreGophers地鼠的分數
        int go_out, inGophers, outGophers,scoreGophers;
        //time 時間 end 結束時間
        int time = 0, end = 60000;
        int score = 0;
        Random rd = new Random();
        //生成類別變數
        Button btn1;
        Button[,] btndigit = new Button[3, 3];
        RadioButton rdbtn1;
        Panel PnlPlatter = new Panel();
        private void Form1_Load(object sender, EventArgs e)
        {
            //自行宣告按鈕，非自己拉的
            this.WindowState = FormWindowState.Maximized;//螢幕表單最大化
            this.Controls.Add(PnlPlatter);//加入到form表單
            PnlPlatter.Top = 15;
            PnlPlatter.Left = 15;
            PnlPlatter.Width = 630;
            PnlPlatter.Height = 630;
            PnlPlatter.BackColor = Color.Aqua;
            PnlPlatter.Enabled = false;

            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                {
                    btndigit[i, j] = new Button();
                    //加入panel裡面
                    PnlPlatter.Controls.Add(btndigit[i, j]);
                    //取名字
                    btndigit[i, j].Name = "btn" + i.ToString() + j.ToString();
                    btndigit[i, j].Text = "";
                    btndigit[i, j].Width = 200;
                    btndigit[i, j].Height = 200;
                    btndigit[i, j].Font = new Font("Times New Roman", 24, FontStyle.Bold);
                    btndigit[i, j].Top = 15 + i * 200;
                    btndigit[i, j].Left = 15 + j * 200;
                    btndigit[i, j].BackColor = Color.White;
                    //當很多物件做相同的事情，使用訂閱，減化程式碼
                    btndigit[i, j].Click += new EventHandler(Btn00_Click);
                }
            hard.CheckedChanged += new EventHandler(easy_CheckedChanged);
            evil.CheckedChanged += new EventHandler(easy_CheckedChanged);
        }
        //因是自行產生，需自行寫入，通常是複製別人的header
        private void Btn00_Click(object sender, EventArgs e)
        {
            btn1 = (Button)sender;
            if (btn1.BackgroundImage != null)
            {
                btn1.BackgroundImageLayout = ImageLayout.Stretch;
                btn1.BackgroundImage = new Bitmap("out.png");
                score += scoreGophers;
                lblscore.Text = "分數:" + score.ToString();
            }
        }

        private void rebtn_Click(object sender, EventArgs e)
        {
            PnlPlatter.Enabled = false;
            tmrout.Enabled = false;
            btnstart.Enabled = true;
            groupBox1.Enabled = true;
            score = 0;
            end = 60000;
            time = 0;
            lblscore.Text = "分數:0";
            lbltime.Text = "時間:60";
            lbltime.ForeColor = Color.Black;
            for (int i = 0; i < 9; i++)
                PnlPlatter.Controls[i].BackgroundImage = null;
        }

        private void btnstart_Click(object sender, EventArgs e)
        {
            PnlPlatter.Enabled = true;
            tmrout.Enabled = true;
            btnstart.Enabled = false;
            groupBox1.Enabled = false;
        }

        private void easy_CheckedChanged(object sender, EventArgs e)
        {
            //使用類別變數，指定目前的類別變數是哪個物件(指定的物件有可能不同)
            rdbtn1 = (RadioButton)sender;
            if (rdbtn1.Text == "簡單")
            {
                inGophers = 2000;
                outGophers = 1000;
                scoreGophers = 100;
            }
            else if (rdbtn1.Text == "困難")
            {
                inGophers = 1000;
                outGophers = 500;
                scoreGophers = 100;
            }
            else 
            {
                inGophers = 400;
                outGophers = 200;
                scoreGophers = 500;
            }
        }

        private void tmrout_Tick(object sender, EventArgs e)
        {
            lbltime.Text = "時間:" + ((end -= tmrout.Interval) / 1000).ToString();
            time += tmrout.Interval;
            if (end / 1000 == 15)
                lbltime.ForeColor = Color.Red;
            if (end / 1000 == 0)
            {
                tmrout.Enabled = false;
                btnstart.Enabled = true;
                MessageBox.Show("遊戲結束 分數:" + score.ToString(), "打地鼠");
                end = 60000;
                score = 0;
                time = 0;
                lblscore.Text = "分數:0";
                lbltime.Text = "時間:60";
                lbltime.ForeColor = Color.Black;
                for (int i = 0; i < 9; i++)
                    PnlPlatter.Controls[i].BackgroundImage = null;
            }
            if (time == inGophers)
            {
                time = 0;
                PnlPlatter.Controls[go_out].BackgroundImage = null;
            }
            else if (time == outGophers && PnlPlatter.Controls[go_out].BackgroundImage == null)
            {
                go_out = rd.Next(9);
                PnlPlatter.Controls[go_out].BackgroundImageLayout = ImageLayout.Stretch;
                PnlPlatter.Controls[go_out].BackgroundImage = new Bitmap("in.gif");
            }
        }
    }
}
