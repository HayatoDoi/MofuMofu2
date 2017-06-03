namespace MofuMofu
{
    partial class SelectModeControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectModeControl));
            this.GameStartB = new System.Windows.Forms.Button();
            this.ShowRankingB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GameStartB
            // 
            this.GameStartB.Location = new System.Drawing.Point(25, 345);
            this.GameStartB.Name = "GameStartB";
            this.GameStartB.Size = new System.Drawing.Size(150, 70);
            this.GameStartB.TabIndex = 1;
            this.GameStartB.Text = "ゲームを始める";
            this.GameStartB.UseVisualStyleBackColor = true;
            this.GameStartB.Click += new System.EventHandler(this.GameStartB_Click);
            // 
            // ShowRankingB
            // 
            this.ShowRankingB.Location = new System.Drawing.Point(350, 345);
            this.ShowRankingB.Name = "ShowRankingB";
            this.ShowRankingB.Size = new System.Drawing.Size(150, 70);
            this.ShowRankingB.TabIndex = 2;
            this.ShowRankingB.Text = "ランキングを表示する";
            this.ShowRankingB.UseVisualStyleBackColor = true;
            this.ShowRankingB.Click += new System.EventHandler(this.ShowRankingB_Click);
            // 
            // SelectModeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.ShowRankingB);
            this.Controls.Add(this.GameStartB);
            this.Name = "SelectModeControl";
            this.Size = new System.Drawing.Size(525, 450);
            this.Load += new System.EventHandler(this.SelectModeControl_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button GameStartB;
        private System.Windows.Forms.Button ShowRankingB;
    }
}
