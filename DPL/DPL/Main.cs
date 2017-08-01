using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.IO;

namespace DPL
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        public static Panel dramaManager;             //番剧大页面容器
        public static MultiDramaContainer multiDramaContainerEnbody;      //多个番剧条目容器
        public static ArrayList multiDramaInfoList = new ArrayList();   //多个番剧信息容器

        private void frmConfigure()     //窗口配置信息（整个窗口的配置）
        {
            this.StartPosition = FormStartPosition.CenterParent;        //窗口起始位置设定
            this.MaximizeBox = false;                                   //取消最大化功能
            this.FormBorderStyle = FormBorderStyle.FixedSingle;         //使窗口不可调整大小

            //向窗口中添加用于管理番剧的大页面的容器
            dramaManager = new Panel();
            //dramaManager.BackColor = Color.Red;
            dramaManager.Width = this.Width;
            dramaManager.Height = this.Height;
            dramaManager.Location = new Point(0, 0);
            this.Controls.Add(dramaManager);
            dramaManagerConfigure();    //番剧大页面容器配置
        }

        private void dramaManagerConfigure()    //番剧大页面容器配置
        {
            multiDramaContainerEnbody = new MultiDramaContainer();
            dramaManager.Controls.Add(multiDramaContainerEnbody);
        }

        private void multiDramaInfoListLoad()       //从本地文件中加载信息
        {
            StreamWriter FileChecker = new StreamWriter("dramaInfo", true, Encoding.UTF8);
            FileChecker.Close();
            using (StreamReader SR = new StreamReader("dramaInfo",Encoding.UTF8))
            {
                while (!SR.EndOfStream)
                {
                    multiDramaInfoList.Add(SR.ReadLine());      //从文件中读取番剧信息
                }
                SR.Close();
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            frmConfigure();             //加载窗体配置方法
            multiDramaInfoListLoad();   //从本地文件中加载信息
        }
    }
}
