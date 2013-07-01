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
    public partial class PictureBar : UserControl
    {
        public PictureBar()
        {
            InitializeComponent();
        }

        private void PictureBar_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 单位未选中时的图样
        /// </summary>
        Bitmap btmOff = null;
        /// <summary>
        /// 选中时的图样
        /// </summary>
        Bitmap btmOn = null;
        /// <summary>
        /// 经过时的图样
        /// </summary>
        Bitmap btmPass = null;
        /// <summary>
        /// 选中的标记的数量
        /// </summary>
        int count = 0;
        /// <summary>
        /// 选中的标记的数量
        /// </summary>
        double Max = 0;
        /// <summary>
        /// 选中的标记的数量
        /// </summary>
        double Min = 0;
        /// <summary>
        /// 选中的标记的数量
        /// </summary>
        double Num = 0;

        /// <summary>
        /// 获取和设置当前值
        /// </summary>
        public double Value
        {
            set { SetValue(value); }
            get { return GetValue(); }
        }

        void SetValue(double v)
        {
            if (v > Max) v = Max;
            else if (v < Min) v = Min;
            this.count = (int)((v - Min) * (Num - 1) / (Max - Min));
            //改变显示
            for (int i = 0; i < Num; i++)
            {
                if (i <= count)
                {
                    ((PictureBox)this.Controls[i]).Image = btmOn;
                }
                else
                {
                    ((PictureBox)this.Controls[i]).Image = btmOff;
                }
            }
        }

        double GetValue()
        {
            //Num-1的理由是，刻度要比区间数多1
            return Min + count * (Max - Min) / (Num - 1);
        }

        /// <param name="width">宽度</param>
        /// <param name="height">高度</param>
        /// <param name="Num">单位数</param>
        /// <param name="Max">代表最大值</param>
        /// <param name="Min">代表最小值</param>
        /// <param name="Min">初始值</param>
        /// <param name="off">关闭时图样</param>
        /// <param name="on">打开时图样</param>
        public void Initial(int width, int height, int Num, double Min, double Max, double init, Bitmap off, Bitmap on, Bitmap pass = null)
        {
            //生成指定大小背景图
            this.BackgroundImage = new Bitmap(Properties.Resources.Trans,new Size(width,height));
            btmOff = new Bitmap(off, height, height);
            btmOn = new Bitmap(on, height, height);
            if(pass != null)
                btmPass = new Bitmap(pass, height, height);
            this.Max = Max;
            this.Min = Min;
            this.Num = Num;
            this.count = (int)((init - Min) * (Num - 1)  / (Max - Min));
            for (int i = 0; i < Num; i++)
            {
                PictureBox pb = new PictureBox();
                pb.Top = 1;
                pb.Left = (int)(1 + i * (width / Num));
                pb.Width = btmOff.Width;
                pb.Height = btmOff.Height;
                if (i <= count)
                    pb.Image = btmOn;
                else
                    pb.Image = btmOff;
                pb.MouseMove += new MouseEventHandler(pb_MouseMove);
                pb.MouseLeave += new EventHandler(pb_MouseLeave);
                pb.MouseClick += new MouseEventHandler(pb_MouseClick);
                this.Controls.Add(pb);
            }
        }

        void pb_MouseClick(object sender, MouseEventArgs e)
        {
            //on表示是否已经找到这一位
            bool on = false;
            for (int i = 0; i < Num; i++)
            {
                if (!on)
                {
                    ((PictureBox)this.Controls[i]).Image = btmOn;
                }
                else
                {
                    ((PictureBox)this.Controls[i]).Image = btmOff;
                }
                if ((PictureBox)this.Controls[i] == (PictureBox)sender)
                {
                    count = i;
                    on = true;
                    //TODO：以后得把这做成事件
                    ProState.Opacity = Value;
                    Dispatcher.SetOpacity();
                }
            }
        }

        void pb_MouseLeave(object sender, EventArgs e)
        {
            for (int i = 0; i < Num; i++)
            {
                if (i<=count)
                {
                    ((PictureBox)this.Controls[i]).Image = btmOn;
                }
                else
                {
                    ((PictureBox)this.Controls[i]).Image = btmOff;
                }
            }
        }

        void pb_MouseMove(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < Num; i++)
            {
                if(btmPass!=null)
                    ((PictureBox)this.Controls[i]).Image = btmPass;
                if ((PictureBox)this.Controls[i] == (PictureBox)sender)
                {
                    break;
                }
            }
        }
    }
}
