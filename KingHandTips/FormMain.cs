using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.IO;

namespace KingHandTips
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

            
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            //注册窗口
            Dispatcher.frmMain = this;
            //程序状态的初始化
            ProState.Opacity = this.Opacity;
            ProState.StartPosY = this.Top;
            ProState.StartPosX = this.Left;
            //设置状态
            if (File.Exists(Directory.GetCurrentDirectory() + "\\Init.kh") == false)
                ProState.WriteXml();
            try
            {
                ProState.ReadXml();
            }
            catch { }
            //调整位置
            this.Top = ProState.StartPosY;
            this.Left = ProState.StartPosX;
            
            //菜单的初始化
            //this.pictureMenuRed.InitialMenu("bbbb,cxcccxcxc,dssss,ess,asd,fewwe,asda", Properties.Resources.Red, Properties.Resources.RedLight);
            this.pictureButtonRed.Initial("Info", Properties.Resources.Red, Properties.Resources.RedLight, Properties.Resources.Info, Properties.Resources.InfoLight);
            this.pictureButtonGreen.Initial("Settin", Properties.Resources.Green, Properties.Resources.GreenLight, Properties.Resources.Settin, Properties.Resources.SettinLight);
            this.pictureButtonBlue.Initial("Option", Properties.Resources.Blue, Properties.Resources.BlueLight, Properties.Resources.Op, Properties.Resources.OpLight);
            this.pictureButtonOrange.Initial("Tips", Properties.Resources.Orange, Properties.Resources.OrangeLight, Properties.Resources.Tips, Properties.Resources.TipsLight);
            this.pictureBarOp.Initial(235, 12, 11, 0.5, 1.0, ProState.Opacity, Properties.Resources.BarOff, Properties.Resources.BarOn, Properties.Resources.BarPass);
            //创建目录
            Directory.CreateDirectory(Directory.GetCurrentDirectory() + "\\Tips");
            //
            this.pictureBoxInfo.MouseMove += new MouseEventHandler(Form1_MouseMove);
            this.pictureBoxInfo.MouseDown += new MouseEventHandler(Form1_MouseDown);
            this.pictureBoxInfo.MouseUp += new MouseEventHandler(Form1_MouseUp);
            //Shrink的初始化
            if (ProState.isShrink == true)
            {
                this.ShowTheTip();
                this.ShowOp();
                this.pictureButtonBlue.Open();
                this.pictureButtonOrange.Open();
                Dispatcher.frmTheTip.ChangY = 0;
                Dispatcher.frmTheTip.ChangeTextBoxPos(2);
                this.Width = 1;
                this.Height = 0;
                this.MoveAll(this.Left, this.Top, true);
            }
        }


        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            //if (MousePosition.Y - this.Top > ProState.BackGround.Height) return;
            ProState.MouseDown = true;
            ProState.CurrentPosX = MousePosition.X - this.Left; 
            ProState.CurrentPosY = MousePosition.Y - this.Top;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (ProState.MouseDown == true)
            {
                MoveAll(MousePosition.X - ProState.CurrentPosX,MousePosition.Y - ProState.CurrentPosY);
            }
        }

        /// <summary>
        /// 移动到
        /// </summary>
        /// <param name="x">新的X坐标</param>
        /// <param name="y">新的Y坐标</param>
        public void MoveAll(int x, int y, bool force = false)
        {
            if (y < 8 && y > 0) y = 0;
            if (ProState.isLock == true && !force) return;
            this.Left = x;
            this.Top = y;
            if (Dispatcher.frmSetting != null)
            {
                Dispatcher.frmSetting.Top = this.Top + Dispatcher.frmSetting.ChangY;
                Dispatcher.frmSetting.Left = this.Left + Dispatcher.frmSetting.ChangX;
            }
            if (Dispatcher.frmTheTip != null)
            {
                Dispatcher.frmTheTip.Top = this.Top + Dispatcher.frmTheTip.ChangY;
                Dispatcher.frmTheTip.Left = this.Left + Dispatcher.frmTheTip.ChangX;
            }
            if (Dispatcher.frmOp != null)
            {
                Dispatcher.frmOp.Top = this.Top + Dispatcher.frmOp.ChangY;
                Dispatcher.frmOp.Left = this.Left + Dispatcher.frmOp.ChangX;
            }

        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            ProState.MouseDown = false;
        }

        private void pictureBoxClose_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private void pictureBoxClose_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxClose.Image = Properties.Resources.Close;
        }

        private void pictureBoxClose_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBoxClose.Image = Properties.Resources.CloseLight;
        }

        private void pictureBoxMinisize_MouseClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBoxMinisize_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxMinisize.Image = Properties.Resources.MiniSize;
        }

        private void pictureBoxMinisize_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBoxMinisize.Image = Properties.Resources.MiniSizeLight;
        }

        public void ShowSetting()
        {
            if (Dispatcher.frmSetting != null)
            {
                Dispatcher.frmSetting.Close();
                Dispatcher.frmSetting = null;
            }
            Dispatcher.frmSetting = new Setting();
            Dispatcher.frmSetting.ChangY = 26;
            Dispatcher.frmSetting.ChangX = 252;
            Dispatcher.frmSetting.Top = Dispatcher.frmMain.Top + Dispatcher.frmSetting.ChangY;
            Dispatcher.frmSetting.Left = Dispatcher.frmMain.Left + Dispatcher.frmSetting.ChangX;
            Dispatcher.frmSetting.Opacity = ProState.Opacity;
            Dispatcher.frmSetting.Owner = this;
            Dispatcher.frmSetting.Show();
        }

        public void ShowTheTip()
        {
            if (Dispatcher.frmTheTip != null)
            {
                Dispatcher.frmTheTip.Close();
                Dispatcher.frmTheTip = null;
            }
            Dispatcher.frmTheTip = new TheTip();
            Dispatcher.frmTheTip.ChangY = 87;
            Dispatcher.frmTheTip.ChangX = 0;
            if (ProState.isShrink)
                Dispatcher.frmTheTip.Width = ProState.TipWidth;
            Dispatcher.frmTheTip.ChangX = 0;
            Dispatcher.frmTheTip.Top = Dispatcher.frmMain.Top + Dispatcher.frmTheTip.ChangY;
            Dispatcher.frmTheTip.Left = Dispatcher.frmMain.Left + Dispatcher.frmTheTip.ChangX;
            Dispatcher.frmTheTip.Opacity = ProState.Opacity;
            Dispatcher.frmTheTip.Owner = this;
            Dispatcher.frmTheTip.MouseMove += new MouseEventHandler(Form1_MouseMove);
            Dispatcher.frmTheTip.MouseDown += new MouseEventHandler(Form1_MouseDown);
            Dispatcher.frmTheTip.MouseUp += new MouseEventHandler(Form1_MouseUp);
            Dispatcher.frmTheTip.Show();
        }

        public void ShowOp()
        {
            if (Dispatcher.frmOp != null)
            {
                Dispatcher.frmOp.Close();
                Dispatcher.frmOp = null;
            }
            Dispatcher.frmOp = new Option();
            Dispatcher.frmOp.ChangX = -28;
            Dispatcher.frmOp.ChangY = 0;
            Dispatcher.frmOp.Top = Dispatcher.frmMain.Top + Dispatcher.frmOp.ChangY;
            Dispatcher.frmOp.Left = Dispatcher.frmMain.Left + Dispatcher.frmOp.ChangX;
            Dispatcher.frmOp.Opacity = ProState.Opacity;
            Dispatcher.frmOp.MouseMove += new MouseEventHandler(Form1_MouseMove);
            Dispatcher.frmOp.MouseDown += new MouseEventHandler(Form1_MouseDown);
            Dispatcher.frmOp.MouseUp += new MouseEventHandler(Form1_MouseUp);
            Dispatcher.frmOp.Owner = this;//如果不设置，显示的时候这窗口会被别的窗口盖掉
            Dispatcher.frmOp.Show();
            Dispatcher.frmOp.Width = 28;
            Dispatcher.frmOp.Height = 87;
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            ProState.WriteXml();
        }

        public void ShowInfo(bool open = true)
        {
            this.pictureBoxInfo.Visible = open;
        }

        public void CloseBlue()
        {
            this.pictureButtonBlue.Close();
        }

        public void CloseGreen()
        {
            this.pictureButtonGreen.Close();
        }

        public void SetOpacity()
        {
            ProState.Opacity = this.Opacity;
            this.pictureBarOp.Value = this.Opacity;
        }
    }

}
