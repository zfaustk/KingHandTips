using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Xml;
using System.IO;

namespace KingHandTips
{
    public static class ProState
    {
        /// <summary>
        /// 设置和获取当前鼠标是否按下的状态
        /// </summary>
        public static bool MouseDown { set; get; }
        /// <summary>
        /// 设置和获取当前鼠标相对于窗口的X坐标
        /// </summary>
        public static int CurrentPosX { set; get; }
        /// <summary>
        /// 设置和获取当前鼠标相对于窗口的Y坐标
        /// </summary>
        public static int CurrentPosY { set; get; }
        /// <summary>
        /// 设置和获取窗口的起始位置X坐标
        /// </summary>
        public static int StartPosX { set; get; }
        /// <summary>
        /// 设置和获取窗口的起始位置Y坐标
        /// </summary>
        public static int StartPosY { set; get; }
        /// <summary>
        /// 设置和获取TheTip的宽度
        /// </summary>
        public static int TipWidth { set; get; }
        /// <summary>
        /// 设置和获取当前是否锁定
        /// </summary>
        public static bool isLock { set; get; }
        /// <summary>
        /// 设置和获取当前是否收缩
        /// </summary>
        public static bool isShrink { set; get; }
        /// <summary>
        /// 设置和获取透明度
        /// </summary>
        public static double Opacity { set; get; }
        /// <summary>
        /// 背景图片
        /// </summary>
        public static Bitmap BackGround = Properties.Resources.BackGroundKH;
        /// <summary>
        /// 生成文件菜单的字符串
        /// </summary>
        public static string TipTitle = "Origin";


        /// <summary>
        /// 从配置中读取状态
        /// </summary>
        public static void ReadXml()
        {
            int Step = 1;
            //开始XML
            XmlTextReader xreader = new XmlTextReader(Directory.GetCurrentDirectory() + "\\Init.kh");
            //读取XML文档
            while (xreader.Read())
            {
                //判断节点类型
                switch (xreader.NodeType)
                {
                    case XmlNodeType.Text:
                        {
                            if (Step == 1)
                            {
                                StartPosX = Convert.ToInt32(xreader.Value);
                                Dispatcher.frmMain.MoveAll(StartPosX, Dispatcher.frmMain.Left);
                            }
                            if (Step == 2)
                            {
                                StartPosY = Convert.ToInt32(xreader.Value);
                                Dispatcher.frmMain.MoveAll(Dispatcher.frmMain.Top, StartPosY);

                            }
                            if (Step == 3)
                            {
                                TipWidth = (Convert.ToInt32(xreader.Value)<120)?120:Convert.ToInt32(xreader.Value);
                            }
                            if (Step == 4)
                            {
                                Opacity = Convert.ToDouble(xreader.Value);
                                Dispatcher.SetOpacity();

                            }
                            if (Step == 5)
                            {
                                isLock = Convert.ToBoolean(xreader.Value);
                            }
                            if (Step == 6)
                            {
                                isShrink = Convert.ToBoolean(xreader.Value);
                            }
                            if (Step == 7)
                            {
                                TipTitle = xreader.Value;
                            }
                            Step++;
                            break;
                        }
                    default:
                        break;
                }

            }
            xreader.Close();
        }

        /// <summary>
        /// 写入状态到配置
        /// </summary>
        public static void WriteXml()
        {
            //实例化WMLWRITER
            XmlTextWriter xtw = new XmlTextWriter(Directory.GetCurrentDirectory() + "\\Init.kh", Encoding.UTF8);
            //设置元素紧缩
            xtw.Formatting = Formatting.Indented;
            //开始XML
            xtw.WriteStartDocument();
            xtw.WriteStartElement("KingHandTips");
            //
            xtw.WriteAttributeString("Title", "Init");
            //
            xtw.WriteElementString("StartPosX", Convert.ToString(Dispatcher.frmMain.Left));
            xtw.WriteElementString("StartPosY", Convert.ToString(Dispatcher.frmMain.Top));
            xtw.WriteElementString("TipWidth", Convert.ToString(TipWidth));
            xtw.WriteElementString("Opacity", Convert.ToString(Opacity));
            xtw.WriteElementString("IsLock", Convert.ToString(isLock));
            xtw.WriteElementString("IsShink", Convert.ToString(isShrink));
            xtw.WriteElementString("TipTitle", TipTitle);
            //
            xtw.WriteEndElement();
            xtw.WriteEndDocument();
            xtw.Flush();
        }
        

    }
}
