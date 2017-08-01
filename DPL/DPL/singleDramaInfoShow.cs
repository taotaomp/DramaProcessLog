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
        public singleDramaInfoShow(String DramaInfo)
        {
            InitializeComponent();
            String[] temp = DramaInfo.Split('#');
            textBox_DramaName.Text = temp[0];
            textBox_DramaTotalProgresss.Text = temp[1];
            textBox_DramaLocalProgress.Text = temp[2];
            pictureBox_DramaPic.ImageLocation = temp[3];
            progressBar_Drama.Maximum = Convert.ToInt32(temp[1]);
            progressBar_Drama.Value = Convert.ToInt32(temp[2]);
        }

        private void singleDramaInfoShow_Load(object sender, EventArgs e)
        {
            textBox_DramaLocalProgress.ReadOnly = true;
            textBox_DramaName.ReadOnly = true;
            textBox_DramaTotalProgresss.ReadOnly = true;
        }
    }
}
