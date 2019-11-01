namespace Global_Hyper
{
    partial class View_Operators
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wORKERBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.globalHyperDataSet = new Global_Hyper.GlobalHyperDataSet();
            this.wORKERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wORKERTableAdapter = new Global_Hyper.GlobalHyperDataSetTableAdapters.WORKERTableAdapter();
            this.globalHyperDataSet3 = new Global_Hyper.GlobalHyperDataSet3();
            this.wORKERBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.wORKERTableAdapter1 = new Global_Hyper.GlobalHyperDataSet3TableAdapters.WORKERTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wORKERBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.globalHyperDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wORKERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.globalHyperDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wORKERBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.dataGridView1.DataSource = this.wORKERBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(951, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "empID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Employee Number";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "surname";
            this.dataGridViewTextBoxColumn3.HeaderText = "Surname";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "username";
            this.dataGridViewTextBoxColumn4.HeaderText = "Username";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "position";
            this.dataGridViewTextBoxColumn5.HeaderText = "Position";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "cashRecieved";
            this.dataGridViewTextBoxColumn6.HeaderText = "Cash Recieved";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "cashTransfered";
            this.dataGridViewTextBoxColumn7.HeaderText = "Cash Transfered";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "loggedIn";
            this.dataGridViewTextBoxColumn8.HeaderText = "Logged In";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "balance";
            this.dataGridViewTextBoxColumn9.HeaderText = "Balance";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // wORKERBindingSource1
            // 
            this.wORKERBindingSource1.DataMember = "WORKER";
            this.wORKERBindingSource1.DataSource = this.globalHyperDataSet;
            // 
            // globalHyperDataSet
            // 
            this.globalHyperDataSet.DataSetName = "GlobalHyperDataSet";
            this.globalHyperDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // wORKERBindingSource
            // 
            this.wORKERBindingSource.DataMember = "WORKER";
            // 
            // wORKERTableAdapter
            // 
            this.wORKERTableAdapter.ClearBeforeFill = true;
            // 
            // globalHyperDataSet3
            // 
            this.globalHyperDataSet3.DataSetName = "GlobalHyperDataSet3";
            this.globalHyperDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // wORKERBindingSource2
            // 
            this.wORKERBindingSource2.DataMember = "WORKER";
            this.wORKERBindingSource2.DataSource = this.globalHyperDataSet3;
            // 
            // wORKERTableAdapter1
            // 
            this.wORKERTableAdapter1.ClearBeforeFill = true;
            // 
            // View_Operators
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.DarkOrchid;
            this.ClientSize = new System.Drawing.Size(983, 191);
            this.Controls.Add(this.dataGridView1);
            this.MinimumSize = new System.Drawing.Size(999, 230);
            this.Name = "View_Operators";
            this.Text = "View_Operators";
            this.Load += new System.EventHandler(this.View_Operators_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wORKERBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.globalHyperDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wORKERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.globalHyperDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wORKERBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource wORKERBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn empIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn positionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cashRecievedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cashTransferedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loggedInDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn balanceDataGridViewTextBoxColumn;
        private GlobalHyperDataSet globalHyperDataSet;
        private System.Windows.Forms.BindingSource wORKERBindingSource1;
        private GlobalHyperDataSetTableAdapters.WORKERTableAdapter wORKERTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private GlobalHyperDataSet3 globalHyperDataSet3;
        private System.Windows.Forms.BindingSource wORKERBindingSource2;
        private GlobalHyperDataSet3TableAdapters.WORKERTableAdapter wORKERTableAdapter1;
    }
}