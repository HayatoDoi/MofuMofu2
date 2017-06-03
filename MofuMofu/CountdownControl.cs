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
    public partial class CountdownControl : UserControl
    {
        private System.Media.SoundPlayer player = null;
        private int timerCounter; // カウントダウンカウンター(0 <= timerCounter <= 3)

        public CountdownControl()
        {
            InitializeComponent();
        }

        private void CountdownControl_Load(object sender, EventArgs e)
        {
            
        }
        // カウントダウンの開始
        public void CountdownControl_Start()
        {

            //音楽の再生(ぷぷぷぽーん)
            System.IO.Stream pupupon = Properties.Resources.pupupon;
            player = new System.Media.SoundPlayer(pupupon);
            player.Play();

            timerCounter = 3;
            // カウントダウンカウンターを表示させる
            this.countdownLabel.Text = timerCounter.ToString("d");
            //タイマーをスタートさせる
            this.oneSecTimer.Start();
        }

        private void oneSecTimer_Tick(object sender, EventArgs e)
        {
            // 1秒ごとにカウンタをデクリメント(最大3秒)
            timerCounter--;
            if (timerCounter == 0)
            {
                //タイマーを止める
                this.oneSecTimer.Stop();
                //ゲーム画面に移動
                TopForm.gameControl.Visible = true;
                TopForm.gameControl.GameControl_Start();
                //カウントダウン画面の終了
                TopForm.countdownControl.Visible = false;
            }
            // 表示されているカウントダウンカウンターを更新
            this.countdownLabel.Text = timerCounter.ToString("d");
        }
    }
}
