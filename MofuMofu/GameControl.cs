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
        private bool gamestart_flag = false;
        //キーダウンカウンタ(ここにはxorしたデータが入る)
        //int keydown_count_xor = 0;
        public KeyDownCount keyDownCount;

        //タイマカウンタ
        private double timer_counter = 0;
        public GameControl()
        {
            InitializeComponent();
        }

        private void GameControl_Load(object sender, EventArgs e)
        {
            this.keyDownCount = new KeyDownCount();

        }
        public void GameControl_Start()
        {
            //ゲーム起動フラグを立てる
            gamestart_flag = true;
            //キーダウン回数の初期化
            keyDownCount.save(0);
            //keydown_count_xor = 0;
            //キーダウン回数の表示
            //this.keycountLabel.Text = (keydown_count_xor).ToString("d") + "回";
            this.keycountLabel.Text = (keyDownCount.load()).ToString("d") + "回";
            //タイマカウンタの初期化
            timer_counter = 5;
            //タイマの起動
            countTimeTimer.Start();
            //もふもふの非表示
            mofumofu_ctl(false);
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
                keyDownCount.save(keyDownCount.load() + 1);
                //キーダウン回数の表示
                this.keycountLabel.Text = (keyDownCount.load()).ToString("d") + "回";
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
                TopForm.sendScoreControl.Visible = true;
                TopForm.sendScoreControl.Start();
               TopForm.gameControl.Visible = false;
                //                ScoreHttp scoreHttp = new ScoreHttp();
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
