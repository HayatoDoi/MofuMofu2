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
    public partial class RankingList : Form
    {
        Size mwindowsize;//呼び出し元のwindowのサイズ
        public RankingList(int width, int height)
        {
            this.mwindowsize = new Size(width, height);
            InitializeComponent();
        }

        private void rankingList_Load(object sender, EventArgs e)
        {
            //呼び出しもとのサイズに変更
            this.Size = mwindowsize;

        }
    }
}
