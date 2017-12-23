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
            progressBar_Drama.Style = ProgressBarStyle.Continuous;
            this.BackColor = Color.FromArgb(120, 240, 240, 240);
            textBox_DramaLocalProgress.BackColor = Color.FromArgb(254, 214, 244);
            textBox_DramaName.BackColor = Color.FromArgb(254, 214, 244);
            textBox_DramaTotalProgress.BackColor = Color.FromArgb(254, 214, 244);
            label_DramaLocalProgress.BackColor = Color.FromArgb(0, 240, 240, 240);
            label_DramaName.BackColor = Color.FromArgb(0, 240, 240, 240);
            label_DramaTotalProgress.BackColor = Color.FromArgb(0, 240, 240, 240);

            messageProcess(DramaInfo);      //处理传入函数的消息
            withMessageControlsAdd();
        }

        string originDramaInfo;     //储存原始的番剧信息

        public void messageProcess(String DramaInfo)       //处理传入函数的消息，将消息显示到控件中
        {
            originDramaInfo = DramaInfo;
            String[] temp = DramaInfo.Split('#');
            textBox_DramaName.Text = temp[0];
            textBox_DramaTotalProgress.Text = temp[1];
            textBox_DramaLocalProgress.Text = temp[2];
            pictureBox_DramaPic.ImageLocation = temp[3];
            progressBar_Drama.Maximum = Convert.ToInt32(temp[1]);
            progressBar_Drama.Value = Convert.ToInt32(temp[2]);
            UrlContent = temp[4];
            textBox_DramaLocalProgress.ReadOnly = true;
            textBox_DramaName.ReadOnly = true;
            textBox_DramaTotalProgress.ReadOnly = true;
        }

        Button countUpForTotal;
        Button countDownForTotal;
        Button countUpForLocal;
        Button countDownForLocal;
        Button EnterUrl;
        string UrlContent;      //网页地址内容

        private void withMessageControlsAdd()   //用于有消息传入时的控件添加
        {
            Button delete = new Button();       //删除按钮
            delete.Location = new Point(580, -1);
            delete.Text = "删除";
            delete.Font = new Font("宋体", 12);
            delete.Width = 24;
            delete.Height = 378;
            delete.FlatStyle = FlatStyle.Flat;
            delete.FlatAppearance.MouseOverBackColor = Color.FromArgb(120, 253, 179, 235); ;
            delete.Click += new EventHandler(delete_Click);
            this.Controls.Add(delete);

            countUpForTotal = new Button();      //番剧总进度+按钮
            countUpForTotal.Location = new Point(203, 95);
            countUpForTotal.Text = "+1s";
            countUpForTotal.Width = 31;
            countUpForTotal.Height = 31;
            countUpForTotal.FlatStyle = FlatStyle.Popup;
            countUpForTotal.BackColor = Color.FromArgb(120, 253, 179, 235);
            countUpForTotal.Click += new EventHandler(count_Click);
            this.Controls.Add(countUpForTotal);

            countDownForTotal = new Button();    //番剧总进度-按钮
            countDownForTotal.Location = new Point(260, 95);
            countDownForTotal.Text = "-1s";
            countDownForTotal.Width = 31;
            countDownForTotal.Height = 31;
            countDownForTotal.FlatStyle = FlatStyle.Popup;
            countDownForTotal.BackColor = Color.FromArgb(120, 253, 179, 235);
            countDownForTotal.Click += new EventHandler(count_Click);
            this.Controls.Add(countDownForTotal);

            countUpForLocal = new Button();      //番剧当前进度+按钮
            countUpForLocal.Location = new Point(314, 317);
            countUpForLocal.Text = "+1s";
            countUpForLocal.Width = 31;
            countUpForLocal.Height = 31;
            countUpForLocal.FlatStyle = FlatStyle.Popup;
            countUpForLocal.BackColor = Color.FromArgb(120, 253, 179, 235);
            countUpForLocal.Click += new EventHandler(count_Click);
            this.Controls.Add(countUpForLocal);

            countDownForLocal = new Button();        //番剧当前进度-按钮
            countDownForLocal.Location = new Point(374, 317);
            countDownForLocal.Text = "-1s";
            countDownForLocal.Width = 31;
            countDownForLocal.Height = 31;
            countDownForLocal.FlatStyle = FlatStyle.Popup;
            countDownForLocal.BackColor = Color.FromArgb(120, 253, 179, 235);
            countDownForLocal.Click += new EventHandler(count_Click);
            this.Controls.Add(countDownForLocal);

            EnterUrl = new Button();
            EnterUrl.Location = new Point(34, 163);
            EnterUrl.Text = "开始追番喵！";
            EnterUrl.Width = 255;
            EnterUrl.Height = 24;
            EnterUrl.FlatStyle = FlatStyle.Popup;
            EnterUrl.BackColor = Color.FromArgb(120, 253, 179, 235);
            EnterUrl.Click += new EventHandler(EnterUrl_Click);
            this.Controls.Add(EnterUrl);
        }

        private void count_Click(object sender, EventArgs e)
        {
            try
            {
                if (sender.Equals(countUpForTotal))
                {
                    textBox_DramaTotalProgress.Text = (int.Parse(textBox_DramaTotalProgress.Text) + 1).ToString();      //信息+1
                    if (int.Parse(textBox_DramaTotalProgress.Text) < progressBar_Drama.Value) throw new IndexOutOfRangeException();       //满足异常条件则抛出异常
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
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("超出范围");
            }
            catch (Exception ea)
            {
                MessageBox.Show(ea.ToString());
            }
            finally
            {
                //添加按钮中的代码稍加改进，意在重新装载
                if (int.Parse(textBox_DramaLocalProgress.Text) > int.Parse(textBox_DramaTotalProgress.Text)) throw new IndexOutOfRangeException();
                string newDramaInfo = textBox_DramaName.Text + "#" +     //字符串合成
                textBox_DramaTotalProgress.Text + "#" +
                textBox_DramaLocalProgress.Text + "#" +
                pictureBox_DramaPic.ImageLocation+"#"+
                UrlContent;

                Main.multiDramaInfoList.Remove(originDramaInfo);
                Main.multiDramaInfoList.Add(newDramaInfo);
                originDramaInfo = newDramaInfo;
                Main.multiDramaContainerEnbody.flowLayoutContainer.Controls.Clear();
                Main.multiDramaContainerEnbody.loadMulitDrama();    //重新装载所有数据
            }
        }

        private void delete_Click(object sender,EventArgs e)
        {
            Main.multiDramaInfoList.Remove(textBox_DramaName.Text + "#" + textBox_DramaTotalProgress.Text + "#" + textBox_DramaLocalProgress.Text + "#" + pictureBox_DramaPic.ImageLocation + "#" + UrlContent);
            Main.multiDramaContainerEnbody.flowLayoutContainer.Controls.Clear();
            Main.multiDramaContainerEnbody.loadMulitDrama();
            Main.dramaManager.Controls.Remove(this);
        }

        private void EnterUrl_Click(object sender,EventArgs e)
        {
            string[] temp = originDramaInfo.Split('#');
            if (temp[4].Equals(String.Empty))
            {
                MessageBox.Show("这个番剧还没有设定地址哦~");
            }
            else
            {
                if(temp[4].Contains("http"))
                {
                    System.Diagnostics.Process.Start(temp[4]);
                }
                else
                {
                    System.Diagnostics.Process.Start("explorer.exe", temp[4]);
                }
            }  
        }

        /// <summary>
        /// 构造方法 用于无数据输入的控件构造
        /// </summary>
        public singleDramaInfoShow()
        {
            InitializeComponent();
            noMessageControlsAdd();     //控件添加

            this.BackColor = Color.FromArgb(120, 240, 240, 240);
            textBox_DramaLocalProgress.BackColor = Color.FromArgb(254, 214, 244);
            textBox_DramaName.BackColor = Color.FromArgb(254, 214, 244);
            textBox_DramaTotalProgress.BackColor = Color.FromArgb(254, 214, 244);
            label_DramaLocalProgress.BackColor = Color.FromArgb(0, 240, 240, 240);
            label_DramaName.BackColor = Color.FromArgb(0, 240, 240, 240);
            label_DramaTotalProgress.BackColor = Color.FromArgb(0, 240, 240, 240);
        }

        Panel dramaManager;     //番剧大页面容器
        public Panel DramaManager
        {
            get { return dramaManager; }
            set { dramaManager = value; }
        }

        TextBox textbox_Url;

        private void noMessageControlsAdd()     //用于无消息传入时的控件添加
        {
            this.Controls.Remove(progressBar_Drama);

            pictureBox_DramaPic.Cursor = Cursors.Hand;
            pictureBox_DramaPic.Click += new System.EventHandler(pictureBox_DramaPic_Click);    //为图片控件绑定点击事件

            Label labelUrl = new Label();
            labelUrl.AutoSize = true;
            labelUrl.Text = "番剧网页地址";
            labelUrl.Font = new Font("华文仿宋", 12, FontStyle.Bold);
            labelUrl.Location = new Point(34, 170);
            labelUrl.BackColor = Color.FromArgb(0, 240, 240, 240);
            this.Controls.Add(labelUrl);

            textbox_Url = new TextBox();
            textbox_Url.Font = new Font("宋体", 9);
            textbox_Url.Location = new Point(170, 170);
            textbox_Url.Width = 200;
            textbox_Url.BackColor = Color.FromArgb(254, 214, 244);
            this.Controls.Add(textbox_Url);

            Button confirm = new Button();
            confirm.Text = "确定";
            confirm.Location = new Point(469, 265);
            confirm.BackColor = Color.FromArgb(254, 214, 244);
            confirm.FlatStyle = FlatStyle.Popup;
            confirm.Click += new System.EventHandler(confirm_Click);
            Button cancel = new Button();
            cancel.Text = "取消";
            cancel.Location = new Point(469, 295);
            cancel.BackColor = Color.FromArgb(254, 214, 244);
            cancel.FlatStyle = FlatStyle.Popup;
            cancel.Click += new System.EventHandler(cancel_Click);
            this.Controls.Add(confirm);
            this.Controls.Add(cancel);
        }

        private void confirm_Click(object sender,EventArgs e)
        {
            if (int.Parse(textBox_DramaLocalProgress.Text) > int.Parse(textBox_DramaTotalProgress.Text)) throw new IndexOutOfRangeException();
            string newDramaInfo = textBox_DramaName.Text + "#"+     //字符串合成
            textBox_DramaTotalProgress.Text +"#"+
            textBox_DramaLocalProgress.Text +"#"+
            pictureBox_DramaPic.ImageLocation+"#"+
            textbox_Url.Text;

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
