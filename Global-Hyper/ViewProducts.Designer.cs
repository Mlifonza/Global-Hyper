namespace Global_Hyper
{
    partial class ViewProducts
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
            this.ProductsDataGrid = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productInfoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.globalHyperDataSet2 = new Global_Hyper.GlobalHyperDataSet2();
            this.productInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.globalHyperDataSet1 = new Global_Hyper.GlobalHyperDataSet1();
            this.pRODUCTSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pRODUCTSTableAdapter = new Global_Hyper.GlobalHyperDataSet1TableAdapters.PRODUCTSTableAdapter();
            this.productInfoTableAdapter = new Global_Hyper.GlobalHyperDataSet2TableAdapters.productInfoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productInfoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.globalHyperDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.globalHyperDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductsDataGrid
            // 
            this.ProductsDataGrid.AllowUserToOrderColumns = true;
            this.ProductsDataGrid.AutoGenerateColumns = false;
            this.ProductsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductsDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.ProductsDataGrid.DataSource = this.productInfoBindingSource1;
            this.ProductsDataGrid.Location = new System.Drawing.Point(12, 12);
            this.ProductsDataGrid.Name = "ProductsDataGrid";
            this.ProductsDataGrid.Size = new System.Drawing.Size(453, 287);
            this.ProductsDataGrid.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "proID";
            this.dataGridViewTextBoxColumn4.HeaderText = "Product Number";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn1.HeaderText = "Name of Item";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "price";
            this.dataGridViewTextBoxColumn2.HeaderText = "Price";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "stock";
            this.dataGridViewTextBoxColumn3.HeaderText = "Stock Available";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // productInfoBindingSource1
            // 
            this.productInfoBindingSource1.DataMember = "productInfo";
            this.productInfoBindingSource1.DataSource = this.globalHyperDataSet2;
            // 
            // globalHyperDataSet2
            // 
            this.globalHyperDataSet2.DataSetName = "GlobalHyperDataSet2";
            this.globalHyperDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productInfoBindingSource
            // 
            this.productInfoBindingSource.DataMember = "productInfo";
            // 
            // globalHyperDataSet1
            // 
            this.globalHyperDataSet1.DataSetName = "GlobalHyperDataSet1";
            this.globalHyperDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pRODUCTSBindingSource
            // 
            this.pRODUCTSBindingSource.DataMember = "PRODUCTS";
            this.pRODUCTSBindingSource.DataSource = this.globalHyperDataSet1;
            // 
            // pRODUCTSTableAdapter
            // 
            this.pRODUCTSTableAdapter.ClearBeforeFill = true;
            // 
            // productInfoTableAdapter
            // 
            this.productInfoTableAdapter.ClearBeforeFill = true;
            // 
            // ViewProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.DarkOrchid;
            this.ClientSize = new System.Drawing.Size(486, 311);
            this.Controls.Add(this.ProductsDataGrid);
            this.MaximumSize = new System.Drawing.Size(502, 600);
            this.MinimumSize = new System.Drawing.Size(502, 350);
            this.Name = "ViewProducts";
            this.Text = "ViewProducts";
            this.Load += new System.EventHandler(this.ViewProducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProductsDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productInfoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.globalHyperDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.globalHyperDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTSBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ProductsDataGrid;
        private System.Windows.Forms.BindingSource productInfoBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn proIDDataGridViewTextBoxColumn;
        private GlobalHyperDataSet1 globalHyperDataSet1;
        private System.Windows.Forms.BindingSource pRODUCTSBindingSource;
        private GlobalHyperDataSet1TableAdapters.PRODUCTSTableAdapter pRODUCTSTableAdapter;
        private GlobalHyperDataSet2 globalHyperDataSet2;
        private System.Windows.Forms.BindingSource productInfoBindingSource1;
        private GlobalHyperDataSet2TableAdapters.productInfoTableAdapter productInfoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}