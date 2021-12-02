
namespace PayrollSystem
{
    partial class Form2
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
            this.dataGridSalary = new System.Windows.Forms.DataGridView();
            this.txtDailyRate = new System.Windows.Forms.TextBox();
            this.txtWorkDays = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCompute = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.txtSearchSalary = new System.Windows.Forms.TextBox();
            this.btnSearchSalary = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mcForMonthOf = new System.Windows.Forms.MonthCalendar();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSalary)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridSalary
            // 
            this.dataGridSalary.BackgroundColor = System.Drawing.Color.Gray;
            this.dataGridSalary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSalary.Location = new System.Drawing.Point(440, 72);
            this.dataGridSalary.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridSalary.MultiSelect = false;
            this.dataGridSalary.Name = "dataGridSalary";
            this.dataGridSalary.ReadOnly = true;
            this.dataGridSalary.RowHeadersWidth = 51;
            this.dataGridSalary.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridSalary.Size = new System.Drawing.Size(807, 464);
            this.dataGridSalary.TabIndex = 0;
            this.dataGridSalary.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridSalary_CellContentClick);
            // 
            // txtDailyRate
            // 
            this.txtDailyRate.BackColor = System.Drawing.Color.LavenderBlush;
            this.txtDailyRate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDailyRate.Location = new System.Drawing.Point(114, 325);
            this.txtDailyRate.Margin = new System.Windows.Forms.Padding(4);
            this.txtDailyRate.Name = "txtDailyRate";
            this.txtDailyRate.Size = new System.Drawing.Size(192, 29);
            this.txtDailyRate.TabIndex = 1;
            // 
            // txtWorkDays
            // 
            this.txtWorkDays.BackColor = System.Drawing.Color.LavenderBlush;
            this.txtWorkDays.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWorkDays.Location = new System.Drawing.Point(114, 371);
            this.txtWorkDays.Margin = new System.Windows.Forms.Padding(4);
            this.txtWorkDays.Name = "txtWorkDays";
            this.txtWorkDays.Size = new System.Drawing.Size(192, 29);
            this.txtWorkDays.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 328);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Daily Rate:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 374);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Work Days:";
            // 
            // btnCompute
            // 
            this.btnCompute.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnCompute.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompute.Location = new System.Drawing.Point(16, 24);
            this.btnCompute.Margin = new System.Windows.Forms.Padding(4);
            this.btnCompute.Name = "btnCompute";
            this.btnCompute.Size = new System.Drawing.Size(180, 34);
            this.btnCompute.TabIndex = 5;
            this.btnCompute.Text = "Insert";
            this.btnCompute.UseVisualStyleBackColor = false;
            this.btnCompute.Click += new System.EventHandler(this.btnCompute_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(16, 66);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(180, 34);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(16, 107);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(180, 34);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.LightCoral;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(1367, 508);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(100, 28);
            this.btnLogout.TabIndex = 11;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // txtSearchSalary
            // 
            this.txtSearchSalary.BackColor = System.Drawing.Color.LavenderBlush;
            this.txtSearchSalary.Location = new System.Drawing.Point(701, 32);
            this.txtSearchSalary.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearchSalary.Name = "txtSearchSalary";
            this.txtSearchSalary.Size = new System.Drawing.Size(224, 22);
            this.txtSearchSalary.TabIndex = 12;
            // 
            // btnSearchSalary
            // 
            this.btnSearchSalary.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchSalary.Location = new System.Drawing.Point(935, 29);
            this.btnSearchSalary.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearchSalary.Name = "btnSearchSalary";
            this.btnSearchSalary.Size = new System.Drawing.Size(121, 28);
            this.btnSearchSalary.TabIndex = 14;
            this.btnSearchSalary.Text = "Search";
            this.btnSearchSalary.UseVisualStyleBackColor = true;
            this.btnSearchSalary.Click += new System.EventHandler(this.btnSearchSalary_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(235, 88);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(529, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Search Salary By ID:";
            // 
            // mcForMonthOf
            // 
            this.mcForMonthOf.Location = new System.Drawing.Point(22, 104);
            this.mcForMonthOf.MaxSelectionCount = 1;
            this.mcForMonthOf.Name = "mcForMonthOf";
            this.mcForMonthOf.ShowWeekNumbers = true;
            this.mcForMonthOf.TabIndex = 17;
            // 
            // cbStatus
            // 
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "Pending",
            "Released"});
            this.cbStatus.Location = new System.Drawing.Point(114, 417);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(192, 24);
            this.cbStatus.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 416);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 23);
            this.label4.TabIndex = 19;
            this.label4.Text = "Status:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(47, 87);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 23);
            this.label5.TabIndex = 20;
            this.label5.Text = "Employee ID:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.btnCompute);
            this.groupBox1.Location = new System.Drawing.Point(1254, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(213, 424);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.mcForMonthOf);
            this.groupBox2.Controls.Add(this.txtDailyRate);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtWorkDays);
            this.groupBox2.Controls.Add(this.cbStatus);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(29, 66);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(391, 470);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 72);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(168, 23);
            this.label6.TabIndex = 23;
            this.label6.Text = "Prepared For Month:";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Silver;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(1254, 508);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 28);
            this.btnBack.TabIndex = 23;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(1500, 570);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnSearchSalary);
            this.Controls.Add(this.txtSearchSalary);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.dataGridSalary);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form2";
            this.Text = "Salary Records";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSalary)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridSalary;
        private System.Windows.Forms.TextBox txtDailyRate;
        private System.Windows.Forms.TextBox txtWorkDays;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCompute;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.TextBox txtSearchSalary;
        private System.Windows.Forms.Button btnSearchSalary;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MonthCalendar mcForMonthOf;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnBack;
    }
}