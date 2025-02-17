using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class InfoForm : Form
    {
        public InfoForm()
        {
            InitializeComponent();
        }

        private void InfoForm_Activated(object sender, EventArgs e)
        {
            MessageBox.Show("InfoForm Activated");
        }

        private void InfoForm_Deactivate(object sender, EventArgs e)
        {
            MessageBox.Show("InfoForm Deactivated");
        }
    }
}
