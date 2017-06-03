namespace MofuMofu
{
    partial class RankingControl
    {
        /// <summary> 
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region コンポーネント デザイナーで生成されたコード

        /// <summary> 
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RankingControl));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rankGridView = new System.Windows.Forms.DataGridView();
            this.rank = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.score = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rankGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 61);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // rankGridView
            // 
            this.rankGridView.AllowUserToAddRows = false;
            this.rankGridView.AllowUserToDeleteRows = false;
            this.rankGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.rankGridView.BackgroundColor = System.Drawing.Color.White;
            this.rankGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rankGridView.CausesValidation = false;
            this.rankGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rankGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rank,
            this.name,
            this.score});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.rankGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.rankGridView.GridColor = System.Drawing.Color.Blue;
            this.rankGridView.Location = new System.Drawing.Point(13, 89);
            this.rankGridView.Name = "rankGridView";
            this.rankGridView.ReadOnly = true;
            this.rankGridView.RowHeadersVisible = false;
            this.rankGridView.RowTemplate.Height = 21;
            this.rankGridView.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.rankGridView.Size = new System.Drawing.Size(490, 321);
            this.rankGridView.TabIndex = 1;
            this.rankGridView.UseWaitCursor = true;
            // 
            // rank
            // 
            this.rank.FillWeight = 30F;
            this.rank.HeaderText = "順位";
            this.rank.Name = "rank";
            this.rank.ReadOnly = true;
            this.rank.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.rank.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.rank.Width = 40;
            // 
            // name
            // 
            this.name.FillWeight = 225F;
            this.name.HeaderText = "名前";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.name.Width = 224;
            // 
            // score
            // 
            this.score.FillWeight = 225F;
            this.score.HeaderText = "スコア";
            this.score.Name = "score";
            this.score.ReadOnly = true;
            this.score.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.score.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.score.Width = 224;
            // 
            // RankingControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.rankGridView);
            this.Controls.Add(this.pictureBox1);
            this.Name = "RankingControl";
            this.Size = new System.Drawing.Size(525, 450);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rankGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView rankGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn rank;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn score;
    }
}
