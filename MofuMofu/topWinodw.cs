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
    public partial class TopWindow : Form
    {
        public TopWindow()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ランキング画面のインスタンスを作成
            RankingList rankingWindow = new RankingList(this.Width, this.Height)
            {
                //TopLevelをFalseにする
                TopLevel = false,
                // 外枠を消す.
                FormBorderStyle = FormBorderStyle.None
            };
            //フォームのコントロールに追加する
            this.Controls.Add(rankingWindow);
            //フォームを表示する
            rankingWindow.Show();
            //最前面へ移動
            rankingWindow.BringToFront();
        }
    }
}
