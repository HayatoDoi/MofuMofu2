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
    }
}
