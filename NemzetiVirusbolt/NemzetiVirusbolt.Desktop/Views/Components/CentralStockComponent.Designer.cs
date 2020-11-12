namespace NemzetiVirusbolt.Desktop.Views.Components
{
    partial class CentralStockComponent
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
            this.buttonUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonUpdate.Location = new System.Drawing.Point(3, 677);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdate.TabIndex = 1;
            this.buttonUpdate.Text = "Frissítés";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.ButtonUpdate_Click);
            // 
            // CentralStockComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.dataGridViewCentralStock);
            this.Name = "CentralStockComponent";
            this.Size = new System.Drawing.Size(811, 703);
            this.Load += new System.EventHandler(this.CentralStockComponent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCentralStock)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewCentralStock;
        private System.Windows.Forms.Button buttonUpdate;
    }
}
