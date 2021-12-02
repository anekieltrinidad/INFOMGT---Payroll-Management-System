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
    public partial class frmRegister : Form
    {
        PayrollSystemEntities dbe = new PayrollSystemEntities();
        int empID = 0;
        public frmRegister(int empID)
        {
            InitializeComponent();
            this.empID = empID;
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

        private void llblCancel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            back();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string uname = tbUname.Text, pass = tbPass.Text, conPass = tbConPass.Text;
            if(pass == conPass)
            {
                dbe.uspRegisterUser(empID, uname, pass);
                MessageBox.Show("User login is successfully registered!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                back();
            }
            else
            {
                MessageBox.Show("Password and Confirm Password does not match", "Does not match", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
         private void back()
        {
            Form frmLogin = Application.OpenForms["frmLogin"];
            Form frmCheck = Application.OpenForms["CheckID"];
            frmLogin.Show();
            this.Close();
            frmCheck.Close();
        }
    }
}
