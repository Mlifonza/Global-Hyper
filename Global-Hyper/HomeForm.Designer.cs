namespace Global_Hyper
{
    partial class HomeForm
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
            this.gpbFunctions = new System.Windows.Forms.GroupBox();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnCashReport = new System.Windows.Forms.Button();
            this.btnCashToSupervisor = new System.Windows.Forms.Button();
            this.btnCashFromSuper = new System.Windows.Forms.Button();
            this.btnLogOff = new System.Windows.Forms.Button();
            this.btnStandby = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gpbFunctions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbFunctions
            // 
            this.gpbFunctions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpbFunctions.BackColor = System.Drawing.Color.LightGray;
            this.gpbFunctions.Controls.Add(this.pictureBox1);
            this.gpbFunctions.Controls.Add(this.btnChangePassword);
            this.gpbFunctions.Controls.Add(this.btnStart);
            this.gpbFunctions.Controls.Add(this.btnCashReport);
            this.gpbFunctions.Controls.Add(this.btnCashToSupervisor);
            this.gpbFunctions.Controls.Add(this.btnCashFromSuper);
            this.gpbFunctions.Controls.Add(this.btnLogOff);
            this.gpbFunctions.Controls.Add(this.btnStandby);
            this.gpbFunctions.Location = new System.Drawing.Point(12, 12);
            this.gpbFunctions.Name = "gpbFunctions";
            this.gpbFunctions.Size = new System.Drawing.Size(923, 640);
            this.gpbFunctions.TabIndex = 7;
            this.gpbFunctions.TabStop = false;
            this.gpbFunctions.Text = "Functions";
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePassword.Location = new System.Drawing.Point(610, 321);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(291, 138);
            this.btnChangePassword.TabIndex = 13;
            this.btnChangePassword.Text = "Change Password";
            this.btnChangePassword.UseVisualStyleBackColor = true;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(16, 487);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(588, 138);
            this.btnStart.TabIndex = 12;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnCashReport
            // 
            this.btnCashReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCashReport.Location = new System.Drawing.Point(610, 152);
            this.btnCashReport.Name = "btnCashReport";
            this.btnCashReport.Size = new System.Drawing.Size(291, 138);
            this.btnCashReport.TabIndex = 10;
            this.btnCashReport.Text = "Cash Report";
            this.btnCashReport.UseVisualStyleBackColor = true;
            this.btnCashReport.Click += new System.EventHandler(this.btnCashReport_Click);
            this.btnCashReport.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnCashReport_KeyDown);
            // 
            // btnCashToSupervisor
            // 
            this.btnCashToSupervisor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCashToSupervisor.Location = new System.Drawing.Point(313, 321);
            this.btnCashToSupervisor.Name = "btnCashToSupervisor";
            this.btnCashToSupervisor.Size = new System.Drawing.Size(291, 138);
            this.btnCashToSupervisor.TabIndex = 9;
            this.btnCashToSupervisor.Text = "Cash To Supervisor";
            this.btnCashToSupervisor.UseVisualStyleBackColor = true;
            this.btnCashToSupervisor.Click += new System.EventHandler(this.btnCashToSupervisor_Click);
            // 
            // btnCashFromSuper
            // 
            this.btnCashFromSuper.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCashFromSuper.Location = new System.Drawing.Point(16, 321);
            this.btnCashFromSuper.Name = "btnCashFromSuper";
            this.btnCashFromSuper.Size = new System.Drawing.Size(291, 138);
            this.btnCashFromSuper.TabIndex = 8;
            this.btnCashFromSuper.Text = "Cash From Supervisor";
            this.btnCashFromSuper.UseVisualStyleBackColor = true;
            this.btnCashFromSuper.Click += new System.EventHandler(this.btnCashFromSuper_Click);
            // 
            // btnLogOff
            // 
            this.btnLogOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOff.Location = new System.Drawing.Point(313, 152);
            this.btnLogOff.Name = "btnLogOff";
            this.btnLogOff.Size = new System.Drawing.Size(291, 138);
            this.btnLogOff.TabIndex = 7;
            this.btnLogOff.Text = "Log Off";
            this.btnLogOff.UseVisualStyleBackColor = true;
            this.btnLogOff.Click += new System.EventHandler(this.btnLogOff_Click);
            // 
            // btnStandby
            // 
            this.btnStandby.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStandby.Location = new System.Drawing.Point(16, 152);
            this.btnStandby.Name = "btnStandby";
            this.btnStandby.Size = new System.Drawing.Size(291, 138);
            this.btnStandby.TabIndex = 6;
            this.btnStandby.Text = "Standby";
            this.btnStandby.UseVisualStyleBackColor = true;
            this.btnStandby.Click += new System.EventHandler(this.btnStandby_Click);
            this.btnStandby.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnStandby_KeyDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Global_Hyper.Properties.Resources.Global_Hyper_logo_blue__small_;
            this.pictureBox1.Location = new System.Drawing.Point(16, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(155, 125);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(951, 661);
            this.Controls.Add(this.gpbFunctions);
            this.Name = "HomeForm";
            this.Text = "Home Form";
            this.Load += new System.EventHandler(this.HomeForm_Load);
            this.gpbFunctions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbFunctions;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnCashReport;
        private System.Windows.Forms.Button btnCashToSupervisor;
        private System.Windows.Forms.Button btnCashFromSuper;
        private System.Windows.Forms.Button btnLogOff;
        private System.Windows.Forms.Button btnStandby;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.PictureBox pictureBox1;

    }
}