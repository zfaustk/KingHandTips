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
    public partial class Option : Form
    {
        public Option()
        {
            InitializeComponent();
        }

        public int ChangY = 0;
        public int ChangX = 0;

        private void Option_Load(object sender, EventArgs e)
        {
            if (ProState.isShrink)
            {
                if (ProState.isLock)
                    pictureBox1.Image = Properties.Resources.BackCloseUnable;
                else
                    pictureBox1.Image = Properties.Resources.BackClose;
            }
            else
            {
                pictureBox1.Image = Properties.Resources.BackRight;
            }
            if (ProState.isLock)
            {
                pictureBoxLock.Image = Properties.Resources.LockClose;
            }
            else
            {
                pictureBoxLock.Image = Properties.Resources.LockOpen;
            }
            if (ProState.isShrink)
            {
                pictureBoxShrink.Image = Properties.Resources.ShrinkClose;
            }
            else
            {
                pictureBoxShrink.Image = Properties.Resources.Shrink;
            }
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            if(ProState.isShrink)
                if (ProState.isLock)
                    pictureBox1.Image = Properties.Resources.BackCloseUnable;
                else
                    pictureBox1.Image = Properties.Resources.BackClose;
            else
                pictureBox1.Image = Properties.Resources.BackRight;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (ProState.isShrink)
                if(ProState.isLock)
                    pictureBox1.Image = Properties.Resources.BackCloseUnable;
                else
                    pictureBox1.Image = Properties.Resources.BackClosePass;
            else
                pictureBox1.Image = Properties.Resources.BackRightLight;
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (ProState.isShrink)
            {
                if (!ProState.isLock)
                    Application.Exit();
            }
            else
            {
                Dispatcher.frmMain.CloseBlue();
                this.Close();
            }
        }

        private void pictureBoxLock_MouseMove(object sender, MouseEventArgs e)
        {
            if (ProState.isLock)
            {
                pictureBoxLock.Image = Properties.Resources.LockClosePass;
            }
            else
            {
                pictureBoxLock.Image = Properties.Resources.LockOpenPass;
            }
        }

        private void pictureBoxLock_MouseLeave(object sender, EventArgs e)
        {
            if (ProState.isLock)
            {
                pictureBoxLock.Image = Properties.Resources.LockClose;
            }
            else
            {
                pictureBoxLock.Image = Properties.Resources.LockOpen;
            }
        }

        private void pictureBoxLock_MouseClick(object sender, MouseEventArgs e)
        {
            if (ProState.isLock)
                ProState.isLock = false;
            else 
                ProState.isLock = true;
            if (ProState.isLock)
            {
                if (ProState.isShrink)
                    pictureBox1.Image = Properties.Resources.BackCloseUnable;
                pictureBoxLock.Image = Properties.Resources.LockClose;
            }
            else
            {
                if (ProState.isShrink)
                    pictureBox1.Image = Properties.Resources.BackClose;
                pictureBoxLock.Image = Properties.Resources.LockOpen;
            }
        }

        private void pictureBoxShrink_MouseMove(object sender, MouseEventArgs e)
        {
            if (ProState.isShrink)
            {
                pictureBoxShrink.Image = Properties.Resources.ShrinkClosePass;
            }
            else
            {
                pictureBoxShrink.Image = Properties.Resources.ShrinkPass;
            }
        }

        private void pictureBoxShrink_MouseLeave(object sender, EventArgs e)
        {
            if (ProState.isShrink)
            {
                pictureBoxShrink.Image = Properties.Resources.ShrinkClose;
            }
            else
            {
                pictureBoxShrink.Image = Properties.Resources.Shrink;
            }
        }

        private void pictureBoxShrink_MouseClick(object sender, MouseEventArgs e)
        {
            if (Dispatcher.frmTheTip == null)
                {
                    return;
                }
            if (ProState.isShrink)
                ProState.isShrink = false;
            else
                ProState.isShrink = true;                
            if (ProState.isShrink)
            {
                pictureBoxShrink.Image = Properties.Resources.ShrinkClose;
                    
                pictureBox1.Image = Properties.Resources.BackClose;
  
                Dispatcher.frmTheTip.ChangY = 0;
                Dispatcher.frmTheTip.ChangeTextBoxPos(2);
                Dispatcher.frmTheTip.Width = ProState.TipWidth;

                if (Dispatcher.frmMain != null)
                {
                    Dispatcher.frmMain.Width = 1;
                    Dispatcher.frmMain.Height = 0;
                }
                if (Dispatcher.frmSetting != null)
                {
                    Dispatcher.frmSetting.Close();
                    if (Dispatcher.frmMain != null)
                        Dispatcher.frmMain.CloseGreen();
                }

                Dispatcher.frmMain.MoveAll(Dispatcher.frmMain.Left, Dispatcher.frmMain.Top, true);
            }
            else
            {
                pictureBoxShrink.Image = Properties.Resources.Shrink;

                pictureBox1.Image = Properties.Resources.BackRight;

                Dispatcher.frmTheTip.ChangY = 87;
                Dispatcher.frmTheTip.Width = 254;

                Dispatcher.frmMain.Width = 330;
                Dispatcher.frmMain.Height = 87;
                Dispatcher.frmMain.MoveAll(Dispatcher.frmMain.Left,Dispatcher.frmMain.Top,true);
                Dispatcher.frmTheTip.ChangeTextBoxPos(0);
                
            }

            if (ProState.isLock && ProState.isShrink)
                    pictureBox1.Image = Properties.Resources.BackCloseUnable;
        }

        private void Option_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void Option_MouseMove(object sender, MouseEventArgs e)
        {

        }

        
    }
}
