
namespace Project
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.LinkLabel();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.tbxPass = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username:";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password:";
            // 
            // btnUpdate
            // 
            this.btnUpdate.AutoSize = true;
            this.btnUpdate.Location = new System.Drawing.Point(87, 273);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(95, 15);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.TabStop = true;
            this.btnUpdate.Text = "Forgot Password";
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(113, 37);
            this.tbxName.Name = "tbxName";
            this.tbxName.PlaceholderText = "Enter your Username";
            this.tbxName.Size = new System.Drawing.Size(122, 23);
            this.tbxName.TabIndex = 3;
            // 
            // tbxPass
            // 
            this.tbxPass.Location = new System.Drawing.Point(113, 80);
            this.tbxPass.Name = "tbxPass";
            this.tbxPass.PlaceholderText = "Enter your Password";
            this.tbxPass.Size = new System.Drawing.Size(122, 23);
            this.tbxPass.TabIndex = 4;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(50, 119);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(185, 84);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Log In";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(73, 222);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(130, 23);
            this.btnNew.TabIndex = 6;
            this.btnNew.Text = "Create new user";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 340);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.tbxPass);
            this.Controls.Add(this.tbxName);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Log In";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel btnUpdate;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.TextBox tbxPass;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnNew;
    }
}

