namespace MofuMofu
{
    partial class GameControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameControl));
            this.chinoPic = new System.Windows.Forms.PictureBox();
            this.mofumofu1Pic = new System.Windows.Forms.PictureBox();
            this.mofumofu2Pic = new System.Windows.Forms.PictureBox();
            this.mofumofu3Pic = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.keycountLabel = new System.Windows.Forms.Label();
            this.countTimeLabal = new System.Windows.Forms.Label();
            this.countTimeTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.chinoPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mofumofu1Pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mofumofu2Pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mofumofu3Pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // chinoPic
            // 
            this.chinoPic.Image = ((System.Drawing.Image)(resources.GetObject("chinoPic.Image")));
            this.chinoPic.Location = new System.Drawing.Point(119, 90);
            this.chinoPic.Name = "chinoPic";
            this.chinoPic.Size = new System.Drawing.Size(303, 360);
            this.chinoPic.TabIndex = 0;
            this.chinoPic.TabStop = false;
            // 
            // mofumofu1Pic
            // 
            this.mofumofu1Pic.Image = ((System.Drawing.Image)(resources.GetObject("mofumofu1Pic.Image")));
            this.mofumofu1Pic.Location = new System.Drawing.Point(85, 360);
            this.mofumofu1Pic.Name = "mofumofu1Pic";
            this.mofumofu1Pic.Size = new System.Drawing.Size(55, 41);
            this.mofumofu1Pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.mofumofu1Pic.TabIndex = 1;
            this.mofumofu1Pic.TabStop = false;
            // 
            // mofumofu2Pic
            // 
            this.mofumofu2Pic.Image = ((System.Drawing.Image)(resources.GetObject("mofumofu2Pic.Image")));
            this.mofumofu2Pic.Location = new System.Drawing.Point(408, 337);
            this.mofumofu2Pic.Name = "mofumofu2Pic";
            this.mofumofu2Pic.Size = new System.Drawing.Size(49, 64);
            this.mofumofu2Pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.mofumofu2Pic.TabIndex = 2;
            this.mofumofu2Pic.TabStop = false;
            // 
            // mofumofu3Pic
            // 
            this.mofumofu3Pic.Image = ((System.Drawing.Image)(resources.GetObject("mofumofu3Pic.Image")));
            this.mofumofu3Pic.Location = new System.Drawing.Point(366, 162);
            this.mofumofu3Pic.Name = "mofumofu3Pic";
            this.mofumofu3Pic.Size = new System.Drawing.Size(56, 41);
            this.mofumofu3Pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.mofumofu3Pic.TabIndex = 3;
            this.mofumofu3Pic.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(342, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(183, 114);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // keycountLabel
            // 
            this.keycountLabel.AutoSize = true;
            this.keycountLabel.Font = new System.Drawing.Font("MS UI Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.keycountLabel.Location = new System.Drawing.Point(379, 63);
            this.keycountLabel.Name = "keycountLabel";
            this.keycountLabel.Size = new System.Drawing.Size(130, 37);
            this.keycountLabel.TabIndex = 5;
            this.keycountLabel.Text = "1000回";
            // 
            // countTimeLabal
            // 
            this.countTimeLabal.AutoSize = true;
            this.countTimeLabal.ForeColor = System.Drawing.Color.Black;
            this.countTimeLabal.Location = new System.Drawing.Point(12, 10);
            this.countTimeLabal.Name = "countTimeLabal";
            this.countTimeLabal.Size = new System.Drawing.Size(67, 12);
            this.countTimeLabal.TabIndex = 6;
            this.countTimeLabal.Text = "残り 10.00秒";
            // 
            // countTimeTimer
            // 
            this.countTimeTimer.Interval = 10;
            this.countTimeTimer.Tick += new System.EventHandler(this.countTimeTimer_Tick);
            // 
            // GameControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.countTimeLabal);
            this.Controls.Add(this.keycountLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.mofumofu3Pic);
            this.Controls.Add(this.mofumofu2Pic);
            this.Controls.Add(this.mofumofu1Pic);
            this.Controls.Add(this.chinoPic);
            this.ForeColor = System.Drawing.Color.Blue;
            this.Name = "GameControl";
            this.Size = new System.Drawing.Size(525, 450);
            this.Load += new System.EventHandler(this.GameControl_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.GameControl_MouseDown);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.GameControl_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.chinoPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mofumofu1Pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mofumofu2Pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mofumofu3Pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox chinoPic;
        private System.Windows.Forms.PictureBox mofumofu1Pic;
        private System.Windows.Forms.PictureBox mofumofu2Pic;
        private System.Windows.Forms.PictureBox mofumofu3Pic;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label keycountLabel;
        private System.Windows.Forms.Label countTimeLabal;
        private System.Windows.Forms.Timer countTimeTimer;
    }
}
