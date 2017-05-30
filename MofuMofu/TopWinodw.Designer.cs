namespace MofuMofu
{
    partial class TopWindow
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

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.moveRankingWindowsB = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // moveRankingWindowsB
            // 
            this.moveRankingWindowsB.Location = new System.Drawing.Point(52, 237);
            this.moveRankingWindowsB.Name = "moveRankingWindowsB";
            this.moveRankingWindowsB.Size = new System.Drawing.Size(75, 23);
            this.moveRankingWindowsB.TabIndex = 0;
            this.moveRankingWindowsB.Text = "ランキング画面";
            this.moveRankingWindowsB.UseVisualStyleBackColor = true;
            this.moveRankingWindowsB.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(164, 237);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // topWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 295);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.moveRankingWindowsB);
            this.Name = "topWindow";
            this.Text = "もふもふしよ♥";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button moveRankingWindowsB;
        private System.Windows.Forms.Button button2;
    }
}

