namespace KingHandTips
{
    partial class Option
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxLock = new System.Windows.Forms.PictureBox();
            this.pictureBoxShrink = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShrink)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::KingHandTips.Properties.Resources.BackRight;
            this.pictureBox1.Location = new System.Drawing.Point(3, 6);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(19, 21);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // pictureBoxLock
            // 
            this.pictureBoxLock.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxLock.Image = global::KingHandTips.Properties.Resources.LockOpen;
            this.pictureBoxLock.Location = new System.Drawing.Point(3, 33);
            this.pictureBoxLock.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxLock.Name = "pictureBoxLock";
            this.pictureBoxLock.Size = new System.Drawing.Size(19, 21);
            this.pictureBoxLock.TabIndex = 1;
            this.pictureBoxLock.TabStop = false;
            this.pictureBoxLock.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBoxLock_MouseClick);
            this.pictureBoxLock.MouseLeave += new System.EventHandler(this.pictureBoxLock_MouseLeave);
            this.pictureBoxLock.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBoxLock_MouseMove);
            // 
            // pictureBoxShrink
            // 
            this.pictureBoxShrink.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxShrink.Image = global::KingHandTips.Properties.Resources.Shrink;
            this.pictureBoxShrink.Location = new System.Drawing.Point(3, 58);
            this.pictureBoxShrink.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxShrink.Name = "pictureBoxShrink";
            this.pictureBoxShrink.Size = new System.Drawing.Size(19, 21);
            this.pictureBoxShrink.TabIndex = 2;
            this.pictureBoxShrink.TabStop = false;
            this.pictureBoxShrink.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBoxShrink_MouseClick);
            this.pictureBoxShrink.MouseLeave += new System.EventHandler(this.pictureBoxShrink_MouseLeave);
            this.pictureBoxShrink.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBoxShrink_MouseMove);
            // 
            // Option
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImage = global::KingHandTips.Properties.Resources.BACKCOLOR;
            this.ClientSize = new System.Drawing.Size(28, 87);
            this.Controls.Add(this.pictureBoxShrink);
            this.Controls.Add(this.pictureBoxLock);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Option";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Option";
            this.Load += new System.EventHandler(this.Option_Load);
            this.MouseLeave += new System.EventHandler(this.Option_MouseLeave);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Option_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShrink)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBoxLock;
        private System.Windows.Forms.PictureBox pictureBoxShrink;
    }
}