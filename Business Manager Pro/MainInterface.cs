using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Business_Manager_Pro
{
    public partial class MainInterface : Form
    {
        public MainInterface()
        {
            InitializeComponent();
        }

        private void MainInterface_Load(object sender, EventArgs e)
        {
            
        }

        private void bnclose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bninfo_Click(object sender, EventArgs e)
        {
            AboutBusinessManager infoform = new AboutBusinessManager();
            infoform.ShowDialog();
        }
    }
}
