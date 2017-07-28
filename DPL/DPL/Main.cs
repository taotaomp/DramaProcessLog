using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DPL
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        Panel dramaManager;             //番剧大页面容器
        FlowLayoutPanel multiDramaContainer;    //复数番剧容器

        private void frmConfigure()     //窗口配置信息
        {
            this.StartPosition = FormStartPosition.CenterParent;        //窗口起始位置设定
            this.MaximizeBox = false;                                   //取消最大化功能
            this.FormBorderStyle = FormBorderStyle.FixedSingle;         //使窗口不可调整大小

            //向窗口中添加用于管理番剧的大页面的容器
            dramaManager = new Panel();
            dramaManager.BackColor = Color.Red;
            dramaManager.Width = this.Width;
            dramaManager.Height = this.Height;
            dramaManager.Location = new Point(0, 0);
            this.Controls.Add(dramaManager);

            dramaManagerConfigure();    //番剧大页面容器配置
        }

        private void dramaManagerConfigure()    //番剧大页面容器配置
        {
            multiDramaContainer = new FlowLayoutPanel();
            multiDramaContainer.BackColor = Color.White;
            multiDramaContainer.Width = 210;
            multiDramaContainer.Height = this.Height;
            dramaManager.Controls.Add(multiDramaContainer);
        }

        private void Main_Load(object sender, EventArgs e)
        {
            frmConfigure();             //加载窗体配置方法
        }
    }
}
