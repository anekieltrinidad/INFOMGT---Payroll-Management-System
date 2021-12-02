
namespace PayrollSystem
{
    partial class CheckID
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
            this.llblBack = new System.Windows.Forms.LinkLabel();
            this.btnCheck = new System.Windows.Forms.Button();
            this.tbEmpID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // llblBack
            // 
            this.llblBack.AutoSize = true;
            this.llblBack.Location = new System.Drawing.Point(33, 109);
            this.llblBack.Name = "llblBack";
            this.llblBack.Size = new System.Drawing.Size(39, 17);
            this.llblBack.TabIndex = 0;
            this.llblBack.TabStop = true;
            this.llblBack.Text = "Back";
            this.llblBack.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblBack_LinkClicked);
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(196, 106);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(75, 23);
            this.btnCheck.TabIndex = 1;
            this.btnCheck.Text = "Check ID";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // tbEmpID
            // 
            this.tbEmpID.Location = new System.Drawing.Point(36, 56);
            this.tbEmpID.Name = "tbEmpID";
            this.tbEmpID.Size = new System.Drawing.Size(235, 22);
            this.tbEmpID.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter Employee ID:";
            // 
            // CheckID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 150);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbEmpID);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.llblBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CheckID";
            this.Text = "EmployeeID";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel llblBack;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.TextBox tbEmpID;
        private System.Windows.Forms.Label label1;
    }
}