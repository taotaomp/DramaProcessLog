namespace DPL
{
    partial class MultiDramaContainer
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
            this.flowLayoutPanel_mulitDramaContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flowLayoutPanel_mulitDramaContainer
            // 
            this.flowLayoutPanel_mulitDramaContainer.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel_mulitDramaContainer.Name = "flowLayoutPanel_mulitDramaContainer";
            this.flowLayoutPanel_mulitDramaContainer.Size = new System.Drawing.Size(210, 386);
            this.flowLayoutPanel_mulitDramaContainer.TabIndex = 0;
            // 
            // MultiDramaContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.flowLayoutPanel_mulitDramaContainer);
            this.Name = "MultiDramaContainer";
            this.Size = new System.Drawing.Size(210, 386);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_mulitDramaContainer;
    }
}
