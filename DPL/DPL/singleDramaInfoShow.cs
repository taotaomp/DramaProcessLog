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
    public partial class singleDramaInfoShow : UserControl
    {   
    /// <summary>
    /// 构造方法 +1重载  用于有数据输入时的控件构造
    /// </summary>
    /// <param name="DramaInfo"></param>
        public singleDramaInfoShow(String DramaInfo)   
        {
            InitializeComponent();
            try
            {
                messageProcess(DramaInfo);      //处理传入函数的消息
                withMessageControlsAdd();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        public void messageProcess(String DramaInfo)       //处理传入函数的消息，将消息显示到控件中
        {
            String[] temp = DramaInfo.Split('#');
            textBox_DramaName.Text = temp[0];
            textBox_DramaTotalProgress.Text = temp[1];
            textBox_DramaLocalProgress.Text = temp[2];
            pictureBox_DramaPic.ImageLocation = temp[3];
            progressBar_Drama.Maximum = Convert.ToInt32(temp[1]);
            progressBar_Drama.Value = Convert.ToInt32(temp[2]);
            textBox_DramaLocalProgress.ReadOnly = true;
            textBox_DramaName.ReadOnly = true;
            textBox_DramaTotalProgress.ReadOnly = true;
        }

        Button countUpForTotal;
        Button countDownForTotal;
        Button countUpForLocal;
        Button countDownForLocal;

        private void withMessageControlsAdd()   //用于有消息传入时的控件添加
        {
            Button delete = new Button();       //删除按钮
            delete.Location = new Point(580, -1);
            delete.Text = "删除";
            delete.Width = 20;
            delete.Height = 378;
            delete.FlatStyle = FlatStyle.Flat;
            delete.FlatAppearance.MouseOverBackColor = Color.Blue;
            delete.Click += new EventHandler(delete_Click);
            this.Controls.Add(delete);

            countUpForTotal = new Button();      //番剧总进度+按钮
            countUpForTotal.Location = new Point(261, 162);
            countUpForTotal.Text = "+1s";
            countUpForTotal.Width = 31;
            countUpForTotal.Height = 31;
            countUpForTotal.Click += new EventHandler(count_Click);
            this.Controls.Add(countUpForTotal);

            countDownForTotal = new Button();    //番剧总进度-按钮
            countDownForTotal.Location = new Point(309, 162);
            countDownForTotal.Text = "-1s";
            countDownForTotal.Width = 31;
            countDownForTotal.Height = 31;
            countDownForTotal.Click += new EventHandler(count_Click);
            this.Controls.Add(countDownForTotal);

            countUpForLocal = new Button();      //番剧当前进度+按钮
            countUpForLocal.Location = new Point(261, 221);
            countUpForLocal.Text = "+1s";
            countUpForLocal.Width = 31;
            countUpForLocal.Height = 31;
            countUpForLocal.Click += new EventHandler(count_Click);
            this.Controls.Add(countUpForLocal);

            countDownForLocal = new Button();        //番剧当前进度-按钮
            countDownForLocal.Location = new Point(309, 221);
            countDownForLocal.Text = "-1s";
            countDownForLocal.Width = 31;
            countDownForLocal.Height = 31;
            countDownForLocal.Click += new EventHandler(count_Click);
            this.Controls.Add(countDownForLocal);
        }

        private void count_Click(object sender, EventArgs e)
        {
            if (sender.Equals(countUpForTotal))
            {
                textBox_DramaTotalProgress.Text = (int.Parse(textBox_DramaTotalProgress.Text) + 1).ToString();      //信息+1
                if(int.Parse(textBox_DramaTotalProgress.Text)< progressBar_Drama.Value) throw new IndexOutOfRangeException();       //满足异常条件则抛出异常
                progressBar_Drama.Maximum = int.Parse(textBox_DramaTotalProgress.Text);     //更改进度条相关值
            }
            else if (sender.Equals(countUpForLocal))
            {
                textBox_DramaLocalProgress.Text = (int.Parse(textBox_DramaLocalProgress.Text) + 1).ToString();
                if (int.Parse(textBox_DramaLocalProgress.Text) > progressBar_Drama.Maximum) throw new IndexOutOfRangeException();
                progressBar_Drama.Value = int.Parse(textBox_DramaLocalProgress.Text);
            }
            else if (sender.Equals(countDownForTotal))
            {
                textBox_DramaTotalProgress.Text = (int.Parse(textBox_DramaTotalProgress.Text) - 1).ToString();
                if (int.Parse(textBox_DramaTotalProgress.Text) < progressBar_Drama.Value) throw new IndexOutOfRangeException();
                progressBar_Drama.Maximum = int.Parse(textBox_DramaTotalProgress.Text);
            }
            else if (sender.Equals(countDownForLocal))
            {
                textBox_DramaLocalProgress.Text = (int.Parse(textBox_DramaLocalProgress.Text) - 1).ToString();
                if (int.Parse(textBox_DramaLocalProgress.Text) > progressBar_Drama.Maximum) throw new IndexOutOfRangeException();
                progressBar_Drama.Value = int.Parse(textBox_DramaLocalProgress.Text);
            }
        }

        private void delete_Click(object sender,EventArgs e)
        {
            
        }

        /// <summary>
        /// 构造方法 用于无数据输入的控件构造
        /// </summary>
        public singleDramaInfoShow()
        {
            InitializeComponent();
            noMessageControlsAdd();     //控件添加
        }

        Panel dramaManager;     //番剧大页面容器
        public Panel DramaManager
        {
            get { return dramaManager; }
            set { dramaManager = value; }
        }

        private void noMessageControlsAdd()     //用于无消息传入时的控件添加
        {
            this.Controls.Remove(progressBar_Drama);

            pictureBox_DramaPic.Click += new System.EventHandler(pictureBox_DramaPic_Click);    //为图片控件绑定点击事件

            Button confirm = new Button();
            confirm.Text = "确定";
            confirm.Location = new Point(458, 295);
            confirm.Click += new System.EventHandler(confirm_Click);
            Button cancel = new Button();
            cancel.Text = "取消";
            cancel.Location = new Point(469, 295);
            cancel.Click += new System.EventHandler(cancel_Click);
            this.Controls.Add(confirm);
            this.Controls.Add(cancel);
        }

        private void confirm_Click(object sender,EventArgs e)
        {
            string newDramaInfo = textBox_DramaName.Text + "#"+     //字符串合成
            textBox_DramaTotalProgress.Text +"#"+
            textBox_DramaLocalProgress.Text +"#"+
            pictureBox_DramaPic.ImageLocation;

            Main.multiDramaInfoList.Add(newDramaInfo);
            Main.multiDramaContainerEnbody.loadMulitDrama();    //重新装载所有数据
            Main.dramaManager.Controls.Remove(this);
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Main.multiDramaContainerEnbody.loadMulitDrama();    //重新装载所有数据
            Main.dramaManager.Controls.Remove(this);
        }

        private void pictureBox_DramaPic_Click(object sender, EventArgs e)
        {
            OpenFileDialog choosePic = new OpenFileDialog();
            choosePic.Filter = "Image Files(*.BMP; *.JPG; *.GIF)| *.BMP; *.JPG; *.GIF | All files(*.*) | *.* ";
            choosePic.ShowDialog();
            pictureBox_DramaPic.ImageLocation = choosePic.FileName;
        }
    }
}
