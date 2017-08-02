namespace DPL
{
    partial class singleDramaInfoShow
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label_DramaName = new System.Windows.Forms.Label();
            this.textBox_DramaName = new System.Windows.Forms.TextBox();
            this.pictureBox_DramaPic = new System.Windows.Forms.PictureBox();
            this.label_DramaTotalProgress = new System.Windows.Forms.Label();
            this.textBox_DramaTotalProgress = new System.Windows.Forms.TextBox();
            this.label_DramaLocalProgress = new System.Windows.Forms.Label();
            this.textBox_DramaLocalProgress = new System.Windows.Forms.TextBox();
            this.progressBar_Drama = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_DramaPic)).BeginInit();
            this.SuspendLayout();
            // 
            // label_DramaName
            // 
            this.label_DramaName.AutoSize = true;
            this.label_DramaName.Font = new System.Drawing.Font("华文仿宋", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_DramaName.Location = new System.Drawing.Point(32, 62);
            this.label_DramaName.Name = "label_DramaName";
            this.label_DramaName.Size = new System.Drawing.Size(70, 21);
            this.label_DramaName.TabIndex = 0;
            this.label_DramaName.Text = "番剧名";
            // 
            // textBox_DramaName
            // 
            this.textBox_DramaName.BackColor = System.Drawing.Color.White;
            this.textBox_DramaName.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_DramaName.Location = new System.Drawing.Point(108, 62);
            this.textBox_DramaName.Name = "textBox_DramaName";
            this.textBox_DramaName.Size = new System.Drawing.Size(183, 26);
            this.textBox_DramaName.TabIndex = 0;
            // 
            // pictureBox_DramaPic
            // 
            this.pictureBox_DramaPic.BackColor = System.Drawing.Color.White;
            this.pictureBox_DramaPic.Location = new System.Drawing.Point(380, 21);
            this.pictureBox_DramaPic.Name = "pictureBox_DramaPic";
            this.pictureBox_DramaPic.Size = new System.Drawing.Size(135, 161);
            this.pictureBox_DramaPic.TabIndex = 2;
            this.pictureBox_DramaPic.TabStop = false;
            // 
            // label_DramaTotalProgress
            // 
            this.label_DramaTotalProgress.AutoSize = true;
            this.label_DramaTotalProgress.Font = new System.Drawing.Font("华文仿宋", 12F, System.Drawing.FontStyle.Bold);
            this.label_DramaTotalProgress.Location = new System.Drawing.Point(33, 100);
            this.label_DramaTotalProgress.Name = "label_DramaTotalProgress";
            this.label_DramaTotalProgress.Size = new System.Drawing.Size(93, 18);
            this.label_DramaTotalProgress.TabIndex = 0;
            this.label_DramaTotalProgress.Text = "番剧总进度";
            // 
            // textBox_DramaTotalProgress
            // 
            this.textBox_DramaTotalProgress.Font = new System.Drawing.Font("宋体", 12F);
            this.textBox_DramaTotalProgress.Location = new System.Drawing.Point(132, 97);
            this.textBox_DramaTotalProgress.Name = "textBox_DramaTotalProgress";
            this.textBox_DramaTotalProgress.Size = new System.Drawing.Size(55, 26);
            this.textBox_DramaTotalProgress.TabIndex = 1;
            // 
            // label_DramaLocalProgress
            // 
            this.label_DramaLocalProgress.AutoSize = true;
            this.label_DramaLocalProgress.Font = new System.Drawing.Font("华文仿宋", 12F, System.Drawing.FontStyle.Bold);
            this.label_DramaLocalProgress.Location = new System.Drawing.Point(33, 266);
            this.label_DramaLocalProgress.Name = "label_DramaLocalProgress";
            this.label_DramaLocalProgress.Size = new System.Drawing.Size(110, 18);
            this.label_DramaLocalProgress.TabIndex = 0;
            this.label_DramaLocalProgress.Text = "番剧当前进度";
            // 
            // textBox_DramaLocalProgress
            // 
            this.textBox_DramaLocalProgress.Font = new System.Drawing.Font("宋体", 12F);
            this.textBox_DramaLocalProgress.Location = new System.Drawing.Point(149, 263);
            this.textBox_DramaLocalProgress.Name = "textBox_DramaLocalProgress";
            this.textBox_DramaLocalProgress.Size = new System.Drawing.Size(60, 26);
            this.textBox_DramaLocalProgress.TabIndex = 2;
            // 
            // progressBar_Drama
            // 
            this.progressBar_Drama.Location = new System.Drawing.Point(34, 292);
            this.progressBar_Drama.Name = "progressBar_Drama";
            this.progressBar_Drama.Size = new System.Drawing.Size(371, 19);
            this.progressBar_Drama.TabIndex = 3;
            // 
            // singleDramaInfoShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.progressBar_Drama);
            this.Controls.Add(this.pictureBox_DramaPic);
            this.Controls.Add(this.textBox_DramaLocalProgress);
            this.Controls.Add(this.label_DramaLocalProgress);
            this.Controls.Add(this.textBox_DramaTotalProgress);
            this.Controls.Add(this.label_DramaTotalProgress);
            this.Controls.Add(this.textBox_DramaName);
            this.Controls.Add(this.label_DramaName);
            this.Name = "singleDramaInfoShow";
            this.Size = new System.Drawing.Size(610, 386);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_DramaPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_DramaName;
        private System.Windows.Forms.TextBox textBox_DramaName;
        private System.Windows.Forms.PictureBox pictureBox_DramaPic;
        private System.Windows.Forms.Label label_DramaTotalProgress;
        private System.Windows.Forms.TextBox textBox_DramaTotalProgress;
        private System.Windows.Forms.Label label_DramaLocalProgress;
        private System.Windows.Forms.TextBox textBox_DramaLocalProgress;
        private System.Windows.Forms.ProgressBar progressBar_Drama;
    }
}
