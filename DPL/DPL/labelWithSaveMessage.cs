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
    public partial class labelWithSaveMessage : UserControl
    {
        public labelWithSaveMessage()
        {
            InitializeComponent();
            dramaName = new Label();
            dramaName.AutoSize = true;
            dramaName.Location = new Point(0, (this.Height / 2));
            dramaName.Font = new Font("仿宋", 12,FontStyle.Bold);
            dramaName.BackColor = Color.FromArgb(0, 240, 240, 240);
            dramaName.Cursor = Cursors.Arrow;
            this.Controls.Add(dramaName);
        }

        String dramaInfo;
        public string DramaInfo
        {
            get
            {
                return dramaInfo;
            }

            set
            {
                dramaInfo = value;
            }
        }

        Label dramaName;
        public Label DramaName
        {
            get
            {
                return dramaName;
            }

            set
            {
                dramaName = value;
            }
        }
    }
}
