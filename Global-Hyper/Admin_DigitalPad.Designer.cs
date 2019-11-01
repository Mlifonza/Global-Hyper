namespace Global_Hyper
{
    partial class Admin_DigitalPad
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
            this.gpbTransfer = new System.Windows.Forms.GroupBox();
            this.lblResults = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.btnProcess = new System.Windows.Forms.Button();
            this.gpbNumbers = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDot = new System.Windows.Forms.Button();
            this.btnBackspace = new System.Windows.Forms.Button();
            this.txtNumbers = new System.Windows.Forms.TextBox();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.gpbTransfer.SuspendLayout();
            this.gpbNumbers.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbTransfer
            // 
            this.gpbTransfer.BackColor = System.Drawing.Color.LightGray;
            this.gpbTransfer.Controls.Add(this.lblResults);
            this.gpbTransfer.Controls.Add(this.label1);
            this.gpbTransfer.Controls.Add(this.txtAmount);
            this.gpbTransfer.Controls.Add(this.txtUsername);
            this.gpbTransfer.Controls.Add(this.btnProcess);
            this.gpbTransfer.Location = new System.Drawing.Point(317, 12);
            this.gpbTransfer.Name = "gpbTransfer";
            this.gpbTransfer.Size = new System.Drawing.Size(340, 377);
            this.gpbTransfer.TabIndex = 2;
            this.gpbTransfer.TabStop = false;
            this.gpbTransfer.Text = "Transfer";
            // 
            // lblResults
            // 
            this.lblResults.AutoSize = true;
            this.lblResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResults.Location = new System.Drawing.Point(19, 340);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(49, 13);
            this.lblResults.TabIndex = 5;
            this.lblResults.Text = "Results";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Operator Username";
            // 
            // txtAmount
            // 
            this.txtAmount.Enabled = false;
            this.txtAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.Location = new System.Drawing.Point(46, 33);
            this.txtAmount.Multiline = true;
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.ReadOnly = true;
            this.txtAmount.Size = new System.Drawing.Size(245, 56);
            this.txtAmount.TabIndex = 3;
            this.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(46, 139);
            this.txtUsername.Multiline = true;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(245, 56);
            this.txtUsername.TabIndex = 3;
            this.txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            this.txtUsername.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUsername_KeyDown);
            this.txtUsername.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtUsername_KeyUp);
            // 
            // btnProcess
            // 
            this.btnProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcess.Location = new System.Drawing.Point(46, 217);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(245, 96);
            this.btnProcess.TabIndex = 4;
            this.btnProcess.Text = "Process";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            this.btnProcess.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnProcess_MouseDown);
            this.btnProcess.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnProcess_MouseUp);
            // 
            // gpbNumbers
            // 
            this.gpbNumbers.BackColor = System.Drawing.Color.LightGray;
            this.gpbNumbers.Controls.Add(this.label2);
            this.gpbNumbers.Controls.Add(this.btnDot);
            this.gpbNumbers.Controls.Add(this.btnBackspace);
            this.gpbNumbers.Controls.Add(this.txtNumbers);
            this.gpbNumbers.Controls.Add(this.btn7);
            this.gpbNumbers.Controls.Add(this.btn8);
            this.gpbNumbers.Controls.Add(this.btn9);
            this.gpbNumbers.Controls.Add(this.btn1);
            this.gpbNumbers.Controls.Add(this.btn4);
            this.gpbNumbers.Controls.Add(this.btn0);
            this.gpbNumbers.Controls.Add(this.btn2);
            this.gpbNumbers.Controls.Add(this.btn5);
            this.gpbNumbers.Controls.Add(this.btn3);
            this.gpbNumbers.Controls.Add(this.btn6);
            this.gpbNumbers.Location = new System.Drawing.Point(10, 12);
            this.gpbNumbers.Name = "gpbNumbers";
            this.gpbNumbers.Size = new System.Drawing.Size(301, 377);
            this.gpbNumbers.TabIndex = 0;
            this.gpbNumbers.TabStop = false;
            this.gpbNumbers.Text = "Numbers";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "(e.g. 1200.50 or 1200)";
            // 
            // btnDot
            // 
            this.btnDot.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDot.Location = new System.Drawing.Point(200, 303);
            this.btnDot.Name = "btnDot";
            this.btnDot.Size = new System.Drawing.Size(64, 58);
            this.btnDot.TabIndex = 24;
            this.btnDot.Text = ",";
            this.btnDot.UseVisualStyleBackColor = true;
            this.btnDot.Click += new System.EventHandler(this.btnDot_Click);
            this.btnDot.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnDot_MouseDown);
            this.btnDot.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnDot_MouseUp);
            // 
            // btnBackspace
            // 
            this.btnBackspace.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackspace.Location = new System.Drawing.Point(36, 303);
            this.btnBackspace.Name = "btnBackspace";
            this.btnBackspace.Size = new System.Drawing.Size(64, 58);
            this.btnBackspace.TabIndex = 23;
            this.btnBackspace.Text = "<";
            this.btnBackspace.UseVisualStyleBackColor = true;
            // 
            // txtNumbers
            // 
            this.txtNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumbers.Location = new System.Drawing.Point(20, 19);
            this.txtNumbers.Multiline = true;
            this.txtNumbers.Name = "txtNumbers";
            this.txtNumbers.Size = new System.Drawing.Size(264, 70);
            this.txtNumbers.TabIndex = 1;
            this.txtNumbers.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNumbers.TextChanged += new System.EventHandler(this.txtNumbers_TextChanged);
            this.txtNumbers.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNumbers_KeyDown);
            this.txtNumbers.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumbers_KeyPress);
            this.txtNumbers.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtNumbers_KeyUp);
            // 
            // btn7
            // 
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.Location = new System.Drawing.Point(36, 111);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(64, 58);
            this.btn7.TabIndex = 22;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            this.btn7.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn7_MouseDown);
            this.btn7.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn7_MouseUp);
            // 
            // btn8
            // 
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.Location = new System.Drawing.Point(118, 111);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(64, 58);
            this.btn8.TabIndex = 21;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            this.btn8.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn8_MouseDown);
            this.btn8.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn8_MouseUp);
            // 
            // btn9
            // 
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.Location = new System.Drawing.Point(200, 111);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(64, 58);
            this.btn9.TabIndex = 20;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            this.btn9.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn9_MouseDown);
            this.btn9.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn9_MouseUp);
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(36, 239);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(64, 58);
            this.btn1.TabIndex = 18;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            this.btn1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn1_KeyDown);
            this.btn1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btn1_KeyPress);
            this.btn1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.btn1_KeyUp);
            this.btn1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn1_MouseDown);
            this.btn1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn1_MouseUp);
            // 
            // btn4
            // 
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.Location = new System.Drawing.Point(36, 175);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(64, 58);
            this.btn4.TabIndex = 17;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            this.btn4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn4_MouseDown);
            this.btn4.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn4_MouseUp);
            // 
            // btn0
            // 
            this.btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.Location = new System.Drawing.Point(118, 303);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(64, 58);
            this.btn0.TabIndex = 16;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            this.btn0.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn0_MouseDown);
            this.btn0.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn0_MouseUp);
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(118, 239);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(64, 58);
            this.btn2.TabIndex = 15;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            this.btn2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn2_MouseDown);
            this.btn2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn2_MouseUp);
            // 
            // btn5
            // 
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.Location = new System.Drawing.Point(118, 175);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(64, 58);
            this.btn5.TabIndex = 14;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            this.btn5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn5_MouseDown);
            this.btn5.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn5_MouseUp);
            // 
            // btn3
            // 
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.Location = new System.Drawing.Point(200, 239);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(64, 58);
            this.btn3.TabIndex = 12;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            this.btn3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn3_MouseDown);
            this.btn3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn3_MouseUp);
            // 
            // btn6
            // 
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.Location = new System.Drawing.Point(200, 175);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(64, 58);
            this.btn6.TabIndex = 11;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            this.btn6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn6_MouseDown);
            this.btn6.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn6_MouseUp);
            // 
            // Admin_DigitalPad
            // 
            this.AcceptButton = this.btnProcess;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrchid;
            this.ClientSize = new System.Drawing.Size(669, 403);
            this.Controls.Add(this.gpbTransfer);
            this.Controls.Add(this.gpbNumbers);
            this.Name = "Admin_DigitalPad";
            this.Text = "Admin_DigitalPad";
            this.Activated += new System.EventHandler(this.Admin_DigitalPad_Activated);
            this.Load += new System.EventHandler(this.Admin_DigitalPad_Load);
            this.gpbTransfer.ResumeLayout(false);
            this.gpbTransfer.PerformLayout();
            this.gpbNumbers.ResumeLayout(false);
            this.gpbNumbers.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbTransfer;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.GroupBox gpbNumbers;
        private System.Windows.Forms.TextBox txtNumbers;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblResults;
        private System.Windows.Forms.Button btnDot;
        private System.Windows.Forms.Button btnBackspace;
        private System.Windows.Forms.Label label2;
    }
}