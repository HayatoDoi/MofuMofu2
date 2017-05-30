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

        WMPLib.WindowsMediaPlayer mediaPlayer = new WMPLib.WindowsMediaPlayer();
        int timerCounter = 3; // カウントダウンカウンター(0 <= timerCounter <= 3)

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
            try
            {
                //音楽の再生(ぷぷぷぽーん)
                mediaPlayer.URL = "C:\\Users\\nono\\Desktop\\MofuMofu\\voice\\ぷぷぷぽーん.mp3";
                mediaPlayer.controls.play();
            }
            catch (System.IO.FileNotFoundException ex)
            {
                //ファイルが無かったときは、音楽を再生せずに処理を続ける。
            }
            // カウントダウンカウンターを表示させる
            this.countdownLabel.Text = timerCounter.ToString("d");
            //タイマーをスタートさせる
            this.oneSecTimer.Start();
        }

        private void oneSecTimer_Tick(object sender, EventArgs e)
        {
            // 1秒ごとにカウンタをデクリメント(最大3秒)
            timerCounter--;
            if (timerCounter == -1)
            {
                //タイマーを止める
                this.oneSecTimer.Stop();
                //カウントダウン画面の終了
                TopForm.countdownControl.Visible = false;
                //ゲーム画面に移動
                TopForm.gameControl.Visible = true;
                TopForm.gameControl.GameControl_Start();
            }
            // 表示されているカウントダウンカウンターを更新
            this.countdownLabel.Text = timerCounter.ToString("d");
        }
    }
}
