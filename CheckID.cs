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
    public partial class CheckID : Form
    {
        PayrollSystemEntities dbe = new PayrollSystemEntities();
        public CheckID()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            bool num = Int32.TryParse(tbEmpID.Text, out int empID);
            if (num)
            {
                string dep = dbe.uspCheckEmployeeDepartment(empID).FirstOrDefault();
                if (dep == "Human Resources")
                {
                    frmRegister frmReg = new frmRegister(empID);
                    frmReg.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Sorry, but you are restricted from having a login in this application.", "Restricted Access", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Please make sure that you only enter your Employee ID.", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void llblBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form frmLogin = Application.OpenForms["frmLogin"];
            frmLogin.Show();
            this.Close();
        }
    }
}
