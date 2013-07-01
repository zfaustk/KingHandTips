using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KingHandTips
{
    public partial class PictureMenu : UserControl
    {
        public PictureMenu()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 获取和设置菜单是否打开的状态
        /// </summary>
        public bool isOpen { set; get; }

        /// <summary>
        /// 获取和设置图像菜单中的选项的数目
        /// </summary>
        public int Num { set; get; }
       
        /// <summary>
        /// 获取和设置每一个菜单项的内容
        /// </summary>
        public string[] strItems = null;

        /// <summary>
        /// 获取和设置菜单项的原始背景图
        /// </summary>
        public Bitmap btmItem = null;

        /// <summary>
        /// 获取和设置菜单项的选择图
        /// </summary>
        public Bitmap btmItemLight = null;

        /// <summary>
        /// 获取和设置当前的选择项
        /// </summary>
        public PictureBox Index = null;

        /// <summary>
        /// 是否需要关闭
        /// </summary>
        bool needClose = true;

        /// <param name="strItem">菜单项的字符串，用',''|'';'分隔</param>
        /// <param name="btmItem">菜单项静息状态下的背景图像</param>
        /// <param name="btmItemLight">菜单项动作状态下的背景图像</param>
        public void InitialMenu(string strItem, Bitmap btmItem, Bitmap btmItemLight, bool needClose = true)
        {
            if (strItem != null)
            {
                strItems = strItem.Split(new char[] { ','}, StringSplitOptions.RemoveEmptyEntries);
                Num = strItems.Length;
            }
            else
            {
                Num = 0;
            }

            this.btmItem = btmItem;
            this.btmItemLight = btmItemLight;

            this.Height = btmItem.Height ;
            this.Width = btmItem.Width;

            this.BackColor = Color.Gray;

            this.isOpen = false;
            this.needClose = needClose;

            this.Controls.Clear();

            //添加最初Item
            PictureBox pb = new PictureBox();
            pb.Name = "KH";
            pb.Width = btmItem.Width;
            pb.Height = btmItem.Height;
            pb.Image = DrawIn(Properties.Resources.Down, false);
            this.Controls.Add(pb);
            pb.MouseClick += new MouseEventHandler(pb_MouseClick);
            pb.MouseMove += new MouseEventHandler(pb_MouseMove);
            pb.MouseLeave += new EventHandler(pb_MouseLeave);
            Index = pb;
            //添加Item
            for (int i = 0; i < Num; i++)
            {
                pb = new PictureBox();
                //设置标识
                pb.Name = strItems[i].Trim();
                //设置初始图像
                string str = (pb.Name.Length> btmItem.Width / 9) ? pb.Name.Substring(0, btmItem.Width / 9)+".." : pb.Name;
                pb.Image = DrawIn(str, false);
                //设置大小
                pb.Width = btmItem.Width;
                pb.Height = btmItem.Height;
                //设置事件
                pb.MouseMove += new MouseEventHandler(pb_MouseMove);
                pb.MouseLeave += new EventHandler(pb_MouseLeave);
                pb.MouseClick += new MouseEventHandler(pb_MouseClick);
                //设置位置
                pb.Left = 0;
                pb.Top = (btmItem.Height + 1) * (i+1);
                //添加到当中
                this.Controls.Add(pb);
            }
        }

        private void PictureMenu_Load(object sender, EventArgs e)
        {
            
        }

        /// <summary>
        /// 将文字画到Item背景图片上
        /// </summary>
        Bitmap DrawIn(string str,bool light)
        {
            Bitmap btm;
            if(light)
                btm = new Bitmap(btmItemLight, btmItemLight.Width, btmItemLight.Height);
            else
                btm = new Bitmap(btmItem, btmItem.Width, btmItem.Height);
            Graphics g = Graphics.FromImage(btm);
            if (light)
                g.DrawString(str, new Font("Helvetica", 10f, FontStyle.Bold), new SolidBrush(Color.White), 1, 2);
            else
                g.DrawString(str, new Font("Helvetica", 10f, FontStyle.Bold), new SolidBrush(Color.LightGray), 1, 2);
            g.Dispose();
            return btm;
        }

        /// <summary>
        /// 将图像画到Item背景图片上
        /// </summary>
        Bitmap DrawIn(Bitmap b, bool light)
        {
            Bitmap btm;
            if (light)
                btm = new Bitmap(btmItemLight, btmItemLight.Width, btmItemLight.Height);
            else
                btm = new Bitmap(btmItem, btmItem.Width, btmItem.Height);
            Graphics g = Graphics.FromImage(btm);
            g.DrawImage(b, new Rectangle(0, 0, btm.Width, btm.Height));
            g.Dispose();
            return btm;
        }

        /// <summary>
        /// 强制关闭该菜单
        /// </summary>
        public void Close()
        {
            this.Height = this.btmItem.Height;
            ((PictureBox)Controls[0]).Image = DrawIn(Properties.Resources.Down, false);
            isOpen = false;
            return;
        }

        /// <summary>
        /// 强制打开该菜单
        /// </summary>
        public void Open()
        {
            this.Height = (this.btmItem.Height + 1) * (Num + 1);
            ((PictureBox)Controls[0]).Image = DrawIn(Properties.Resources.Up, true);
            isOpen = true;
            return;
        }

        void pb_MouseClick(object sender, MouseEventArgs e)
        {
            Index = (PictureBox)sender;
            Dispatcher.frmTheTip.Selected();
            if (((PictureBox)sender).Name == "KH")
            {
                if (isOpen == false)
                {
                    this.Height = (this.btmItem.Height + 1) * (Num + 1);
                    ((PictureBox)sender).Image = DrawIn(Properties.Resources.Up, true);
                    isOpen = true;
                    return;
                }
                else
                {
                    this.Height = this.btmItem.Height;
                    ((PictureBox)sender).Image = DrawIn(Properties.Resources.Down, false);
                    isOpen = false;
                    return;
                }
            }
            for (int i = 1; i < this.Controls.Count; i++)
            {
                PictureBox pb = (PictureBox)Controls[i];
                if (Controls[i] != Index)
                {
                    string str = (pb.Name.Length > btmItem.Width / 9) ? pb.Name.Substring(0, btmItem.Width / 9) + ".." : pb.Name;
                    pb.Image = DrawIn(str, false);
                }
                else
                {
                    string str = (pb.Name.Length > btmItem.Width / 9) ? pb.Name.Substring(0, btmItem.Width / 9) + ".." : pb.Name;
                    pb.Image = DrawIn(str, true);
                }
            }
            //关闭菜单
            if(this.needClose)this.Close();
            
        }

        void pb_MouseLeave(object sender, EventArgs e)
        {
            
            if (((PictureBox)sender).Name == "KH")
            {
                if (isOpen == false)
                {
                    ((PictureBox)sender).Image = DrawIn(Properties.Resources.Down, false);
                }
                return;
            }
            if (Index == (PictureBox)sender) return;
            PictureBox pb = (PictureBox)sender;
            string str = (pb.Name.Length > btmItem.Width / 9) ? pb.Name.Substring(0, btmItem.Width / 9) + ".." : pb.Name;
            pb.Image = DrawIn(str, false);

        }

        void pb_MouseMove(object sender, MouseEventArgs e)
        {
            if (((PictureBox)sender).Name == "KH")
            {
                if (isOpen == false)
                {
                    ((PictureBox)sender).Image = DrawIn(Properties.Resources.Down, true);
                }
                return;
            }
            if (Index == (PictureBox)sender) return;
            PictureBox pb = (PictureBox)sender;
            string str = (pb.Name.Length > btmItem.Width / 9) ? pb.Name.Substring(0, btmItem.Width / 9)+".." : pb.Name;
            pb.Image = DrawIn(str, true);
        }
        
    }
}
