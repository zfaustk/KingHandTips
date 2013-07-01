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
    public partial class PictureButton : UserControl
    {
        public PictureButton()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 获取和设置菜单是否打开的状态
        /// </summary>
        public bool isSelected { set; get; }

        /// <summary>
        /// 获取和设置菜单项的原始背景图
        /// </summary>
        public Bitmap btmItem = null;

        /// <summary>
        /// 获取和设置菜单项的选择图
        /// </summary>
        public Bitmap btmItemLight = null;

        /// <summary>
        /// 获取和设置菜单项的标志
        /// </summary>
        public Bitmap btmSign = null;

        /// <summary>
        /// 获取和设置菜单项高亮的标志
        /// </summary>
        public Bitmap btmSignLight = null;

        private void PictureButton_Load(object sender, EventArgs e)
        {
        }

        public void Initial(string name, Bitmap btmItem, Bitmap btmItemLight,Bitmap sign = null,Bitmap signlight = null)
        {
            this.btmItem = btmItem;
            this.btmItemLight = btmItemLight;
            this.Height = btmItem.Height;
            this.Width = btmItem.Width;
            this.BackColor = Color.Transparent;
            this.isSelected = false;
            this.Name = name;
            this.btmSign = sign;
            this.btmSignLight = signlight;
            //添加最初Item
            PictureBox pb = new PictureBox();
            pb.Name = "KHOpen";
            pb.Width = btmItem.Width;
            pb.Height = btmItem.Height;
            if (btmSign == null)
            {
                string str = (Name.Length > btmItem.Width / 9) ? Name.Substring(0, btmItem.Width / 9) + ".." : Name;
                pb.Image = DrawIn(Name, false);
            }
            else
            {
                pb.Image = DrawIn(btmSign, false);
            }
            this.Controls.Add(pb);
            pb.MouseClick += new MouseEventHandler(pb_MouseClick);
            pb.MouseMove += new MouseEventHandler(pb_MouseMove);
            pb.MouseLeave += new EventHandler(pb_MouseLeave);
            //添加Item
            
        }

        void pb_MouseLeave(object sender, EventArgs e)
        {
            if (isSelected == true) return;
            PictureBox pb = (PictureBox)sender;
            if (btmSign == null)
            {
                string str = (Name.Length > btmItem.Width / 9) ? Name.Substring(0, btmItem.Width / 9) + ".." : Name;
                pb.Image = DrawIn(Name, false);
            }
            else
            {
                pb.Image = DrawIn(btmSign, false);
            }
        }

        void pb_MouseMove(object sender, MouseEventArgs e)
        {
            if (isSelected == true) return;
            PictureBox pb = (PictureBox)sender;
            if (btmSign == null)
            {
                string str = (Name.Length > btmItem.Width / 9) ? Name.Substring(0, btmItem.Width / 9) + ".." : Name;
                pb.Image = DrawIn(Name, true);
            }
            else
            {
                pb.Image = DrawIn(btmSign, true);
                
            }
        }

        void pb_MouseClick(object sender, MouseEventArgs e)
        {
            if (isSelected == true)
            {
                Dispatcher.Cancle(Name);
                PictureBox pb = (PictureBox)sender;
                if (btmSign == null)
                {
                    string str = (Name.Length > btmItem.Width / 9) ? Name.Substring(0, btmItem.Width / 9) + ".." : Name;
                    pb.Image = DrawIn(Name, false);
                }
                else
                {
                    pb.Image = DrawIn(btmSign, false);
                }
                isSelected = false;
                return;
            }
            else
            {
                Dispatcher.Dispatch(Name);
                PictureBox pb = (PictureBox)sender;
                if (btmSignLight != null)
                {
                    pb.Image = DrawIn(btmSignLight, true);
                }
                isSelected = true;
                return;
            }
        }

        /// <summary>
        /// 将文字画到Item背景图片上
        /// </summary>
        Bitmap DrawIn(string str, bool light)
        {
            Bitmap btm;
            if (light)
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
        /// 强制关闭
        /// </summary>
        public void Close()
        {
            PictureBox pb = (PictureBox)Controls[0];
            if (btmSign == null)
            {
                string str = (Name.Length > btmItem.Width / 9) ? Name.Substring(0, btmItem.Width / 9) + ".." : Name;
                pb.Image = DrawIn(Name, false);
            }
            else
            {
                pb.Image = DrawIn(btmSign, false);
            }
            isSelected = false;
        }

        /// <summary>
        /// 强制打开
        /// </summary>
        public void Open()
        {
            PictureBox pb = (PictureBox)Controls[0];
            if (btmSign == null)
            {
                string str = (Name.Length > btmItem.Width / 9) ? Name.Substring(0, btmItem.Width / 9) + ".." : Name;
                pb.Image = DrawIn(Name, true);
            }
            else
            {
                pb.Image = DrawIn(btmSignLight, true);
            }
            isSelected = true;
        }
    }
}
