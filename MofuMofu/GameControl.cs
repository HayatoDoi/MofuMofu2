using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MofuMofu
{
    public partial class GameControl : UserControl
    {
        bool gamestart_flag = false;
        //キーダウンカウンタ
        int keydown_count = 0;
        //タイマカウンタ
        double timer_counter = 0;
        public GameControl()
        {
            InitializeComponent();
        }

        private void GameControl_Load(object sender, EventArgs e)
        {
            //もふもふの非表示
            mofumofu_ctl(false);
            mofumofu_ctl(true);

        }
        public void GameControl_Start()
        {
            //ゲーム起動フラグを立てる
            gamestart_flag = true;
            //キーダウン回数の初期化
            keydown_count = 0;
            //キーダウン回数の表示
            this.keycountLabel.Text = keydown_count.ToString("d") + "回";
            //タイマカウンタの初期化
            timer_counter = 5;
            //タイマの起動
            countTimeTimer.Start();

        }
        public void GameControl_KeyDown(object sender, KeyEventArgs e)
        {
            if (gamestart_flag == true)
            {
                //もふもふの表示
                mofumofu_ctl(true);
            }
        }
        public void GameControl_KeyUp(object sender, KeyEventArgs e)
        {
            if (gamestart_flag == true)
            {
                //もふもふの非表示
                mofumofu_ctl(false);
                //キーボード回数のカウント
                keydown_count++;
                //キーダウン回数の表示
                this.keycountLabel.Text = keydown_count.ToString("d") + "回";
            }
        }

        private void GameControl_MouseDown(object sender, MouseEventArgs e)
        {
            //もふもふの表示
            mofumofu_ctl(true);

        }

        private void GameControl_MouseUp(object sender, MouseEventArgs e)
        {
            //もふもふの非表示
            mofumofu_ctl(false);

        }

        private void countTimeTimer_Tick(object sender, EventArgs e)
        {
            timer_counter -= 0.01;
            this.countTimeLabal.Text = "残り " + timer_counter.ToString("f2");
            if(timer_counter.ToString("f2") == "0.00")
            {
                //時間切れの処理
                countTimeTimer.Stop();
                //ゲーム起動フラグを下す
                gamestart_flag = false;
                //もふもふの非表示
                mofumofu_ctl(false);
                //スコア送信画面の表示(内側にフォームを作成)
                SendScoreForm sendScoreForm = new SendScoreForm();
                sendScoreForm.TopLevel = false;
                this.Controls.Add(sendScoreForm);
                sendScoreForm.ControlBox = false;
                sendScoreForm.Text = "";
                sendScoreForm.Show();
                sendScoreForm.BringToFront();
            }
        }

        private void mofumofu_ctl(bool onoff)
        {
            if (onoff == true)
            {
                //もふもふの表示
                mofumofu1Pic.Visible = true;
                mofumofu2Pic.Visible = true;
                mofumofu3Pic.Visible = true;
            }
            if(onoff == false)
            {
                //もふもふの非表示
                mofumofu1Pic.Visible = false;
                mofumofu2Pic.Visible = false;
                mofumofu3Pic.Visible = false;
            }
        }
    }
}
