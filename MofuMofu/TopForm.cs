using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MofuMofu
{
    public partial class TopForm : Form
    {
        public static RankingControl rankingControl;
        public static SelectModeControl selectModeControl;
        public static GameControl gameControl;
        public static CountdownControl countdownControl;
        public static SendScoreControl sendScoreControl;

        public TopForm()
        {
            InitializeComponent();
        }

        private void TopWindow_Load(object sender, EventArgs e)
        {
            #region コントロールの作成
            //モード選択画面===================================
            selectModeControl = new SelectModeControl();
            this.mainPanel.Controls.Add(selectModeControl);
            selectModeControl.Visible = true;
            //ランキング画面===================================
            rankingControl = new RankingControl();
            this.mainPanel.Controls.Add(rankingControl);
            rankingControl.Visible = false;
            //ゲーム開始前カウントダウン画面===================
            countdownControl = new CountdownControl();
            this.mainPanel.Controls.Add(countdownControl);
            countdownControl.Visible = false;
            //ゲーム画面=======================================
            gameControl = new GameControl();
            this.mainPanel.Controls.Add(gameControl);
            gameControl.Visible = false;
            //スコア送信画面===================================
            sendScoreControl = new SendScoreControl();
            this.mainPanel.Controls.Add(sendScoreControl);
            sendScoreControl.Visible = false;

            #endregion

        }

        //ゲーム画面用keyイベントの作成========================
        private void TopForm_KeyDown(object sender, KeyEventArgs e)
        {
            //雑w
            gameControl.GameControl_KeyDown(sender, e);
        }

        private void TopForm_KeyUp(object sender, KeyEventArgs e)
        {
            //雑w
            gameControl.GameControl_KeyUp(sender, e);
        }
    }
}
