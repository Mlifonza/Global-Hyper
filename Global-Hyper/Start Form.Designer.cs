namespace Global_Hyper
{
    partial class Start_Form
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
            this.lstItems = new System.Windows.Forms.ListBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.gpbNumbers = new System.Windows.Forms.GroupBox();
            this.txtNumbers = new System.Windows.Forms.TextBox();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btnBackspace = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.gpbFunctions = new System.Windows.Forms.GroupBox();
            this.btnProcess = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnTotal = new System.Windows.Forms.Button();
            this.btnFunctions = new System.Windows.Forms.Button();
            this.btnStandby = new System.Windows.Forms.Button();
            this.gpbNotification = new System.Windows.Forms.GroupBox();
            this.lblNotification = new System.Windows.Forms.Label();
            this.gpbCurrentTime = new System.Windows.Forms.GroupBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gpbNumbers.SuspendLayout();
            this.gpbFunctions.SuspendLayout();
            this.gpbNotification.SuspendLayout();
            this.gpbCurrentTime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lstItems
            // 
            this.lstItems.ColumnWidth = 85;
            this.lstItems.FormattingEnabled = true;
            this.lstItems.HorizontalScrollbar = true;
            this.lstItems.Location = new System.Drawing.Point(589, 151);
            this.lstItems.Name = "lstItems";
            this.lstItems.ScrollAlwaysVisible = true;
            this.lstItems.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstItems.Size = new System.Drawing.Size(385, 433);
            this.lstItems.TabIndex = 0;
            this.lstItems.SelectedIndexChanged += new System.EventHandler(this.lstItems_SelectedIndexChanged);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(394, 119);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(74, 29);
            this.lblPrice.TabIndex = 4;
            this.lblPrice.Text = "Price";
            // 
            // gpbNumbers
            // 
            this.gpbNumbers.BackColor = System.Drawing.Color.LightGray;
            this.gpbNumbers.Controls.Add(this.txtNumbers);
            this.gpbNumbers.Controls.Add(this.btn7);
            this.gpbNumbers.Controls.Add(this.btn8);
            this.gpbNumbers.Controls.Add(this.btn9);
            this.gpbNumbers.Controls.Add(this.btnBackspace);
            this.gpbNumbers.Controls.Add(this.btn1);
            this.gpbNumbers.Controls.Add(this.btn4);
            this.gpbNumbers.Controls.Add(this.btn0);
            this.gpbNumbers.Controls.Add(this.btn2);
            this.gpbNumbers.Controls.Add(this.btn5);
            this.gpbNumbers.Controls.Add(this.btnSend);
            this.gpbNumbers.Controls.Add(this.btn3);
            this.gpbNumbers.Controls.Add(this.btn6);
            this.gpbNumbers.Location = new System.Drawing.Point(282, 151);
            this.gpbNumbers.Name = "gpbNumbers";
            this.gpbNumbers.Size = new System.Drawing.Size(301, 433);
            this.gpbNumbers.TabIndex = 11;
            this.gpbNumbers.TabStop = false;
            this.gpbNumbers.Text = "Numbers";
            // 
            // txtNumbers
            // 
            this.txtNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumbers.Location = new System.Drawing.Point(20, 19);
            this.txtNumbers.Multiline = true;
            this.txtNumbers.Name = "txtNumbers";
            this.txtNumbers.Size = new System.Drawing.Size(264, 70);
            this.txtNumbers.TabIndex = 23;
            this.txtNumbers.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNumbers.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNumbers_KeyDown);
            this.txtNumbers.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumbers_KeyPress);
            this.txtNumbers.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtNumbers_KeyUp);
            // 
            // btn7
            // 
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.Location = new System.Drawing.Point(40, 107);
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
            this.btn8.Location = new System.Drawing.Point(122, 107);
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
            this.btn9.Location = new System.Drawing.Point(204, 107);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(64, 58);
            this.btn9.TabIndex = 20;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            this.btn9.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn9_MouseDown);
            this.btn9.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn9_MouseUp);
            // 
            // btnBackspace
            // 
            this.btnBackspace.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackspace.Location = new System.Drawing.Point(40, 299);
            this.btnBackspace.Name = "btnBackspace";
            this.btnBackspace.Size = new System.Drawing.Size(64, 58);
            this.btnBackspace.TabIndex = 19;
            this.btnBackspace.Text = "<";
            this.btnBackspace.UseVisualStyleBackColor = true;
            this.btnBackspace.Click += new System.EventHandler(this.btnBackspace_Click);
            this.btnBackspace.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnBackspace_MouseDown);
            this.btnBackspace.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnBackspace_MouseUp);
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(40, 235);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(64, 58);
            this.btn1.TabIndex = 18;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            this.btn1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn1_MouseDown);
            this.btn1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn1_MouseUp);
            // 
            // btn4
            // 
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.Location = new System.Drawing.Point(40, 171);
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
            this.btn0.Location = new System.Drawing.Point(122, 299);
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
            this.btn2.Location = new System.Drawing.Point(122, 235);
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
            this.btn5.Location = new System.Drawing.Point(122, 171);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(64, 58);
            this.btn5.TabIndex = 14;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            this.btn5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn5_MouseDown);
            this.btn5.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn5_MouseUp);
            // 
            // btnSend
            // 
            this.btnSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.Location = new System.Drawing.Point(40, 363);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(228, 58);
            this.btnSend.TabIndex = 13;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            this.btnSend.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnSend_MouseDown);
            this.btnSend.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnSend_MouseUp);
            // 
            // btn3
            // 
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.Location = new System.Drawing.Point(204, 235);
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
            this.btn6.Location = new System.Drawing.Point(204, 171);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(64, 58);
            this.btn6.TabIndex = 11;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            this.btn6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn6_MouseDown);
            this.btn6.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn6_MouseUp);
            // 
            // gpbFunctions
            // 
            this.gpbFunctions.BackColor = System.Drawing.Color.LightGray;
            this.gpbFunctions.Controls.Add(this.btnProcess);
            this.gpbFunctions.Controls.Add(this.btnCancel);
            this.gpbFunctions.Controls.Add(this.btnTotal);
            this.gpbFunctions.Controls.Add(this.btnFunctions);
            this.gpbFunctions.Controls.Add(this.btnStandby);
            this.gpbFunctions.Location = new System.Drawing.Point(12, 151);
            this.gpbFunctions.Name = "gpbFunctions";
            this.gpbFunctions.Size = new System.Drawing.Size(264, 433);
            this.gpbFunctions.TabIndex = 16;
            this.gpbFunctions.TabStop = false;
            this.gpbFunctions.Text = "Functions";
            // 
            // btnProcess
            // 
            this.btnProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcess.Location = new System.Drawing.Point(6, 306);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(245, 88);
            this.btnProcess.TabIndex = 22;
            this.btnProcess.Text = "Process";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(147, 208);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(104, 88);
            this.btnCancel.TabIndex = 21;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnTotal
            // 
            this.btnTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTotal.Location = new System.Drawing.Point(6, 208);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(97, 88);
            this.btnTotal.TabIndex = 20;
            this.btnTotal.Text = "Total";
            this.btnTotal.UseVisualStyleBackColor = true;
            this.btnTotal.Click += new System.EventHandler(this.btnTotal_Click);
            // 
            // btnFunctions
            // 
            this.btnFunctions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFunctions.Location = new System.Drawing.Point(6, 19);
            this.btnFunctions.Name = "btnFunctions";
            this.btnFunctions.Size = new System.Drawing.Size(97, 171);
            this.btnFunctions.TabIndex = 19;
            this.btnFunctions.Text = "Functions";
            this.btnFunctions.UseVisualStyleBackColor = true;
            this.btnFunctions.Click += new System.EventHandler(this.btnFunctions_Click);
            // 
            // btnStandby
            // 
            this.btnStandby.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnStandby.FlatAppearance.BorderSize = 3;
            this.btnStandby.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStandby.Location = new System.Drawing.Point(147, 19);
            this.btnStandby.Name = "btnStandby";
            this.btnStandby.Size = new System.Drawing.Size(104, 171);
            this.btnStandby.TabIndex = 16;
            this.btnStandby.Text = "Standby";
            this.btnStandby.UseVisualStyleBackColor = true;
            this.btnStandby.Click += new System.EventHandler(this.btnStandby_Click);
            // 
            // gpbNotification
            // 
            this.gpbNotification.BackColor = System.Drawing.Color.LightGray;
            this.gpbNotification.Controls.Add(this.lblNotification);
            this.gpbNotification.Location = new System.Drawing.Point(589, 609);
            this.gpbNotification.Name = "gpbNotification";
            this.gpbNotification.Size = new System.Drawing.Size(385, 50);
            this.gpbNotification.TabIndex = 17;
            this.gpbNotification.TabStop = false;
            this.gpbNotification.Text = "Notification";
            // 
            // lblNotification
            // 
            this.lblNotification.AutoSize = true;
            this.lblNotification.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotification.ForeColor = System.Drawing.Color.Red;
            this.lblNotification.Location = new System.Drawing.Point(64, 16);
            this.lblNotification.Name = "lblNotification";
            this.lblNotification.Size = new System.Drawing.Size(99, 22);
            this.lblNotification.TabIndex = 0;
            this.lblNotification.Text = "Notification";
            // 
            // gpbCurrentTime
            // 
            this.gpbCurrentTime.BackColor = System.Drawing.Color.LightGray;
            this.gpbCurrentTime.Controls.Add(this.lblTime);
            this.gpbCurrentTime.Location = new System.Drawing.Point(12, 609);
            this.gpbCurrentTime.Name = "gpbCurrentTime";
            this.gpbCurrentTime.Size = new System.Drawing.Size(571, 50);
            this.gpbCurrentTime.TabIndex = 18;
            this.gpbCurrentTime.TabStop = false;
            this.gpbCurrentTime.Text = "Current Time";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTime.Location = new System.Drawing.Point(64, 16);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(50, 22);
            this.lblTime.TabIndex = 0;
            this.lblTime.Text = "Time";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Global_Hyper.Properties.Resources.Global_Hyper_logo_blue__small_;
            this.pictureBox1.Location = new System.Drawing.Point(18, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(155, 125);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            // 
            // Start_Form
            // 
            this.AcceptButton = this.btnSend;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(986, 711);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gpbCurrentTime);
            this.Controls.Add(this.gpbNotification);
            this.Controls.Add(this.gpbFunctions);
            this.Controls.Add(this.gpbNumbers);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lstItems);
            this.Name = "Start_Form";
            this.Text = "Start_Form";
            this.Activated += new System.EventHandler(this.Start_Form_Activated);
            this.Load += new System.EventHandler(this.Start_Form_Load);
            this.gpbNumbers.ResumeLayout(false);
            this.gpbNumbers.PerformLayout();
            this.gpbFunctions.ResumeLayout(false);
            this.gpbNotification.ResumeLayout(false);
            this.gpbNotification.PerformLayout();
            this.gpbCurrentTime.ResumeLayout(false);
            this.gpbCurrentTime.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstItems;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.GroupBox gpbNumbers;
        private System.Windows.Forms.TextBox txtNumbers;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btnBackspace;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.GroupBox gpbFunctions;
        private System.Windows.Forms.Button btnFunctions;
        private System.Windows.Forms.Button btnStandby;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnTotal;
        private System.Windows.Forms.GroupBox gpbNotification;
        private System.Windows.Forms.Label lblNotification;
        private System.Windows.Forms.GroupBox gpbCurrentTime;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}