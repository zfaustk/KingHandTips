using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace KingHandTips
{
    public partial class TheTip : Form
    {
        /// <summary>
        /// X相对于主窗口的坐标
        /// </summary>
        public int ChangX = 0;
        /// <summary>
        /// Y相对于主窗口的坐标
        /// </summary>
        public int ChangY = 0;

        public TheTip()
        {
            InitializeComponent();
        }

        private void pictureMenu1_Load(object sender, EventArgs e)
        {
            pictureMenu1.InitialMenu(ProState.TipTitle, Properties.Resources.Orange, Properties.Resources.OrangeLight,false);
            string path = Directory.GetCurrentDirectory() + "\\Tips\\" + this.pictureMenu1.Index.Name;
            richTextBox1.LoadFile( path, RichTextBoxStreamType.RichText);
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string path = Directory.GetCurrentDirectory() + "\\Tips\\" + this.pictureMenu1.Index.Name;
                richTextBox1.SaveFile(Directory.GetCurrentDirectory() + "\\Tips\\" + this.pictureMenu1.Index.Name, RichTextBoxStreamType.RichText);
            }
            catch
            {
                return;
            }
        }

        public void Selected()
        {
            Directory.CreateDirectory(Directory.GetCurrentDirectory() + "\\Tips");

            string path = Directory.GetCurrentDirectory() + "\\Tips\\" + this.pictureMenu1.Index.Name;

            //FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            if (File.Exists(path) == false)//文件不存在
            {
                richTextBox1.Text = " ";
                richTextBox1.SaveFile(path, RichTextBoxStreamType.RichText);
            }
            richTextBox1.LoadFile(path, RichTextBoxStreamType.RichText);
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox1.Image = Properties.Resources.DairyLight;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.Dairy;
        }

        private void TheTip_Load(object sender, EventArgs e)
        {
            richTextBox1.MouseDown += new MouseEventHandler(TheTip_MouseDown);
            richTextBox1.MouseUp += new MouseEventHandler(TheTip_MouseUp);
            richTextBox1.MouseMove += new MouseEventHandler(TheTip_MouseMove);
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            string year = DateTime.Now.Year.ToString();
            string month = DateTime.Now.Month >= 10 ? DateTime.Now.Month.ToString() : "0" + DateTime.Now.Month.ToString();
            string day = DateTime.Now.Day >= 10 ? DateTime.Now.Day.ToString() : "0" + DateTime.Now.Day.ToString();

            Directory.CreateDirectory(Directory.GetCurrentDirectory() + "\\Dairy");
            string path = Directory.GetCurrentDirectory() + "\\Dairy\\" + year + "_" + month ;
            Directory.CreateDirectory(path);
            string pathName = path + "\\" + this.pictureMenu1.Index.Name + "_" + year + month + day;
            if (e.Button == MouseButtons.Left)
                richTextBox1.SaveFile(pathName + ".rtf", RichTextBoxStreamType.RichText);
            else if (e.Button == MouseButtons.Right)
                System.Diagnostics.Process.Start("explorer.exe", "/e,"+path);
        }

        private void TheTip_MouseDown(object sender, MouseEventArgs e)
        {
            ProState.MouseDown = true;
            ProState.CurrentPosX = MousePosition.X - Dispatcher.frmMain.Left;
            ProState.CurrentPosY = MousePosition.Y - Dispatcher.frmMain.Top;
        }

        private void TheTip_MouseMove(object sender, MouseEventArgs e)
        {
            int change = 0;
            if (ProState.MouseDown == true)
            {
                if (this.Width - ProState.CurrentPosX < 8 && ProState.isShrink && !ProState.isLock)
                {
                    change = MousePosition.X - ProState.CurrentPosX - Dispatcher.frmMain.Left;
                    if(change > 0 || ProState.CurrentPosX - this.ChangX > 160)
                        this.Width += MousePosition.X - ProState.CurrentPosX - Dispatcher.frmMain.Left;
                    ProState.CurrentPosX = MousePosition.X - Dispatcher.frmMain.Left;
                    ProState.TipWidth = this.Width;
                }
                else
                {
                    Dispatcher.frmMain.MoveAll(MousePosition.X - ProState.CurrentPosX, MousePosition.Y - ProState.CurrentPosY);
                }
            }
        }

        private void TheTip_MouseUp(object sender, MouseEventArgs e)
        {
            ProState.MouseDown = false;
        }

        public void ChangeTextBoxPos(int i){
            this.richTextBox1.Top = i;
            this.pictureMenu1.Top = i;
        }

        
    }
}
