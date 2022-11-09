using System;
using System.Windows.Forms;

namespace Support_Tool.UI
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            Login_Form login = new Login_Form();
            Close();
            login.Show();
        }
    }
}
