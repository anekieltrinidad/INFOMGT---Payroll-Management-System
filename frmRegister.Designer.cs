
namespace PayrollSystem
{
    partial class frmRegister
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
            this.btnRegister = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbUname = new System.Windows.Forms.TextBox();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.tbConPass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.llblCancel = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(291, 300);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 27);
            this.btnRegister.TabIndex = 0;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbConPass);
            this.groupBox1.Controls.Add(this.tbPass);
            this.groupBox1.Controls.Add(this.tbUname);
            this.groupBox1.Location = new System.Drawing.Point(29, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(335, 223);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Register";
            // 
            // tbUname
            // 
            this.tbUname.Location = new System.Drawing.Point(70, 56);
            this.tbUname.Name = "tbUname";
            this.tbUname.Size = new System.Drawing.Size(218, 22);
            this.tbUname.TabIndex = 3;
            // 
            // tbPass
            // 
            this.tbPass.Location = new System.Drawing.Point(70, 111);
            this.tbPass.Name = "tbPass";
            this.tbPass.PasswordChar = '*';
            this.tbPass.Size = new System.Drawing.Size(218, 22);
            this.tbPass.TabIndex = 3;
            // 
            // tbConPass
            // 
            this.tbConPass.Location = new System.Drawing.Point(70, 164);
            this.tbConPass.Name = "tbConPass";
            this.tbConPass.PasswordChar = '*';
            this.tbConPass.Size = new System.Drawing.Size(218, 22);
            this.tbConPass.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Username:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Confirm Password:";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(196, 300);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 27);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // llblCancel
            // 
            this.llblCancel.AutoSize = true;
            this.llblCancel.Location = new System.Drawing.Point(28, 305);
            this.llblCancel.Name = "llblCancel";
            this.llblCancel.Size = new System.Drawing.Size(51, 17);
            this.llblCancel.TabIndex = 3;
            this.llblCancel.TabStop = true;
            this.llblCancel.Text = "Cancel";
            this.llblCancel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblCancel_LinkClicked);
            // 
            // frmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 357);
            this.Controls.Add(this.llblCancel);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnRegister);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmRegister";
            this.Text = "Register";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbConPass;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.TextBox tbUname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.LinkLabel llblCancel;
    }
}