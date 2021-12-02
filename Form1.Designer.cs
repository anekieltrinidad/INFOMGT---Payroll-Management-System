
namespace PayrollSystem
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridEmployee = new System.Windows.Forms.DataGridView();
            this.btnGetEmployee = new System.Windows.Forms.Button();
            this.txtSearchEmployee = new System.Windows.Forms.TextBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnSearchEmployee = new System.Windows.Forms.Button();
            this.txtRefresh = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEmployee)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridEmployee
            // 
            this.dataGridEmployee.BackgroundColor = System.Drawing.Color.Gray;
            this.dataGridEmployee.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridEmployee.Location = new System.Drawing.Point(13, 73);
            this.dataGridEmployee.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridEmployee.MultiSelect = false;
            this.dataGridEmployee.Name = "dataGridEmployee";
            this.dataGridEmployee.ReadOnly = true;
            this.dataGridEmployee.RowHeadersWidth = 51;
            this.dataGridEmployee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridEmployee.Size = new System.Drawing.Size(589, 361);
            this.dataGridEmployee.TabIndex = 0;
            this.dataGridEmployee.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridEmployee_CellClick);
            this.dataGridEmployee.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnGetEmployee
            // 
            this.btnGetEmployee.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnGetEmployee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnGetEmployee.FlatAppearance.BorderColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnGetEmployee.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnGetEmployee.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetEmployee.ForeColor = System.Drawing.Color.Black;
            this.btnGetEmployee.Location = new System.Drawing.Point(115, 85);
            this.btnGetEmployee.Margin = new System.Windows.Forms.Padding(4);
            this.btnGetEmployee.Name = "btnGetEmployee";
            this.btnGetEmployee.Size = new System.Drawing.Size(195, 37);
            this.btnGetEmployee.TabIndex = 1;
            this.btnGetEmployee.Text = "Manage Employee";
            this.btnGetEmployee.UseVisualStyleBackColor = false;
            this.btnGetEmployee.Click += new System.EventHandler(this.btnGetEmployee_Click);
            // 
            // txtSearchEmployee
            // 
            this.txtSearchEmployee.BackColor = System.Drawing.Color.LavenderBlush;
            this.txtSearchEmployee.Location = new System.Drawing.Point(207, 37);
            this.txtSearchEmployee.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearchEmployee.Name = "txtSearchEmployee";
            this.txtSearchEmployee.Size = new System.Drawing.Size(236, 22);
            this.txtSearchEmployee.TabIndex = 2;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.LightCoral;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(852, 406);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(100, 28);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnSearchEmployee
            // 
            this.btnSearchEmployee.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchEmployee.Location = new System.Drawing.Point(464, 35);
            this.btnSearchEmployee.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearchEmployee.Name = "btnSearchEmployee";
            this.btnSearchEmployee.Size = new System.Drawing.Size(116, 28);
            this.btnSearchEmployee.TabIndex = 5;
            this.btnSearchEmployee.Text = "Search";
            this.btnSearchEmployee.UseVisualStyleBackColor = true;
            this.btnSearchEmployee.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtRefresh
            // 
            this.txtRefresh.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.txtRefresh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRefresh.Location = new System.Drawing.Point(62, 36);
            this.txtRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.txtRefresh.Name = "txtRefresh";
            this.txtRefresh.Size = new System.Drawing.Size(204, 37);
            this.txtRefresh.TabIndex = 6;
            this.txtRefresh.Text = "Show All Employees";
            this.txtRefresh.UseVisualStyleBackColor = false;
            this.txtRefresh.Click += new System.EventHandler(this.txtRefresh_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(178, 40);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(132, 22);
            this.textBox1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Employee ID Selected:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Search Employee By ID";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGetEmployee);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(618, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(334, 149);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtRefresh);
            this.groupBox2.Location = new System.Drawing.Point(618, 228);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(334, 104);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(971, 470);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSearchEmployee);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.txtSearchEmployee);
            this.Controls.Add(this.dataGridEmployee);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Employee Records";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEmployee)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridEmployee;
        private System.Windows.Forms.Button btnGetEmployee;
        private System.Windows.Forms.TextBox txtSearchEmployee;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnSearchEmployee;
        private System.Windows.Forms.Button txtRefresh;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

