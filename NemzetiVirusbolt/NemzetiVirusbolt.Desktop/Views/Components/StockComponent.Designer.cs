
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
            this.dataGridViewStock = new System.Windows.Forms.DataGridView();
            this.ColumnStockId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnStockProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnStockQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnStockRecordedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStock)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewStock
            // 
            this.dataGridViewStock.AllowUserToAddRows = false;
            this.dataGridViewStock.AllowUserToDeleteRows = false;
            this.dataGridViewStock.AllowUserToResizeRows = false;
            this.dataGridViewStock.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewStock.BackgroundColor = System.Drawing.SystemColors.AppWorkspace;
            this.dataGridViewStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnStockId,
            this.ColumnStockProductName,
            this.ColumnStockQuantity,
            this.ColumnStockRecordedDate});
            this.dataGridViewStock.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewStock.MultiSelect = false;
            this.dataGridViewStock.Name = "dataGridViewStock";
            this.dataGridViewStock.ReadOnly = true;
            this.dataGridViewStock.RowTemplate.Height = 25;
            this.dataGridViewStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewStock.Size = new System.Drawing.Size(948, 532);
            this.dataGridViewStock.TabIndex = 0;
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
            // StockComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewStock);
            this.Name = "StockComponent";
            this.Size = new System.Drawing.Size(948, 813);
            this.Load += new System.EventHandler(this.StockComponent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStock)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStockId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStockProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStockQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStockRecordedDate;
    }
}
