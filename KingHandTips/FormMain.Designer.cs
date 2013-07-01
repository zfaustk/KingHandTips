namespace KingHandTips
{
    partial class FormMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            this.pictureBoxMinisize = new System.Windows.Forms.PictureBox();
            this.pictureButtonRed = new KingHandTips.PictureButton();
            this.pictureBarOp = new KingHandTips.PictureBar();
            this.pictureButtonGreen = new KingHandTips.PictureButton();
            this.pictureButtonBlue = new KingHandTips.PictureButton();
            this.pictureButtonOrange = new KingHandTips.PictureButton();
            this.pictureBoxInfo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinisize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxClose
            // 
            this.pictureBoxClose.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxClose.Image = global::KingHandTips.Properties.Resources.Close;
            this.pictureBoxClose.Location = new System.Drawing.Point(2, 4);
            this.pictureBoxClose.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxClose.Name = "pictureBoxClose";
            this.pictureBoxClose.Size = new System.Drawing.Size(20, 20);
            this.pictureBoxClose.TabIndex = 9;
            this.pictureBoxClose.TabStop = false;
            this.pictureBoxClose.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBoxClose_MouseClick);
            this.pictureBoxClose.MouseLeave += new System.EventHandler(this.pictureBoxClose_MouseLeave);
            this.pictureBoxClose.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBoxClose_MouseMove);
            // 
            // pictureBoxMinisize
            // 
            this.pictureBoxMinisize.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxMinisize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxMinisize.Image = global::KingHandTips.Properties.Resources.MiniSize;
            this.pictureBoxMinisize.InitialImage = global::KingHandTips.Properties.Resources.MiniSizeLight;
            this.pictureBoxMinisize.Location = new System.Drawing.Point(25, 4);
            this.pictureBoxMinisize.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxMinisize.Name = "pictureBoxMinisize";
            this.pictureBoxMinisize.Size = new System.Drawing.Size(20, 20);
            this.pictureBoxMinisize.TabIndex = 10;
            this.pictureBoxMinisize.TabStop = false;
            this.pictureBoxMinisize.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBoxMinisize_MouseClick);
            this.pictureBoxMinisize.MouseLeave += new System.EventHandler(this.pictureBoxMinisize_MouseLeave);
            this.pictureBoxMinisize.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBoxMinisize_MouseMove);
            // 
            // pictureButtonRed
            // 
            this.pictureButtonRed.isSelected = false;
            this.pictureButtonRed.Location = new System.Drawing.Point(0, 61);
            this.pictureButtonRed.Name = "pictureButtonRed";
            this.pictureButtonRed.Size = new System.Drawing.Size(62, 26);
            this.pictureButtonRed.TabIndex = 15;
            // 
            // pictureBarOp
            // 
            this.pictureBarOp.BackColor = System.Drawing.Color.Transparent;
            this.pictureBarOp.Location = new System.Drawing.Point(11, 35);
            this.pictureBarOp.Name = "pictureBarOp";
            this.pictureBarOp.Size = new System.Drawing.Size(241, 16);
            this.pictureBarOp.TabIndex = 14;
            this.pictureBarOp.Value = 0D;
            // 
            // pictureButtonGreen
            // 
            this.pictureButtonGreen.BackgroundImage = global::KingHandTips.Properties.Resources.Settin;
            this.pictureButtonGreen.isSelected = false;
            this.pictureButtonGreen.Location = new System.Drawing.Point(64, 61);
            this.pictureButtonGreen.Name = "pictureButtonGreen";
            this.pictureButtonGreen.Size = new System.Drawing.Size(62, 26);
            this.pictureButtonGreen.TabIndex = 13;
            // 
            // pictureButtonBlue
            // 
            this.pictureButtonBlue.BackgroundImage = global::KingHandTips.Properties.Resources.Op;
            this.pictureButtonBlue.isSelected = false;
            this.pictureButtonBlue.Location = new System.Drawing.Point(128, 61);
            this.pictureButtonBlue.Name = "pictureButtonBlue";
            this.pictureButtonBlue.Size = new System.Drawing.Size(62, 26);
            this.pictureButtonBlue.TabIndex = 12;
            // 
            // pictureButtonOrange
            // 
            this.pictureButtonOrange.BackgroundImage = global::KingHandTips.Properties.Resources.Tips;
            this.pictureButtonOrange.isSelected = false;
            this.pictureButtonOrange.Location = new System.Drawing.Point(192, 61);
            this.pictureButtonOrange.Margin = new System.Windows.Forms.Padding(0);
            this.pictureButtonOrange.Name = "pictureButtonOrange";
            this.pictureButtonOrange.Size = new System.Drawing.Size(62, 26);
            this.pictureButtonOrange.TabIndex = 11;
            // 
            // pictureBoxInfo
            // 
            this.pictureBoxInfo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxInfo.Image = global::KingHandTips.Properties.Resources.InfoWin;
            this.pictureBoxInfo.Location = new System.Drawing.Point(59, 0);
            this.pictureBoxInfo.Name = "pictureBoxInfo";
            this.pictureBoxInfo.Size = new System.Drawing.Size(272, 29);
            this.pictureBoxInfo.TabIndex = 16;
            this.pictureBoxInfo.TabStop = false;
            this.pictureBoxInfo.Visible = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.BackgroundImage = global::KingHandTips.Properties.Resources.BackGroundKH;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(330, 87);
            this.Controls.Add(this.pictureBoxInfo);
            this.Controls.Add(this.pictureButtonRed);
            this.Controls.Add(this.pictureBarOp);
            this.Controls.Add(this.pictureButtonGreen);
            this.Controls.Add(this.pictureButtonBlue);
            this.Controls.Add(this.pictureButtonOrange);
            this.Controls.Add(this.pictureBoxMinisize);
            this.Controls.Add(this.pictureBoxClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.Tan;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinisize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxClose;
        private System.Windows.Forms.PictureBox pictureBoxMinisize;
        private PictureButton pictureButtonOrange;
        private PictureButton pictureButtonBlue;
        private PictureButton pictureButtonGreen;
        private PictureBar pictureBarOp;
        private PictureButton pictureButtonRed;
        private System.Windows.Forms.PictureBox pictureBoxInfo;


    }
}

