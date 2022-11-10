using System;
using System.Windows.Forms;

namespace Support_Tool.UI
{
    public partial class Register : Form
    {
        public Form LOGIN_REFERENCE { get; set; }
        public Register()
        {
            InitializeComponent();
        }
        public static Form HANDLE()
        {
            return ActiveForm;
        }
        private void back_Btn_Click(object sender, EventArgs e)
        {
            LOGIN_REFERENCE.Show();
            Close();
        }
    }
}
