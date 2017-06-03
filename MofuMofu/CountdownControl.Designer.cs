namespace MofuMofu
{
    partial class CountdownControl
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
            this.components = new System.ComponentModel.Container();
            this.oneSecTimer = new System.Windows.Forms.Timer(this.components);
            this.countdownLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // oneSecTimer
            // 
            this.oneSecTimer.Interval = 1000;
            this.oneSecTimer.Tick += new System.EventHandler(this.oneSecTimer_Tick);
            // 
            // countdownLabel
            // 
            this.countdownLabel.AutoSize = true;
            this.countdownLabel.Font = new System.Drawing.Font("MS UI Gothic", 189.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.countdownLabel.Location = new System.Drawing.Point(143, 118);
            this.countdownLabel.Name = "countdownLabel";
            this.countdownLabel.Size = new System.Drawing.Size(234, 253);
            this.countdownLabel.TabIndex = 0;
            this.countdownLabel.Text = "3";
            // 
            // CountdownControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.countdownLabel);
            this.Name = "CountdownControl";
            this.Size = new System.Drawing.Size(525, 450);
            this.Load += new System.EventHandler(this.CountdownControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer oneSecTimer;
        private System.Windows.Forms.Label countdownLabel;
    }
}
