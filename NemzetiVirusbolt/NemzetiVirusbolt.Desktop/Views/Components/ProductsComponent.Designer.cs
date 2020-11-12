namespace NemzetiVirusbolt.Desktop.Views.Components
{
    partial class ProductsComponent
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewCentralStock = new System.Windows.Forms.DataGridView();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.ColumnProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnProductPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnProductUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnProductDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnProductSupplierName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCentralStock)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewCentralStock
            // 
            this.dataGridViewCentralStock.AllowUserToAddRows = false;
            this.dataGridViewCentralStock.AllowUserToDeleteRows = false;
            this.dataGridViewCentralStock.AllowUserToOrderColumns = true;
            this.dataGridViewCentralStock.AllowUserToResizeRows = false;
            this.dataGridViewCentralStock.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCentralStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCentralStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCentralStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnProductId,
            this.ColumnProductName,
            this.ColumnProductPrice,
            this.ColumnProductUnit,
            this.ColumnProductDescription,
            this.ColumnProductSupplierName});
            this.dataGridViewCentralStock.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewCentralStock.MultiSelect = false;
            this.dataGridViewCentralStock.Name = "dataGridViewCentralStock";
            this.dataGridViewCentralStock.ReadOnly = true;
            this.dataGridViewCentralStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCentralStock.Size = new System.Drawing.Size(811, 671);
            this.dataGridViewCentralStock.TabIndex = 0;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonUpdate.Location = new System.Drawing.Point(733, 677);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdate.TabIndex = 1;
            this.buttonUpdate.Text = "Frissítés";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.ButtonUpdate_Click);
            // 
            // buttonLoad
            // 
            this.buttonLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonLoad.Location = new System.Drawing.Point(3, 677);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(97, 23);
            this.buttonLoad.TabIndex = 2;
            this.buttonLoad.Text = "Adatok letöltése";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.ButtonLoad_Click);
            // 
            // ColumnProductId
            // 
            this.ColumnProductId.DataPropertyName = "Id";
            this.ColumnProductId.HeaderText = "Azonosító";
            this.ColumnProductId.Name = "ColumnProductId";
            this.ColumnProductId.ReadOnly = true;
            // 
            // ColumnProductName
            // 
            this.ColumnProductName.DataPropertyName = "Name";
            this.ColumnProductName.HeaderText = "Név";
            this.ColumnProductName.Name = "ColumnProductName";
            this.ColumnProductName.ReadOnly = true;
            // 
            // ColumnProductPrice
            // 
            this.ColumnProductPrice.DataPropertyName = "Price";
            this.ColumnProductPrice.HeaderText = "Egységár";
            this.ColumnProductPrice.Name = "ColumnProductPrice";
            this.ColumnProductPrice.ReadOnly = true;
            // 
            // ColumnProductUnit
            // 
            this.ColumnProductUnit.DataPropertyName = "Unit";
            this.ColumnProductUnit.HeaderText = "Mennyiségi egység";
            this.ColumnProductUnit.Name = "ColumnProductUnit";
            this.ColumnProductUnit.ReadOnly = true;
            // 
            // ColumnProductDescription
            // 
            this.ColumnProductDescription.DataPropertyName = "Description";
            this.ColumnProductDescription.HeaderText = "Leírás";
            this.ColumnProductDescription.Name = "ColumnProductDescription";
            this.ColumnProductDescription.ReadOnly = true;
            // 
            // ColumnProductSupplierName
            // 
            this.ColumnProductSupplierName.DataPropertyName = "SupplierName";
            this.ColumnProductSupplierName.HeaderText = "Beszállító";
            this.ColumnProductSupplierName.Name = "ColumnProductSupplierName";
            this.ColumnProductSupplierName.ReadOnly = true;
            // 
            // ProductsComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.dataGridViewCentralStock);
            this.Name = "ProductsComponent";
            this.Size = new System.Drawing.Size(811, 703);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCentralStock)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewCentralStock;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnProductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnProductPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnProductUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnProductDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnProductSupplierName;
    }
}
