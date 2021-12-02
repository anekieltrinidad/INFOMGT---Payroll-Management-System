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
    public partial class Form2 : Form
    {
        PayrollSystemEntities dbe = new PayrollSystemEntities();
        int empID = 0;
        int salaryID = 0;
        public Form2(int empID)
        {
            this.empID = empID;
            InitializeComponent();
        }
        private void btnSearchSalary_Click(object sender, EventArgs e)
        {
            // dataGridSalary.DataSource = 
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            textBox1.Text = empID.ToString();
            refreshView();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form f1 = Application.OpenForms["Form1"];
            f1.Show();
            this.Close();
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            bool num1 = decimal.TryParse(txtDailyRate.Text, out decimal dailyRate);
            bool num2 = Int32.TryParse(txtWorkDays.Text, out int workDays);
            DateTime forMonth = mcForMonthOf.SelectionStart;
            bool status = false;
            if (num1 && num2)
            {
                if(cbStatus.SelectedItem.ToString() == "Released")
                {
                    status = true;
                }
                dbe.uspInsertSalary(empID, dailyRate, workDays, forMonth, status);
                refreshView();
            }
        }

        private void dataGridSalary_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.salaryID = (int)dataGridSalary.SelectedRows[0].Cells[0].Value;
            txtDailyRate.Text = dataGridSalary.SelectedRows[0].Cells[2].Value.ToString();
            txtWorkDays.Text = dataGridSalary.SelectedRows[0].Cells[3].Value.ToString();
            cbStatus.Text = dataGridSalary.SelectedRows[0].Cells[9].Value.ToString();
            MessageBox.Show("Currently Selected Salary ID: " + this.salaryID, "Currently Selected Record",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void refreshView()
        {
            dataGridSalary.DataSource = dbe.uspGetSalaryRecordsByID1(empID).ToList();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            bool num1 = decimal.TryParse(txtDailyRate.Text, out decimal dailyRate);
            bool num2 = Int32.TryParse(txtWorkDays.Text, out int workDays);
            DateTime forMonth = mcForMonthOf.SelectionStart;
            bool status = false;
            if (num1 && num2)
            {
                if (cbStatus.SelectedItem.ToString() == "Released")
                {
                    status = true;
                }
                dbe.uspUpdateSalary(this.salaryID, empID, dailyRate, workDays, forMonth, status);
                refreshView();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            dbe.uspDeleteSalary(salaryID);
            refreshView();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Form frmLogin = Application.OpenForms["frmLogin"];
            Form f1 = Application.OpenForms["Form1"];
            frmLogin.Show();
            f1.Close();
            this.Close();
        }
    }
}
