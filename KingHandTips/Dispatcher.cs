using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KingHandTips
{
    public static class Dispatcher 
    {
        /// <summary>
        /// 主窗口的存根
        /// </summary>
        public static FormMain frmMain = null;

        /// <summary>
        /// Setting窗口的存根
        /// </summary>
        public static Setting frmSetting = null;

        /// <summary>
        /// TheTips窗口的存根
        /// </summary>
        public static TheTip frmTheTip = null;

        /// <summary>
        /// TheTips窗口的存根
        /// </summary>
        public static Option frmOp = null;

        public static void Dispatch(string cmd)
        {
            switch (cmd)
            {
                case "Settin":
                    {
                        frmMain.ShowSetting();
                        break;
                    }
                case "Tips":
                    {
                        frmMain.ShowTheTip();
                        break;
                    }
                case "Info":
                    {
                        frmMain.ShowInfo();
                        break;
                    }
                case "Option":
                    {
                        frmMain.ShowOp();
                        break;
                    }

            }
        }

        public static void Cancle(string cmd)
        {
            switch (cmd)
            {
                case "Settin":
                    {
                        frmSetting.Close();
                        frmSetting = null;
                        break;
                    }
                case "Tips":
                    {
                        frmTheTip.Close();
                        frmTheTip = null;
                        break;
                    }
                case "Info":
                    {
                        frmMain.ShowInfo(false);
                        break;
                    }
                case "Option":
                    {
                        frmOp.Close();
                        frmOp = null;
                        break;
                    }
            }
        }

        /// <summary>
        /// //设置所有窗体透明度
        /// </summary>
        public static void SetOpacity()
        {
            if (ProState.isLock)
            {
                if (Dispatcher.frmMain != null)
                    frmMain.SetOpacity();
                return;
            }
            if (ProState.Opacity < 0.5) ProState.Opacity = 0.5;
            try
            {
                if (Dispatcher.frmMain != null)
                    Dispatcher.frmMain.Opacity = ProState.Opacity;
                if (Dispatcher.frmSetting != null)
                    Dispatcher.frmSetting.Opacity = ProState.Opacity;
                if (Dispatcher.frmTheTip != null)
                    Dispatcher.frmTheTip.Opacity = ProState.Opacity;
                if (Dispatcher.frmOp != null)
                    Dispatcher.frmOp.Opacity = ProState.Opacity;
            }
            catch
            {
            }
        }


    }

}
