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
    public partial class SelectModeControl : UserControl
    {
        public SelectModeControl()
        {
            InitializeComponent();
        }

        private void SelectModeControl_Load(object sender, EventArgs e)
        {

        }

        private void ShowRankingB_Click(object sender, EventArgs e)
        {
            //ランキング画面に移動
            TopForm.rankingControl.Visible = true;
            //選択画面の非表示
            TopForm.selectModeControl.Visible = false;
            TopForm.rankingControl.Start();
        }

        private void GameStartB_Click(object sender, EventArgs e)
        {
            //カウントダウン画面に移動
            TopForm.countdownControl.Visible = true;
            TopForm.countdownControl.CountdownControl_Start();
            //選択画面の非表示
            TopForm.selectModeControl.Visible = false;
        }
    }
}
