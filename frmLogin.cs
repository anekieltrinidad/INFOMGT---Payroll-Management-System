using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayrollSystem
{
    public partial class frmLogin : Form
    {
        PayrollSystemEntities dbe = new PayrollSystemEntities();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void llblRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CheckID frmCheck = new CheckID();
            frmCheck.Show();
            this.Hide();
        }
        private void ClearFields()
        {
            foreach (var item in this.Controls)
            {
                if (item.GetType() == typeof(TextBox))
                {
                    ((TextBox)item).Clear();
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string uname = tbUname.Text, pword = tbPword.Text;
            var result = dbe.uspGetLoginCredentials(uname, pword).FirstOrDefault();
            if(result != null)
            {
                MessageBox.Show("Login Successful", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form1 f1 = new Form1();
                f1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username or Password is incorrect", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            ClearFields();
        }
    }
}
