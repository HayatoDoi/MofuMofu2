namespace MofuMofu
{
    partial class SendScoreControl
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
            this.yourScoreLabel = new System.Windows.Forms.Label();
            this.yourNameLabel = new System.Windows.Forms.Label();
            this.userName = new System.Windows.Forms.TextBox();
            this.registrationButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // yourScoreLabel
            // 
            this.yourScoreLabel.AutoSize = true;
            this.yourScoreLabel.Font = new System.Drawing.Font("メイリオ", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.yourScoreLabel.Location = new System.Drawing.Point(127, 128);
            this.yourScoreLabel.Name = "yourScoreLabel";
            this.yourScoreLabel.Size = new System.Drawing.Size(268, 52);
            this.yourScoreLabel.TabIndex = 0;
            this.yourScoreLabel.Text = "スコア : 100回";
            // 
            // yourNameLabel
            // 
            this.yourNameLabel.AutoSize = true;
            this.yourNameLabel.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.yourNameLabel.Location = new System.Drawing.Point(132, 180);
            this.yourNameLabel.Name = "yourNameLabel";
            this.yourNameLabel.Size = new System.Drawing.Size(266, 48);
            this.yourNameLabel.TabIndex = 1;
            this.yourNameLabel.Text = "スコアを登録します。\r\nあなたの名前を入力してください。\r\n";
            // 
            // userName
            // 
            this.userName.Location = new System.Drawing.Point(136, 231);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(246, 19);
            this.userName.TabIndex = 2;
            // 
            // registrationButton
            // 
            this.registrationButton.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.registrationButton.Location = new System.Drawing.Point(136, 277);
            this.registrationButton.Name = "registrationButton";
            this.registrationButton.Size = new System.Drawing.Size(111, 36);
            this.registrationButton.TabIndex = 3;
            this.registrationButton.Text = "登録";
            this.registrationButton.UseVisualStyleBackColor = true;
            this.registrationButton.Click += new System.EventHandler(this.registrationButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.CancelButton.Location = new System.Drawing.Point(271, 277);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(111, 36);
            this.CancelButton.TabIndex = 4;
            this.CancelButton.Text = "キャンセル";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // SendScoreControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.registrationButton);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.yourNameLabel);
            this.Controls.Add(this.yourScoreLabel);
            this.Name = "SendScoreControl";
            this.Size = new System.Drawing.Size(525, 450);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label yourScoreLabel;
        private System.Windows.Forms.Label yourNameLabel;
        private System.Windows.Forms.TextBox userName;
        private System.Windows.Forms.Button registrationButton;
        private System.Windows.Forms.Button CancelButton;
    }
}
