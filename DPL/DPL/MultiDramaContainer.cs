using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DPL
{
    public partial class MultiDramaContainer : UserControl
    {
        public MultiDramaContainer()
        {
            InitializeComponent();

            loadMulitDrama();
        }

        private singleDramaInfoShow singleDramaInfoShowEnbody;      //展示单个番剧信息控件
        public singleDramaInfoShow SingleDramaInfoShowEnbody
        {
            get{    return singleDramaInfoShowEnbody;   }
            set{    singleDramaInfoShowEnbody = value;  }
        }

        labelWithSaveMessage loadDrama;     //番剧标签

        public void loadMulitDrama()    //加载番剧标签
        {
            Label AddNewDrama = new Label();
            AddNewDrama.ForeColor = Color.Black;
            AddNewDrama.Text = "点我添加新番喵~";
            AddNewDrama.TextAlign = ContentAlignment.MiddleCenter;
            AddNewDrama.AutoSize = false;
            AddNewDrama.Width = 210;
            AddNewDrama.Click += new System.EventHandler(this.AddNewDrama_Click);
            flowLayoutPanel_mulitDramaContainer.Controls.Add(AddNewDrama);
            for (int i = 0; i < Main.multiDramaInfoList.Count; i++)
            {
                String[] temp = Main.multiDramaInfoList[i].ToString().Split('#');
                loadDrama = new labelWithSaveMessage();
                loadDrama.DramaInfo = Main.multiDramaInfoList[i].ToString();    //将番剧的全部信息载入标签
                loadDrama.DramaName.Text = temp[0];
                loadDrama.Width = 210;
                loadDrama.BackColor = Color.Red;
                loadDrama.Click += new System.EventHandler(Drama_Click);
                flowLayoutPanel_mulitDramaContainer.Controls.Add(loadDrama);
            }
            
        } 

        private void AddNewDrama_Click(object sender, EventArgs e)  //添加新番标签点击事件
        {
            if (Main.dramaManager.Controls.Contains(singleDramaInfoShowEnbody))      //检索是否有单个番剧信息控件加载
            {
                Main.dramaManager.Controls.Remove(singleDramaInfoShowEnbody);
            }
            singleDramaInfoShowEnbody = new singleDramaInfoShow();
            singleDramaInfoShowEnbody.Location = new Point(210, 0);
            Main.dramaManager.Controls.Add(singleDramaInfoShowEnbody);
            flowLayoutPanel_mulitDramaContainer.Controls.Clear();       //清空容器中的所有已装载数据
        }

        private void Drama_Click(object sender, EventArgs e)    //番剧标签点击事件
        {
            if (Main.dramaManager.Controls.Contains(singleDramaInfoShowEnbody))      //检索是否有单个番剧信息控件加载
            {
                Main.dramaManager.Controls.Remove(singleDramaInfoShowEnbody);
            }
            labelWithSaveMessage temp = (labelWithSaveMessage)sender;       //获取当前被点击的番剧标签
            singleDramaInfoShowEnbody = new singleDramaInfoShow(temp.DramaInfo);    //将标签中含有的信息传入目标控件中
            singleDramaInfoShowEnbody.Location = new Point(210, 0);
            Main.dramaManager.Controls.Add(singleDramaInfoShowEnbody);
        }
    }
}
