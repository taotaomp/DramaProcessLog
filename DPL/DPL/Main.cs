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
        singleDramaInfoShow singleDramaInfoShowEnbody;
        FlowLayoutPanel multiDramaContainer;    //复数番剧容器

        private void frmConfigure()     //窗口配置信息（整个窗口的配置）
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

            Label AddNewDrama = new Label();
            AddNewDrama.Text = "点我添加新番喵~";
            AddNewDrama.Click += new System.EventHandler(this.AddNewDrama_Click);
            multiDramaContainer.Controls.Add(AddNewDrama);
        }

        private void multiDramaContainerItemAdd()   //向复数番剧容器中添加项目
        {

        }

        private void AddNewDrama_Click(object sender, EventArgs e)  //添加新番标签点击事件
        {
            singleDramaInfoShowEnbody = new singleDramaInfoShow("a#12#5#");
            singleDramaInfoShowEnbody.Location = new Point(210, 0);
            dramaManager.Controls.Add(singleDramaInfoShowEnbody);
        }

        private void Main_Load(object sender, EventArgs e)
        {
            frmConfigure();             //加载窗体配置方法
        }
    }
}
