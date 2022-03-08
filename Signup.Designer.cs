namespace ExpenseTracker2
{
    partial class Signup
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
            this.SignupButton = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtConfirmPass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ReturnLogin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SignupButton
            // 
            this.SignupButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignupButton.Location = new System.Drawing.Point(153, 170);
            this.SignupButton.Name = "SignupButton";
            this.SignupButton.Size = new System.Drawing.Size(110, 29);
            this.SignupButton.TabIndex = 0;
            this.SignupButton.Text = "Signup";
            this.SignupButton.UseVisualStyleBackColor = true;
            this.SignupButton.Click += new System.EventHandler(this.SignupButton_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(200, 48);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(132, 20);
            this.txtName.TabIndex = 1;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(200, 88);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(132, 20);
            this.txtPass.TabIndex = 2;
            // 
            // txtConfirmPass
            // 
            this.txtConfirmPass.Location = new System.Drawing.Point(200, 130);
            this.txtConfirmPass.Name = "txtConfirmPass";
            this.txtConfirmPass.Size = new System.Drawing.Size(132, 20);
            this.txtConfirmPass.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(112, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(59, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Confirm Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(117, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Password:";
            // 
            // ReturnLogin
            // 
            this.ReturnLogin.AutoSize = true;
            this.ReturnLogin.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturnLogin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ReturnLogin.Location = new System.Drawing.Point(157, 216);
            this.ReturnLogin.Name = "ReturnLogin";
            this.ReturnLogin.Size = new System.Drawing.Size(106, 18);
            this.ReturnLogin.TabIndex = 7;
            this.ReturnLogin.Text = "Return to Login";
            this.ReturnLogin.Click += new System.EventHandler(this.ReturnLogin_Click);
            // 
            // Signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(409, 243);
            this.Controls.Add(this.ReturnLogin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtConfirmPass);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.SignupButton);
            this.Name = "Signup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Signup";
            this.Load += new System.EventHandler(this.Signup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SignupButton;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtConfirmPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label ReturnLogin;
    }
}