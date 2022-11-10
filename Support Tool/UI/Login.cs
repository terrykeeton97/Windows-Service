using KeyAuth;
using Support_Tool.UI;
using System;
using System.Windows.Forms;

namespace Support_Tool
{
    //Utilities, e.g, PROPER defender control, redist, windows updates, windows services, hotfixes, remote desktop
    //Payment providers
    //Proper HWID lister
    public partial class Login_Form : Form
    {
        #region prerequesties
        public static api KeyAuthApp = new api(
            name: "example",
            ownerid: "JjPMBVlIOd",
            secret: "db40d586f4b189e04e5c18c3c94b7e72221be3f6551995adc05236948d1762bc",
            version: "1.0"
            );
        #endregion

        public static Form HANDLE()
        {
            return ActiveForm;
        }
        public Login_Form()
        {
            InitializeComponent();
            Program.Init();
        }
        private void register_Btn_Click(object sender, System.EventArgs e)
        {
            Register Register = new Register();
            Register.LOGIN_REFERENCE = this;
            Visible = false;
            Register.Show();
        }

        private void control_closeBox_Click(object sender, System.EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
