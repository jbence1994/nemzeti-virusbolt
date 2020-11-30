
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
            this.buttonLoadStocks = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStocks)).BeginInit();
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
            this.dataGridViewStocks.Size = new System.Drawing.Size(948, 532);
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
            // buttonLoadStocks
            // 
            this.buttonLoadStocks.Location = new System.Drawing.Point(0, 538);
            this.buttonLoadStocks.Name = "buttonLoadStocks";
            this.buttonLoadStocks.Size = new System.Drawing.Size(174, 23);
            this.buttonLoadStocks.TabIndex = 1;
            this.buttonLoadStocks.Text = "Raktárkészlet betöltése";
            this.buttonLoadStocks.UseVisualStyleBackColor = true;
            this.buttonLoadStocks.Click += new System.EventHandler(this.ButtonLoadStock_Click);
            // 
            // StockComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonLoadStocks);
            this.Controls.Add(this.dataGridViewStocks);
            this.Name = "StockComponent";
            this.Size = new System.Drawing.Size(948, 813);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStocks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewStocks;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStockId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStockProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStockQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStockRecordedDate;
        private System.Windows.Forms.Button buttonLoadStocks;
    }
}
