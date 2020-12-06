
namespace NemzetiVirusbolt.Desktop.Views.Components
{
    partial class StockComponent
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
            this.dataGridViewStocks = new System.Windows.Forms.DataGridView();
            this.ColumnStockId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnStockProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnStockQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnStockRecordedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewMergedStocks = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumnProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBoxProducts = new System.Windows.Forms.ComboBox();
            this.buttonAddStock = new System.Windows.Forms.Button();
            this.numericUpDownQuantity = new System.Windows.Forms.NumericUpDown();
            this.groupBoxAddStock = new System.Windows.Forms.GroupBox();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.labelProduct = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStocks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMergedStocks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).BeginInit();
            this.groupBoxAddStock.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewStocks
            // 
            this.dataGridViewStocks.AllowUserToAddRows = false;
            this.dataGridViewStocks.AllowUserToDeleteRows = false;
            this.dataGridViewStocks.AllowUserToResizeRows = false;
            this.dataGridViewStocks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewStocks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewStocks.BackgroundColor = System.Drawing.SystemColors.AppWorkspace;
            this.dataGridViewStocks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStocks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnStockId,
            this.ColumnStockProductName,
            this.ColumnStockQuantity,
            this.ColumnStockRecordedDate});
            this.dataGridViewStocks.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewStocks.MultiSelect = false;
            this.dataGridViewStocks.Name = "dataGridViewStocks";
            this.dataGridViewStocks.ReadOnly = true;
            this.dataGridViewStocks.RowTemplate.Height = 25;
            this.dataGridViewStocks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewStocks.Size = new System.Drawing.Size(948, 350);
            this.dataGridViewStocks.TabIndex = 0;
            // 
            // ColumnStockId
            // 
            this.ColumnStockId.DataPropertyName = "Id";
            this.ColumnStockId.HeaderText = "Azonosító";
            this.ColumnStockId.Name = "ColumnStockId";
            this.ColumnStockId.ReadOnly = true;
            // 
            // ColumnStockProductName
            // 
            this.ColumnStockProductName.DataPropertyName = "ProductName";
            this.ColumnStockProductName.HeaderText = "Termék";
            this.ColumnStockProductName.Name = "ColumnStockProductName";
            this.ColumnStockProductName.ReadOnly = true;
            // 
            // ColumnStockQuantity
            // 
            this.ColumnStockQuantity.DataPropertyName = "Quantity";
            this.ColumnStockQuantity.HeaderText = "Mennyiség";
            this.ColumnStockQuantity.Name = "ColumnStockQuantity";
            this.ColumnStockQuantity.ReadOnly = true;
            // 
            // ColumnStockRecordedDate
            // 
            this.ColumnStockRecordedDate.DataPropertyName = "DateRecorded";
            this.ColumnStockRecordedDate.HeaderText = "Rögzítés ideje";
            this.ColumnStockRecordedDate.Name = "ColumnStockRecordedDate";
            this.ColumnStockRecordedDate.ReadOnly = true;
            // 
            // dataGridViewMergedStocks
            // 
            this.dataGridViewMergedStocks.AllowUserToAddRows = false;
            this.dataGridViewMergedStocks.AllowUserToDeleteRows = false;
            this.dataGridViewMergedStocks.AllowUserToResizeRows = false;
            this.dataGridViewMergedStocks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewMergedStocks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewMergedStocks.BackgroundColor = System.Drawing.SystemColors.AppWorkspace;
            this.dataGridViewMergedStocks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMergedStocks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumnProduct,
            this.dataGridViewTextBoxColumnQuantity});
            this.dataGridViewMergedStocks.Location = new System.Drawing.Point(0, 356);
            this.dataGridViewMergedStocks.MultiSelect = false;
            this.dataGridViewMergedStocks.Name = "dataGridViewMergedStocks";
            this.dataGridViewMergedStocks.ReadOnly = true;
            this.dataGridViewMergedStocks.RowTemplate.Height = 25;
            this.dataGridViewMergedStocks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMergedStocks.Size = new System.Drawing.Size(530, 457);
            this.dataGridViewMergedStocks.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumnProduct
            // 
            this.dataGridViewTextBoxColumnProduct.DataPropertyName = "ProductName";
            this.dataGridViewTextBoxColumnProduct.HeaderText = "Termék";
            this.dataGridViewTextBoxColumnProduct.Name = "dataGridViewTextBoxColumnProduct";
            this.dataGridViewTextBoxColumnProduct.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumnQuantity
            // 
            this.dataGridViewTextBoxColumnQuantity.DataPropertyName = "Quantity";
            this.dataGridViewTextBoxColumnQuantity.HeaderText = "Mennyiség";
            this.dataGridViewTextBoxColumnQuantity.Name = "dataGridViewTextBoxColumnQuantity";
            this.dataGridViewTextBoxColumnQuantity.ReadOnly = true;
            // 
            // comboBoxProducts
            // 
            this.comboBoxProducts.DisplayMember = "Name";
            this.comboBoxProducts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProducts.FormattingEnabled = true;
            this.comboBoxProducts.Location = new System.Drawing.Point(90, 209);
            this.comboBoxProducts.Name = "comboBoxProducts";
            this.comboBoxProducts.Size = new System.Drawing.Size(292, 23);
            this.comboBoxProducts.TabIndex = 3;
            // 
            // buttonAddStock
            // 
            this.buttonAddStock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddStock.Enabled = false;
            this.buttonAddStock.Location = new System.Drawing.Point(90, 267);
            this.buttonAddStock.Name = "buttonAddStock";
            this.buttonAddStock.Size = new System.Drawing.Size(292, 23);
            this.buttonAddStock.TabIndex = 4;
            this.buttonAddStock.Text = "Rögzítés";
            this.buttonAddStock.UseVisualStyleBackColor = true;
            this.buttonAddStock.Click += new System.EventHandler(this.ButtonAddStock_Click);
            // 
            // numericUpDownQuantity
            // 
            this.numericUpDownQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownQuantity.Location = new System.Drawing.Point(90, 238);
            this.numericUpDownQuantity.Name = "numericUpDownQuantity";
            this.numericUpDownQuantity.Size = new System.Drawing.Size(292, 23);
            this.numericUpDownQuantity.TabIndex = 5;
            // 
            // groupBoxAddStock
            // 
            this.groupBoxAddStock.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxAddStock.Controls.Add(this.labelQuantity);
            this.groupBoxAddStock.Controls.Add(this.labelProduct);
            this.groupBoxAddStock.Controls.Add(this.buttonAddStock);
            this.groupBoxAddStock.Controls.Add(this.numericUpDownQuantity);
            this.groupBoxAddStock.Controls.Add(this.comboBoxProducts);
            this.groupBoxAddStock.Location = new System.Drawing.Point(536, 356);
            this.groupBoxAddStock.Name = "groupBoxAddStock";
            this.groupBoxAddStock.Size = new System.Drawing.Size(412, 457);
            this.groupBoxAddStock.TabIndex = 6;
            this.groupBoxAddStock.TabStop = false;
            this.groupBoxAddStock.Text = "Raktárkészlet bővítése";
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Location = new System.Drawing.Point(19, 240);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(65, 15);
            this.labelQuantity.TabIndex = 7;
            this.labelQuantity.Text = "Mennyiség";
            // 
            // labelProduct
            // 
            this.labelProduct.AutoSize = true;
            this.labelProduct.Location = new System.Drawing.Point(39, 212);
            this.labelProduct.Name = "labelProduct";
            this.labelProduct.Size = new System.Drawing.Size(45, 15);
            this.labelProduct.TabIndex = 6;
            this.labelProduct.Text = "Termék";
            // 
            // StockComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBoxAddStock);
            this.Controls.Add(this.dataGridViewMergedStocks);
            this.Controls.Add(this.dataGridViewStocks);
            this.Name = "StockComponent";
            this.Size = new System.Drawing.Size(948, 813);
            this.Load += new System.EventHandler(this.StockComponent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStocks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMergedStocks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).EndInit();
            this.groupBoxAddStock.ResumeLayout(false);
            this.groupBoxAddStock.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewStocks;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStockId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStockProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStockQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStockRecordedDate;
        private System.Windows.Forms.DataGridView dataGridViewMergedStocks;
        private System.Windows.Forms.ComboBox comboBoxProducts;
        private System.Windows.Forms.Button buttonAddStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnQuantity;
        private System.Windows.Forms.NumericUpDown numericUpDownQuantity;
        private System.Windows.Forms.GroupBox groupBoxAddStock;
        private System.Windows.Forms.Label labelProduct;
        private System.Windows.Forms.Label labelQuantity;
    }
}
