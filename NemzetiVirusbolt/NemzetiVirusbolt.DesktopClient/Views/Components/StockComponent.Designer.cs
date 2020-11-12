namespace NemzetiVirusbolt.DesktopClient.Views.Components
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.descriptionBox = new System.Windows.Forms.TextBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.netPriceLabel = new System.Windows.Forms.Label();
            this.supplierLabel = new System.Windows.Forms.Label();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.priceBox = new System.Windows.Forms.TextBox();
            this.supplierBox = new System.Windows.Forms.TextBox();
            this.quantityBox = new System.Windows.Forms.TextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStock)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewStock
            // 
            this.dataGridViewStock.AllowUserToAddRows = false;
            this.dataGridViewStock.AllowUserToDeleteRows = false;
            this.dataGridViewStock.AllowUserToOrderColumns = true;
            this.dataGridViewStock.AllowUserToResizeRows = false;
            this.dataGridViewStock.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStock.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewStock.MultiSelect = false;
            this.dataGridViewStock.Name = "dataGridViewStock";
            this.dataGridViewStock.ReadOnly = true;
            this.dataGridViewStock.RowHeadersWidth = 51;
            this.dataGridViewStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewStock.Size = new System.Drawing.Size(811, 361);
            this.dataGridViewStock.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.descriptionBox);
            this.panel1.Controls.Add(this.descriptionLabel);
            this.panel1.Controls.Add(this.addButton);
            this.panel1.Controls.Add(this.netPriceLabel);
            this.panel1.Controls.Add(this.supplierLabel);
            this.panel1.Controls.Add(this.quantityLabel);
            this.panel1.Controls.Add(this.nameLabel);
            this.panel1.Controls.Add(this.priceBox);
            this.panel1.Controls.Add(this.supplierBox);
            this.panel1.Controls.Add(this.quantityBox);
            this.panel1.Controls.Add(this.nameBox);
            this.panel1.Location = new System.Drawing.Point(3, 367);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(805, 333);
            this.panel1.TabIndex = 1;
            // 
            // descriptionBox
            // 
            this.descriptionBox.Location = new System.Drawing.Point(185, 147);
            this.descriptionBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.descriptionBox.Name = "descriptionBox";
            this.descriptionBox.Size = new System.Drawing.Size(187, 20);
            this.descriptionBox.TabIndex = 31;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.descriptionLabel.Location = new System.Drawing.Point(16, 149);
            this.descriptionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(53, 17);
            this.descriptionLabel.TabIndex = 30;
            this.descriptionLabel.Text = "Leírás";
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addButton.Location = new System.Drawing.Point(236, 267);
            this.addButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(80, 39);
            this.addButton.TabIndex = 29;
            this.addButton.Text = "Hozzáad";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // netPriceLabel
            // 
            this.netPriceLabel.AutoSize = true;
            this.netPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.netPriceLabel.Location = new System.Drawing.Point(17, 106);
            this.netPriceLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.netPriceLabel.Name = "netPriceLabel";
            this.netPriceLabel.Size = new System.Drawing.Size(51, 17);
            this.netPriceLabel.TabIndex = 28;
            this.netPriceLabel.Text = "Ár (ft)";
            // 
            // supplierLabel
            // 
            this.supplierLabel.AutoSize = true;
            this.supplierLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.supplierLabel.Location = new System.Drawing.Point(17, 193);
            this.supplierLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.supplierLabel.Name = "supplierLabel";
            this.supplierLabel.Size = new System.Drawing.Size(57, 17);
            this.supplierLabel.TabIndex = 27;
            this.supplierLabel.Text = "Gyártó";
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.quantityLabel.Location = new System.Drawing.Point(17, 64);
            this.quantityLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(85, 17);
            this.quantityLabel.TabIndex = 26;
            this.quantityLabel.Text = "Mennyiség";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nameLabel.Location = new System.Drawing.Point(17, 25);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(36, 17);
            this.nameLabel.TabIndex = 25;
            this.nameLabel.Text = "Név";
            // 
            // priceBox
            // 
            this.priceBox.Location = new System.Drawing.Point(185, 105);
            this.priceBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.priceBox.Name = "priceBox";
            this.priceBox.Size = new System.Drawing.Size(187, 20);
            this.priceBox.TabIndex = 24;
            // 
            // supplierBox
            // 
            this.supplierBox.Location = new System.Drawing.Point(185, 191);
            this.supplierBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.supplierBox.Name = "supplierBox";
            this.supplierBox.Size = new System.Drawing.Size(187, 20);
            this.supplierBox.TabIndex = 23;
            // 
            // quantityBox
            // 
            this.quantityBox.Location = new System.Drawing.Point(185, 63);
            this.quantityBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.quantityBox.Name = "quantityBox";
            this.quantityBox.Size = new System.Drawing.Size(187, 20);
            this.quantityBox.TabIndex = 22;
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(185, 24);
            this.nameBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(187, 20);
            this.nameBox.TabIndex = 21;
            // 
            // StockComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridViewStock);
            this.Name = "StockComponent";
            this.Size = new System.Drawing.Size(811, 703);
            this.Load += new System.EventHandler(this.StockComponent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStock)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewStock;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox descriptionBox;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label netPriceLabel;
        private System.Windows.Forms.Label supplierLabel;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox priceBox;
        private System.Windows.Forms.TextBox supplierBox;
        private System.Windows.Forms.TextBox quantityBox;
        private System.Windows.Forms.TextBox nameBox;
    }
}
