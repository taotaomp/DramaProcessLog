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
