using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Business_Manager_Pro
{
    public partial class WelcomeScreen : Form
    {
        Thread MyNewThread;

        public WelcomeScreen()
        {
            InitializeComponent();
        }

        private void WelcomeScreen_Load(object sender, EventArgs e)
        {
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 4000;
            progressBar1.Step = 100;
            progressBar1.Value = 0;
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value != 4000)
            {
                progressBar1.PerformStep();
            }
            else
            {
                timer1.Enabled = false;
                Close();
                MyNewThread = new Thread(ShowMainInterface);
                MyNewThread.SetApartmentState(ApartmentState.STA);
                MyNewThread.Start();
                return;
            }
        }

        private void ShowMainInterface(object obj)
        {
            Application.Run(new MainInterface());
        }
    }
}
