using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace MofuMofu
{
    public partial class RankingControl : UserControl
    {
        public RankingControl()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // セレクトモード画面に移動
            TopForm.selectModeControl.Visible = true;
            TopForm.rankingControl.Visible = false;
        }
        public void Start()
        {
            ScoreHttps scoreHttp = new ScoreHttps();
            Hashtable[] rankinglist = scoreHttp.GetRanking();
            if(rankinglist.Length == 0)
            {
                MessageBox.Show("サーバにデータが登録されていない。\nもしくは、サーバに接続できません。");
                // セレクトモード画面に移動
                TopForm.selectModeControl.Visible = true;
                TopForm.rankingControl.Visible = false;
            }
            else
            {
                //ランキング表の表示
                this.rankGridView.Rows.Clear();
                for (int i = 0; i < rankinglist.Length; i++)
                {
                    this.rankGridView.Rows.Add(
                        (i + 1).ToString("d"),
                        rankinglist[i]["name"],
                        rankinglist[i]["score"].ToString());
                }
            }
        }
    }
}
