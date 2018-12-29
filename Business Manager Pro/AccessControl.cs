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
    public partial class AccessControl : Form
    {
        public AccessControl()
        {
            InitializeComponent();
        }

        private void bnlogin_Click(object sender, EventArgs e)
        {
            Thread MyThread;
            if (txtusername.Text=="")
            {
                string usernamemessage = "Please enter your username first!";
                MessageBox.Show(usernamemessage);
                return;
            }

            if (txtpassword.Text=="")
            {
                var passwordmessage = "Please enter your password first!";
                MessageBox.Show(passwordmessage);
                return;
            }

            DataClasses1DataContext db = new DataClasses1DataContext();
            IQueryable<user> CheckUser = from urec in db.users where urec.username == txtusername.Text && urec.password == txtpassword.Text select urec;

            int usercount = CheckUser.Count();
            if (usercount == 0)
            {
                var passwordmessage = "You have entered an invalid username or password!";
                MessageBoxButtons MessageButtons = MessageBoxButtons.OK;
                MessageBoxIcon MessageIcon = MessageBoxIcon.Stop;
                var MessageTitle = "Access Denied!";
                MessageBox.Show(passwordmessage,MessageTitle,MessageButtons,MessageIcon);
                return;
            }

            MyThread = new Thread(ShowInterface);
            MyThread.SetApartmentState(ApartmentState.STA);
            MyThread.Start();
            Close();
        }

        private void ShowInterface(object obj)
        {
            Application.Run(new MainInterface());
        }

        private void bncancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
    

}
