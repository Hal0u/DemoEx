using System;
using System.Windows.Forms;

namespace Demo
{
    public partial class Login : Form
    {
        UserController control;

        public Login(UserController control)
        {
            this.control = control;
            InitializeComponent();
        }

        public bool isLoggined = false;

        private void button1_Click(object sender, EventArgs e)
        {
            isLoggined = control.Authenticate(textBox1.Text,textBox2.Text);
            if(isLoggined )
            {
                Close();
            }
        }
    }
}
