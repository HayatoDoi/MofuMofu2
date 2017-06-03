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
    public partial class SendScoreControl : UserControl
    {
        public SendScoreControl()
        {
            InitializeComponent();
        }
        public void Start()
        {
            yourScoreLabel.Text = "スコア : " + TopForm.gameControl.keyDownCount.load().ToString() + "回";
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            //選択画面に移動
            TopForm.selectModeControl.Visible = true;
            TopForm.sendScoreControl.Visible = false;
        }

        private void registrationButton_Click(object sender, EventArgs e)
        {
            if(this.userName.Text == "")
            {
                MessageBox.Show("名前を入力してください。");
            }
            else
            {
                ScoreHttps scoreHttp = new ScoreHttps();
                bool result = scoreHttp.SendScore(this.userName.Text, TopForm.gameControl.keyDownCount.load());
                if(result == false)
                {
                    MessageBox.Show("ネットワークエラー");
                }
                else
                {
                    MessageBox.Show("登録が完了しました。");
                    //選択画面に移動
                    TopForm.selectModeControl.Visible = true;
                    TopForm.sendScoreControl.Visible = false;

                }
            }

        }
    }
}
