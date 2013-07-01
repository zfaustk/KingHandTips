using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KingHandTips
{
    public partial class Setting : Form
    {
        /// <summary>
        /// X相对于主窗口的坐标
        /// </summary>
        public int ChangX = 0;
        /// <summary>
        /// Y相对于主窗口的坐标
        /// </summary>
        public int ChangY = 0;

        public Setting()
        {
            InitializeComponent();
        }

        private void pictureBoxBack_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBoxBack.Image = Properties.Resources.ResetLight;
        }

        private void pictureBoxBack_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxBack.Image = Properties.Resources.Reset;
        }

        private void pictureBoxBack_MouseClick(object sender, MouseEventArgs e)
        {
            //重置
            this.ReSet();
        }

        /// <summary>
        /// 重置设置
        /// </summary>
        public void ReSet()
        {
            this.textBox1.Text = strOri[0];
            this.textBox2.Text = strOri[1];
            this.textBox3.Text = strOri[2];
            this.textBox4.Text = strOri[3];
            this.textBox5.Text = strOri[4];
            this.textBox6.Text = strOri[5];
            this.textBox7.Text = strOri[6];
            this.textBox8.Text = strOri[7];
            this.textBox9.Text = strOri[8];
            this.textBox10.Text = strOri[9];
            this.textBox11.Text = strOri[10];
            this.textBox12.Text = strOri[11];
            this.textBox13.Text = strOri[12];
            this.textBox14.Text = strOri[13];
            this.textBox15.Text = strOri[14];
            this.textBox16.Text = strOri[15];
            this.textBox17.Text = strOri[16];
        }

        private string[] strOri = new string[17];

        //private void trackBar1_Scroll(object sender, EventArgs e)
        //{
        //    ProState.Opacity = (double)trackBar1.Value * 5 / 100 + 0.5;
        //    foreach (Form f in Dispatcher.register)
        //    {
        //        f.Opacity = ProState.Opacity;
        //    }

        //}

        private void Setting_Load(object sender, EventArgs e)
        {
            //设置
            //trackBar1.Maximum = 10;
            //trackBar1.Value = (int)(ProState.Opacity * 20) - 10;
            this.Top = Owner.Top + ChangY;
            this.Left = Owner.Left + ChangX;
            //
            string[] strItems = ProState.TipTitle.Split(new char[] { ','}, StringSplitOptions.RemoveEmptyEntries);

            if (strItems.Length > 0) strOri[0] = this.textBox1.Text = strItems[0];
            if (strItems.Length > 1) strOri[1] = this.textBox2.Text = strItems[1];
            if (strItems.Length > 2) strOri[2] = this.textBox3.Text = strItems[2];
            if (strItems.Length > 3) strOri[3] = this.textBox4.Text = strItems[3];
            if (strItems.Length > 4) strOri[4] = this.textBox5.Text = strItems[4];
            if (strItems.Length > 5) strOri[5] = this.textBox6.Text = strItems[5];
            if (strItems.Length > 6) strOri[6] = this.textBox7.Text = strItems[6];
            if (strItems.Length > 7) strOri[7] = this.textBox8.Text = strItems[7];
            if (strItems.Length > 8) strOri[8] = this.textBox9.Text = strItems[8];
            if (strItems.Length > 9) strOri[9] = this.textBox10.Text = strItems[9];
            if (strItems.Length > 10) strOri[10] = this.textBox11.Text = strItems[10];
            if (strItems.Length > 11) strOri[11] = this.textBox12.Text = strItems[11];
            if (strItems.Length > 12) strOri[12] = this.textBox13.Text = strItems[12];
            if (strItems.Length > 13) strOri[13] = this.textBox14.Text = strItems[13];
            if (strItems.Length > 14) strOri[14] = this.textBox15.Text = strItems[14];
            if (strItems.Length > 15) strOri[15] = this.textBox16.Text = strItems[15];
            if (strItems.Length > 16) strOri[16] = this.textBox17.Text = strItems[16];

            if (textBox1.Text == "KH") textBox1.Text = "";
            if (textBox2.Text == "KH") textBox2.Text = "";
            if (textBox3.Text == "KH") textBox3.Text = "";
            if (textBox6.Text == "KH") textBox6.Text = "";
            if (textBox5.Text == "KH") textBox5.Text = "";
            if (textBox4.Text == "KH") textBox4.Text = "";
            if (textBox9.Text == "KH") textBox9.Text = "";
            if (textBox8.Text == "KH") textBox8.Text = "";
            if (textBox7.Text == "KH") textBox7.Text = "";
            if (textBox12.Text == "KH") textBox12.Text = "";
            if (textBox11.Text == "KH") textBox11.Text = "";
            if (textBox10.Text == "KH") textBox10.Text = "";
            if (textBox15.Text == "KH") textBox15.Text = "";
            if (textBox14.Text == "KH") textBox14.Text = "";
            if (textBox13.Text == "KH") textBox13.Text = "";
            if (textBox16.Text == "KH") textBox16.Text = "";
            if (textBox17.Text == "KH") textBox17.Text = "";

            this.textBox1.TextChanged += new EventHandler(textBox_TextChanged);
            this.textBox2.TextChanged += new EventHandler(textBox_TextChanged);
            this.textBox3.TextChanged += new EventHandler(textBox_TextChanged);
            this.textBox6.TextChanged += new EventHandler(textBox_TextChanged);
            this.textBox5.TextChanged += new EventHandler(textBox_TextChanged);
            this.textBox4.TextChanged += new EventHandler(textBox_TextChanged);
            this.textBox9.TextChanged += new EventHandler(textBox_TextChanged);
            this.textBox8.TextChanged += new EventHandler(textBox_TextChanged);
            this.textBox7.TextChanged += new EventHandler(textBox_TextChanged);
            this.textBox12.TextChanged += new EventHandler(textBox_TextChanged);
            this.textBox11.TextChanged += new EventHandler(textBox_TextChanged);
            this.textBox10.TextChanged += new EventHandler(textBox_TextChanged);
            this.textBox15.TextChanged += new EventHandler(textBox_TextChanged);
            this.textBox14.TextChanged += new EventHandler(textBox_TextChanged);
            this.textBox13.TextChanged += new EventHandler(textBox_TextChanged);
            this.textBox16.TextChanged += new EventHandler(textBox_TextChanged);
            this.textBox17.TextChanged += new EventHandler(textBox_TextChanged);

        }

        void textBox_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "KH") textBox1.Text = "";
            if (textBox2.Text == "KH") textBox2.Text = "";
            if (textBox3.Text == "KH") textBox3.Text = "";
            if (textBox6.Text == "KH") textBox6.Text = "";
            if (textBox5.Text == "KH") textBox5.Text = "";
            if (textBox4.Text == "KH") textBox4.Text = "";
            if (textBox9.Text == "KH") textBox9.Text = "";
            if (textBox8.Text == "KH") textBox8.Text = "";
            if (textBox7.Text == "KH") textBox7.Text = "";
            if (textBox12.Text == "KH") textBox12.Text = "";
            if (textBox11.Text == "KH") textBox11.Text = "";
            if (textBox10.Text == "KH") textBox10.Text = "";
            if (textBox15.Text == "KH") textBox15.Text = "";
            if (textBox14.Text == "KH") textBox14.Text = "";
            if (textBox13.Text == "KH") textBox13.Text = "";
            if (textBox16.Text == "KH") textBox16.Text = "";
            if (textBox17.Text == "KH") textBox17.Text = "";

            ProState.TipTitle =
            this.textBox1.Text.Trim().Split(new char[] { ',' })[0] + "," + this.textBox2.Text.Trim().Split(new char[] { ',' })[0] + "," + this.textBox3.Text.Trim().Split(new char[] { ',' })[0] + "," + this.textBox4.Text.Trim().Split(new char[] { ',' })[0] + "," +
            this.textBox5.Text.Trim().Split(new char[] { ',' })[0] + "," + this.textBox6.Text.Trim().Split(new char[] { ',' })[0] + "," + this.textBox7.Text.Trim().Split(new char[] { ',' })[0] + "," + this.textBox8.Text.Trim().Split(new char[] { ',' })[0] + "," +
            this.textBox9.Text.Trim().Split(new char[] { ',' })[0] + "," + this.textBox10.Text.Trim().Split(new char[] { ',' })[0] + "," + this.textBox11.Text.Trim().Split(new char[] { ',' })[0] + "," + this.textBox12.Text.Trim().Split(new char[] { ',' })[0] + "," +
            this.textBox13.Text.Trim().Split(new char[] { ',' })[0] + "," + this.textBox14.Text.Trim().Split(new char[] { ',' })[0] + "," + this.textBox15.Text.Trim().Split(new char[] { ',' })[0] + "," + this.textBox16.Text.Trim().Split(new char[] { ',' })[0] + "," +
            this.textBox17.Text.Trim().Split(new char[] { ',' })[0] + ",";
        }

        private void Setting_MouseDown(object sender, MouseEventArgs e)
        {
            ProState.MouseDown = true ;
            ProState.CurrentPosX = MousePosition.X - Dispatcher.frmMain.Left;
            ProState.CurrentPosY = MousePosition.Y - Dispatcher.frmMain.Top;
            if ((ProState.CurrentPosY - this.ChangY) - (ProState.CurrentPosX - this.ChangX) < -80 && (ProState.CurrentPosY - this.ChangY)<60)
                ProState.MouseDown = false ;
        }

        private void Setting_MouseMove(object sender, MouseEventArgs e)
        {
            if (ProState.MouseDown == true)
            {
                Dispatcher.frmMain.MoveAll(MousePosition.X - ProState.CurrentPosX, MousePosition.Y - ProState.CurrentPosY);
            }
        }

        private void Setting_MouseUp(object sender, MouseEventArgs e)
        {
            ProState.MouseDown = false;
        }


    }
}
