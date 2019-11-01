namespace Global_Hyper
{
    partial class PasswordRecovery
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.lblChangePassword = new System.Windows.Forms.Label();
            this.btnValidate = new System.Windows.Forms.Button();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.txtSuperPassword = new System.Windows.Forms.TextBox();
            this.btnNewPassword = new System.Windows.Forms.Label();
            this.lblInitialPassword = new System.Windows.Forms.Label();
            this.txtEmpID = new System.Windows.Forms.TextBox();
            this.lblEmpID = new System.Windows.Forms.Label();
            this.ValidateConfirmPass = new System.Windows.Forms.Label();
            this.ValidateNewPass = new System.Windows.Forms.Label();
            this.ValidateSupervisorPass = new System.Windows.Forms.Label();
            this.ValidateEmpNumber = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(168, 239);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(110, 39);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(34, 202);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(43, 13);
            this.lblResult.TabIndex = 31;
            this.lblResult.Text = "Result";
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Location = new System.Drawing.Point(156, 129);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new System.Drawing.Size(140, 20);
            this.txtConfirmPassword.TabIndex = 2;
            this.txtConfirmPassword.TextChanged += new System.EventHandler(this.txtConfirmPassword_TextChanged);
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmPassword.Location = new System.Drawing.Point(18, 136);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(107, 13);
            this.lblConfirmPassword.TabIndex = 30;
            this.lblConfirmPassword.Text = "Confirm Password";
            // 
            // lblChangePassword
            // 
            this.lblChangePassword.AutoSize = true;
            this.lblChangePassword.BackColor = System.Drawing.Color.Aqua;
            this.lblChangePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChangePassword.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblChangePassword.Location = new System.Drawing.Point(12, 21);
            this.lblChangePassword.Name = "lblChangePassword";
            this.lblChangePassword.Size = new System.Drawing.Size(293, 13);
            this.lblChangePassword.TabIndex = 29;
            this.lblChangePassword.Text = "ENTER YOUR OLD AND NEW PASSWORD HERE";
            // 
            // btnValidate
            // 
            this.btnValidate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValidate.Location = new System.Drawing.Point(37, 239);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Size = new System.Drawing.Size(110, 39);
            this.btnValidate.TabIndex = 4;
            this.btnValidate.Text = "Validate";
            this.btnValidate.UseVisualStyleBackColor = true;
            this.btnValidate.Click += new System.EventHandler(this.btnValidate_Click);
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Location = new System.Drawing.Point(156, 92);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(140, 20);
            this.txtNewPassword.TabIndex = 1;
            this.txtNewPassword.TextChanged += new System.EventHandler(this.txtNewPassword_TextChanged);
            // 
            // txtSuperPassword
            // 
            this.txtSuperPassword.Location = new System.Drawing.Point(156, 52);
            this.txtSuperPassword.Name = "txtSuperPassword";
            this.txtSuperPassword.Size = new System.Drawing.Size(140, 20);
            this.txtSuperPassword.TabIndex = 0;
            this.txtSuperPassword.UseSystemPasswordChar = true;
            this.txtSuperPassword.TextChanged += new System.EventHandler(this.txtSuperPassword_TextChanged);
            // 
            // btnNewPassword
            // 
            this.btnNewPassword.AutoSize = true;
            this.btnNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewPassword.Location = new System.Drawing.Point(18, 99);
            this.btnNewPassword.Name = "btnNewPassword";
            this.btnNewPassword.Size = new System.Drawing.Size(90, 13);
            this.btnNewPassword.TabIndex = 28;
            this.btnNewPassword.Text = "New Password";
            // 
            // lblInitialPassword
            // 
            this.lblInitialPassword.AutoSize = true;
            this.lblInitialPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInitialPassword.Location = new System.Drawing.Point(18, 59);
            this.lblInitialPassword.Name = "lblInitialPassword";
            this.lblInitialPassword.Size = new System.Drawing.Size(125, 13);
            this.lblInitialPassword.TabIndex = 27;
            this.lblInitialPassword.Text = "Supervisor Password";
            // 
            // txtEmpID
            // 
            this.txtEmpID.Location = new System.Drawing.Point(156, 165);
            this.txtEmpID.Name = "txtEmpID";
            this.txtEmpID.Size = new System.Drawing.Size(140, 20);
            this.txtEmpID.TabIndex = 3;
            this.txtEmpID.Text = "0";
            this.txtEmpID.TextChanged += new System.EventHandler(this.txtEmpID_TextChanged);
            this.txtEmpID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmpID_KeyPress);
            // 
            // lblEmpID
            // 
            this.lblEmpID.AutoSize = true;
            this.lblEmpID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpID.Location = new System.Drawing.Point(18, 172);
            this.lblEmpID.Name = "lblEmpID";
            this.lblEmpID.Size = new System.Drawing.Size(108, 13);
            this.lblEmpID.TabIndex = 33;
            this.lblEmpID.Text = "Employee Number";
            // 
            // ValidateConfirmPass
            // 
            this.ValidateConfirmPass.AutoSize = true;
            this.ValidateConfirmPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValidateConfirmPass.Location = new System.Drawing.Point(302, 132);
            this.ValidateConfirmPass.Name = "ValidateConfirmPass";
            this.ValidateConfirmPass.Size = new System.Drawing.Size(41, 13);
            this.ValidateConfirmPass.TabIndex = 34;
            this.ValidateConfirmPass.Text = "Good!";
            // 
            // ValidateNewPass
            // 
            this.ValidateNewPass.AutoSize = true;
            this.ValidateNewPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValidateNewPass.Location = new System.Drawing.Point(302, 95);
            this.ValidateNewPass.Name = "ValidateNewPass";
            this.ValidateNewPass.Size = new System.Drawing.Size(41, 13);
            this.ValidateNewPass.TabIndex = 35;
            this.ValidateNewPass.Text = "Good!";
            // 
            // ValidateSupervisorPass
            // 
            this.ValidateSupervisorPass.AutoSize = true;
            this.ValidateSupervisorPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValidateSupervisorPass.Location = new System.Drawing.Point(302, 55);
            this.ValidateSupervisorPass.Name = "ValidateSupervisorPass";
            this.ValidateSupervisorPass.Size = new System.Drawing.Size(41, 13);
            this.ValidateSupervisorPass.TabIndex = 36;
            this.ValidateSupervisorPass.Text = "Good!";
            // 
            // ValidateEmpNumber
            // 
            this.ValidateEmpNumber.AutoSize = true;
            this.ValidateEmpNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValidateEmpNumber.Location = new System.Drawing.Point(302, 168);
            this.ValidateEmpNumber.Name = "ValidateEmpNumber";
            this.ValidateEmpNumber.Size = new System.Drawing.Size(41, 13);
            this.ValidateEmpNumber.TabIndex = 37;
            this.ValidateEmpNumber.Text = "Good!";
            // 
            // PasswordRecovery
            // 
            this.AcceptButton = this.btnValidate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Aqua;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(373, 308);
            this.Controls.Add(this.ValidateEmpNumber);
            this.Controls.Add(this.ValidateSupervisorPass);
            this.Controls.Add(this.ValidateNewPass);
            this.Controls.Add(this.ValidateConfirmPass);
            this.Controls.Add(this.txtEmpID);
            this.Controls.Add(this.lblEmpID);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.lblConfirmPassword);
            this.Controls.Add(this.lblChangePassword);
            this.Controls.Add(this.btnValidate);
            this.Controls.Add(this.txtNewPassword);
            this.Controls.Add(this.txtSuperPassword);
            this.Controls.Add(this.btnNewPassword);
            this.Controls.Add(this.lblInitialPassword);
            this.Name = "PasswordRecovery";
            this.Text = "PasswordRecovery";
            this.Activated += new System.EventHandler(this.PasswordRecovery_Activated);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.Label lblChangePassword;
        private System.Windows.Forms.Button btnValidate;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.TextBox txtSuperPassword;
        private System.Windows.Forms.Label btnNewPassword;
        private System.Windows.Forms.Label lblInitialPassword;
        private System.Windows.Forms.TextBox txtEmpID;
        private System.Windows.Forms.Label lblEmpID;
        private System.Windows.Forms.Label ValidateConfirmPass;
        private System.Windows.Forms.Label ValidateNewPass;
        private System.Windows.Forms.Label ValidateSupervisorPass;
        private System.Windows.Forms.Label ValidateEmpNumber;

    }
}