
namespace PayrollSystem
{
    partial class frmLogin
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
            this.tbUname = new System.Windows.Forms.TextBox();
            this.llblRegister = new System.Windows.Forms.LinkLabel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbPword = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbUname
            // 
            this.tbUname.Location = new System.Drawing.Point(6, 21);
            this.tbUname.Name = "tbUname";
            this.tbUname.Size = new System.Drawing.Size(281, 22);
            this.tbUname.TabIndex = 0;
            // 
            // llblRegister
            // 
            this.llblRegister.AutoSize = true;
            this.llblRegister.Location = new System.Drawing.Point(34, 187);
            this.llblRegister.Name = "llblRegister";
            this.llblRegister.Size = new System.Drawing.Size(61, 17);
            this.llblRegister.TabIndex = 3;
            this.llblRegister.TabStop = true;
            this.llblRegister.Text = "Register";
            this.llblRegister.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblRegister_LinkClicked);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnLogin.Location = new System.Drawing.Point(255, 179);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 28);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbUname);
            this.groupBox1.Location = new System.Drawing.Point(37, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(293, 55);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Username:";
            // 
            // tbPword
            // 
            this.tbPword.Location = new System.Drawing.Point(6, 19);
            this.tbPword.Name = "tbPword";
            this.tbPword.PasswordChar = '*';
            this.tbPword.Size = new System.Drawing.Size(281, 22);
            this.tbPword.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbPword);
            this.groupBox2.Location = new System.Drawing.Point(37, 93);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(293, 55);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Password:";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.LightCoral;
            this.btnClear.Location = new System.Drawing.Point(165, 179);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 28);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 242);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.llblRegister);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmLogin";
            this.Text = "Login";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbUname;
        private System.Windows.Forms.LinkLabel llblRegister;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbPword;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnClear;
    }
}