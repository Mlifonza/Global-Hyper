namespace Global_Hyper
{
    partial class Admin_HomeForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnViewProducts = new System.Windows.Forms.Button();
            this.btnViewOperators = new System.Windows.Forms.Button();
            this.btnDelProduct = new System.Windows.Forms.Button();
            this.btnDelOperator = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnPasswordRecovery = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.btnAddOperator = new System.Windows.Forms.Button();
            this.btnCashReport = new System.Windows.Forms.Button();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.btnCashToOperator = new System.Windows.Forms.Button();
            this.btnCashFromOperator = new System.Windows.Forms.Button();
            this.btnLogOff = new System.Windows.Forms.Button();
            this.btnStandby = new System.Windows.Forms.Button();
            this.gpbFunctions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbFunctions
            // 
            this.gpbFunctions.AutoSize = true;
            this.gpbFunctions.BackColor = System.Drawing.Color.LightGray;
            this.gpbFunctions.Controls.Add(this.pictureBox1);
            this.gpbFunctions.Controls.Add(this.btnViewProducts);
            this.gpbFunctions.Controls.Add(this.btnViewOperators);
            this.gpbFunctions.Controls.Add(this.btnDelProduct);
            this.gpbFunctions.Controls.Add(this.btnDelOperator);
            this.gpbFunctions.Controls.Add(this.btnAbout);
            this.gpbFunctions.Controls.Add(this.btnPasswordRecovery);
            this.gpbFunctions.Controls.Add(this.btnAddProduct);
            this.gpbFunctions.Controls.Add(this.btnAddOperator);
            this.gpbFunctions.Controls.Add(this.btnCashReport);
            this.gpbFunctions.Controls.Add(this.btnDeposit);
            this.gpbFunctions.Controls.Add(this.btnWithdraw);
            this.gpbFunctions.Controls.Add(this.btnChangePassword);
            this.gpbFunctions.Controls.Add(this.btnCashToOperator);
            this.gpbFunctions.Controls.Add(this.btnCashFromOperator);
            this.gpbFunctions.Controls.Add(this.btnLogOff);
            this.gpbFunctions.Controls.Add(this.btnStandby);
            this.gpbFunctions.Location = new System.Drawing.Point(12, 12);
            this.gpbFunctions.Name = "gpbFunctions";
            this.gpbFunctions.Size = new System.Drawing.Size(1307, 616);
            this.gpbFunctions.TabIndex = 8;
            this.gpbFunctions.TabStop = false;
            this.gpbFunctions.Text = "Functions";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Global_Hyper.Properties.Resources.Global_Hyper_logo_blue__small_;
            this.pictureBox1.Location = new System.Drawing.Point(12, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(155, 125);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            // 
            // btnViewProducts
            // 
            this.btnViewProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewProducts.Location = new System.Drawing.Point(652, 457);
            this.btnViewProducts.Name = "btnViewProducts";
            this.btnViewProducts.Size = new System.Drawing.Size(300, 140);
            this.btnViewProducts.TabIndex = 24;
            this.btnViewProducts.Text = "View Products";
            this.btnViewProducts.UseVisualStyleBackColor = true;
            this.btnViewProducts.Click += new System.EventHandler(this.btnViewProducts_Click);
            // 
            // btnViewOperators
            // 
            this.btnViewOperators.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewOperators.Location = new System.Drawing.Point(333, 457);
            this.btnViewOperators.Name = "btnViewOperators";
            this.btnViewOperators.Size = new System.Drawing.Size(300, 140);
            this.btnViewOperators.TabIndex = 23;
            this.btnViewOperators.Text = "View Operators";
            this.btnViewOperators.UseVisualStyleBackColor = true;
            this.btnViewOperators.Click += new System.EventHandler(this.btnViewOperators_Click);
            // 
            // btnDelProduct
            // 
            this.btnDelProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelProduct.Location = new System.Drawing.Point(970, 311);
            this.btnDelProduct.Name = "btnDelProduct";
            this.btnDelProduct.Size = new System.Drawing.Size(300, 140);
            this.btnDelProduct.TabIndex = 22;
            this.btnDelProduct.Text = "Remove Product";
            this.btnDelProduct.UseVisualStyleBackColor = true;
            this.btnDelProduct.Click += new System.EventHandler(this.btnDelProduct_Click);
            // 
            // btnDelOperator
            // 
            this.btnDelOperator.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelOperator.Location = new System.Drawing.Point(652, 311);
            this.btnDelOperator.Name = "btnDelOperator";
            this.btnDelOperator.Size = new System.Drawing.Size(300, 140);
            this.btnDelOperator.TabIndex = 21;
            this.btnDelOperator.Text = "Remove Operator";
            this.btnDelOperator.UseVisualStyleBackColor = true;
            this.btnDelOperator.Click += new System.EventHandler(this.btnDelOperator_Click_1);
            // 
            // btnAbout
            // 
            this.btnAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbout.Location = new System.Drawing.Point(970, 457);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(300, 140);
            this.btnAbout.TabIndex = 20;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnPasswordRecovery
            // 
            this.btnPasswordRecovery.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPasswordRecovery.Location = new System.Drawing.Point(333, 311);
            this.btnPasswordRecovery.Name = "btnPasswordRecovery";
            this.btnPasswordRecovery.Size = new System.Drawing.Size(300, 140);
            this.btnPasswordRecovery.TabIndex = 19;
            this.btnPasswordRecovery.Text = "Password Recovery";
            this.btnPasswordRecovery.UseVisualStyleBackColor = true;
            this.btnPasswordRecovery.Click += new System.EventHandler(this.btnPasswordRecovery_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProduct.Location = new System.Drawing.Point(970, 165);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(300, 140);
            this.btnAddProduct.TabIndex = 18;
            this.btnAddProduct.Text = "Add Product";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // btnAddOperator
            // 
            this.btnAddOperator.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddOperator.Location = new System.Drawing.Point(970, 19);
            this.btnAddOperator.Name = "btnAddOperator";
            this.btnAddOperator.Size = new System.Drawing.Size(300, 140);
            this.btnAddOperator.TabIndex = 17;
            this.btnAddOperator.Text = "Add Operator";
            this.btnAddOperator.UseVisualStyleBackColor = true;
            this.btnAddOperator.Click += new System.EventHandler(this.btnAddOperator_Click);
            // 
            // btnCashReport
            // 
            this.btnCashReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCashReport.Location = new System.Drawing.Point(16, 311);
            this.btnCashReport.Name = "btnCashReport";
            this.btnCashReport.Size = new System.Drawing.Size(300, 140);
            this.btnCashReport.TabIndex = 16;
            this.btnCashReport.Text = "Cash Report";
            this.btnCashReport.UseVisualStyleBackColor = true;
            this.btnCashReport.Click += new System.EventHandler(this.btnCashReport_Click);
            // 
            // btnDeposit
            // 
            this.btnDeposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeposit.Location = new System.Drawing.Point(652, 165);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(300, 140);
            this.btnDeposit.TabIndex = 15;
            this.btnDeposit.Text = "Deposit To Bank";
            this.btnDeposit.UseVisualStyleBackColor = true;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWithdraw.Location = new System.Drawing.Point(652, 19);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(300, 140);
            this.btnWithdraw.TabIndex = 14;
            this.btnWithdraw.Text = "Withdraw From Bank";
            this.btnWithdraw.UseVisualStyleBackColor = true;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePassword.Location = new System.Drawing.Point(333, 19);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(300, 140);
            this.btnChangePassword.TabIndex = 13;
            this.btnChangePassword.Text = "Change Password";
            this.btnChangePassword.UseVisualStyleBackColor = true;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // btnCashToOperator
            // 
            this.btnCashToOperator.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCashToOperator.Location = new System.Drawing.Point(16, 165);
            this.btnCashToOperator.Name = "btnCashToOperator";
            this.btnCashToOperator.Size = new System.Drawing.Size(300, 140);
            this.btnCashToOperator.TabIndex = 9;
            this.btnCashToOperator.Text = "Cash To Operator";
            this.btnCashToOperator.UseVisualStyleBackColor = true;
            this.btnCashToOperator.Click += new System.EventHandler(this.btnCashToOperator_Click);
            // 
            // btnCashFromOperator
            // 
            this.btnCashFromOperator.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCashFromOperator.Location = new System.Drawing.Point(333, 165);
            this.btnCashFromOperator.Name = "btnCashFromOperator";
            this.btnCashFromOperator.Size = new System.Drawing.Size(300, 140);
            this.btnCashFromOperator.TabIndex = 8;
            this.btnCashFromOperator.Text = "Cash From Operator";
            this.btnCashFromOperator.UseVisualStyleBackColor = true;
            this.btnCashFromOperator.Click += new System.EventHandler(this.btnCashFromOperator_Click);
            // 
            // btnLogOff
            // 
            this.btnLogOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOff.Location = new System.Drawing.Point(16, 457);
            this.btnLogOff.Name = "btnLogOff";
            this.btnLogOff.Size = new System.Drawing.Size(300, 140);
            this.btnLogOff.TabIndex = 7;
            this.btnLogOff.Text = "Log Off";
            this.btnLogOff.UseVisualStyleBackColor = true;
            this.btnLogOff.Click += new System.EventHandler(this.btnLogOff_Click);
            // 
            // btnStandby
            // 
            this.btnStandby.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStandby.Location = new System.Drawing.Point(173, 19);
            this.btnStandby.Name = "btnStandby";
            this.btnStandby.Size = new System.Drawing.Size(143, 140);
            this.btnStandby.TabIndex = 6;
            this.btnStandby.Text = "Standby";
            this.btnStandby.UseVisualStyleBackColor = true;
            this.btnStandby.Click += new System.EventHandler(this.btnStandby_Click);
            // 
            // Admin_HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(1331, 645);
            this.Controls.Add(this.gpbFunctions);
            this.MaximumSize = new System.Drawing.Size(1347, 684);
            this.MinimumSize = new System.Drawing.Size(1347, 684);
            this.Name = "Admin_HomeForm";
            this.Text = "Admin_HomeForm";
            this.gpbFunctions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbFunctions;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.Button btnCashToOperator;
        private System.Windows.Forms.Button btnCashFromOperator;
        private System.Windows.Forms.Button btnLogOff;
        private System.Windows.Forms.Button btnStandby;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.Button btnWithdraw;
        private System.Windows.Forms.Button btnCashReport;
        private System.Windows.Forms.Button btnPasswordRecovery;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Button btnAddOperator;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnDelProduct;
        private System.Windows.Forms.Button btnDelOperator;
        private System.Windows.Forms.Button btnViewProducts;
        private System.Windows.Forms.Button btnViewOperators;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}