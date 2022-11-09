using KeyAuth;
using Support_Tool.Classes;
using Support_Tool.UI;
using System.Windows.Forms;

namespace Support_Tool
{
    //Utilities, e.g, PROPER defender control, redist, windows updates, windows services, hotfixes, remote desktop
    //Payment providers
    //Proper HWID lister
    public partial class Login_Form : Form
    {
        #region prerequesties
        Register register = new Register();
        public static api KeyAuthApp = new api(
            name: "example",
            ownerid: "JjPMBVlIOd",
            secret: "db40d586f4b189e04e5c18c3c94b7e72221be3f6551995adc05236948d1762bc",
            version: "1.0"
            );
        #endregion


        public Login_Form()
        {
            InitializeComponent();
            Program.Init();
        }

        private void register_Btn_Click(object sender, System.EventArgs e)
        {
            Hide();
            register.Show();
        }
    }
}
