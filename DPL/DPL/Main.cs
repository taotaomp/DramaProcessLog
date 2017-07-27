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
        private void frmConfigure()
        {
            this.StartPosition = FormStartPosition.CenterParent;        
            this.MaximizeBox = false;                                   //取消最大化功能
        }

    }
}
