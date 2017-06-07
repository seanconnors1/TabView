using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TabView
{
    public partial class login : Form
    {

        public string UserName { get; set; }

        public login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((loginTextBox.Text == "") || (passwordTextBox.Text == ""))
            {
                MessageBox.Show("Invalid login. Please fill out form.");
                DialogResult = DialogResult.Cancel;
            }else
            {
                UserName = loginTextBox.Text;
                DialogResult = DialogResult.OK;
                this.Hide();
            }
        }
    }
}
