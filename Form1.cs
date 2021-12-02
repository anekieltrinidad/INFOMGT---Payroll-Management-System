using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PayrollSystem
{
    public partial class Form1 : Form
    {
        PayrollSystemEntities dbe;
        
        int tempID = 0;
        int empID = 0;
        public Form1()
        {
            InitializeComponent();
            dbe = new PayrollSystemEntities();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            refreshView();
            currentSelected();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridEmployee.SelectedRows[0].Cells[0].Value.ToString();
        }

        private void btnGetEmployee_Click(object sender, EventArgs e)
        {
            empID = (int)dataGridEmployee.SelectedRows[0].Cells[0].Value;
            MessageBox.Show("Currently Selected Employee ID: " + empID, "Currently Selected Employee",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            Form2 f2 = new Form2(empID);
            f2.Show();
            this.Hide();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            bool num = Int32.TryParse(txtSearchEmployee.Text, out tempID);
            if (txtSearchEmployee.Text != "" && num)
            {
                dataGridEmployee.DataSource = dbe.uspGetEmployeesRecords(Convert.ToInt32(tempID)).ToList();
            }
            else
            {
                refreshView();
            }
        }

        private void refreshView()
        {
            dataGridEmployee.DataSource = dbe.viewEmployeeRecords.ToList();
        }

        private void dataGridEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            currentSelected();
        }

        private void txtRefresh_Click(object sender, EventArgs e)
        {
            refreshView();
        }

        private void currentSelected()
        {
            textBox1.Text = dataGridEmployee.SelectedRows[0].Cells[0].Value.ToString();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Form frmLogin = Application.OpenForms["frmLogin"];
            frmLogin.Show();
            this.Close();
        }
    }
}
