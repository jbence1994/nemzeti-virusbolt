
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
            this.dataGridViewProducts = new System.Windows.Forms.DataGridView();
            this.ColumnProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnProductPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnProductUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnProductDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSupplierName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxProductDescription = new System.Windows.Forms.TextBox();
            this.buttonAddProduct = new System.Windows.Forms.Button();
            this.comboBoxSuppliers = new System.Windows.Forms.ComboBox();
            this.textBoxProductUnit = new System.Windows.Forms.TextBox();
            this.textBoxProductPrice = new System.Windows.Forms.TextBox();
            this.textBoxProductName = new System.Windows.Forms.TextBox();
            this.groupBoxAddProduct = new System.Windows.Forms.GroupBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.unitLabel = new System.Windows.Forms.Label();
            this.supplierLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).BeginInit();
            this.groupBoxAddProduct.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewProducts
            // 
            this.dataGridViewProducts.AllowUserToAddRows = false;
            this.dataGridViewProducts.AllowUserToDeleteRows = false;
            this.dataGridViewProducts.AllowUserToResizeRows = false;
            this.dataGridViewProducts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewProducts.BackgroundColor = System.Drawing.SystemColors.AppWorkspace;
            this.dataGridViewProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnProductId,
            this.ColumnProductName,
            this.ColumnProductPrice,
            this.ColumnProductUnit,
            this.ColumnProductDescription,
            this.ColumnSupplierName});
            this.dataGridViewProducts.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewProducts.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridViewProducts.MultiSelect = false;
            this.dataGridViewProducts.Name = "dataGridViewProducts";
            this.dataGridViewProducts.ReadOnly = true;
            this.dataGridViewProducts.RowHeadersWidth = 51;
            this.dataGridViewProducts.RowTemplate.Height = 25;
            this.dataGridViewProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProducts.Size = new System.Drawing.Size(1083, 709);
            this.dataGridViewProducts.TabIndex = 6;
            // 
            // ColumnProductId
            // 
            this.ColumnProductId.DataPropertyName = "Id";
            this.ColumnProductId.HeaderText = "Azonosító";
            this.ColumnProductId.MinimumWidth = 6;
            this.ColumnProductId.Name = "ColumnProductId";
            this.ColumnProductId.ReadOnly = true;
            // 
            // ColumnProductName
            // 
            this.ColumnProductName.DataPropertyName = "Name";
            this.ColumnProductName.HeaderText = "Név";
            this.ColumnProductName.MinimumWidth = 6;
            this.ColumnProductName.Name = "ColumnProductName";
            this.ColumnProductName.ReadOnly = true;
            // 
            // ColumnProductPrice
            // 
            this.ColumnProductPrice.DataPropertyName = "Price";
            this.ColumnProductPrice.HeaderText = "Egységár";
            this.ColumnProductPrice.MinimumWidth = 6;
            this.ColumnProductPrice.Name = "ColumnProductPrice";
            this.ColumnProductPrice.ReadOnly = true;
            // 
            // ColumnProductUnit
            // 
            this.ColumnProductUnit.DataPropertyName = "Unit";
            this.ColumnProductUnit.HeaderText = "Mennyiségi egység";
            this.ColumnProductUnit.MinimumWidth = 6;
            this.ColumnProductUnit.Name = "ColumnProductUnit";
            this.ColumnProductUnit.ReadOnly = true;
            // 
            // ColumnProductDescription
            // 
            this.ColumnProductDescription.DataPropertyName = "Description";
            this.ColumnProductDescription.HeaderText = "Leírás";
            this.ColumnProductDescription.MinimumWidth = 6;
            this.ColumnProductDescription.Name = "ColumnProductDescription";
            this.ColumnProductDescription.ReadOnly = true;
            // 
            // ColumnSupplierName
            // 
            this.ColumnSupplierName.DataPropertyName = "SupplierName";
            this.ColumnSupplierName.HeaderText = "Beszállító";
            this.ColumnSupplierName.MinimumWidth = 6;
            this.ColumnSupplierName.Name = "ColumnSupplierName";
            this.ColumnSupplierName.ReadOnly = true;
            // 
            // textBoxProductDescription
            // 
            this.textBoxProductDescription.Location = new System.Drawing.Point(176, 180);
            this.textBoxProductDescription.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxProductDescription.Name = "textBoxProductDescription";
            this.textBoxProductDescription.Size = new System.Drawing.Size(333, 27);
            this.textBoxProductDescription.TabIndex = 3;
            // 
            // buttonAddProduct
            // 
            this.buttonAddProduct.Enabled = false;
            this.buttonAddProduct.Location = new System.Drawing.Point(176, 257);
            this.buttonAddProduct.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonAddProduct.Name = "buttonAddProduct";
            this.buttonAddProduct.Size = new System.Drawing.Size(334, 31);
            this.buttonAddProduct.TabIndex = 5;
            this.buttonAddProduct.Text = "Rögzítés";
            this.buttonAddProduct.UseVisualStyleBackColor = true;
            this.buttonAddProduct.Click += new System.EventHandler(this.ButtonAddProduct_Click);
            // 
            // comboBoxSuppliers
            // 
            this.comboBoxSuppliers.DisplayMember = "Name";
            this.comboBoxSuppliers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSuppliers.FormattingEnabled = true;
            this.comboBoxSuppliers.Location = new System.Drawing.Point(176, 218);
            this.comboBoxSuppliers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxSuppliers.Name = "comboBoxSuppliers";
            this.comboBoxSuppliers.Size = new System.Drawing.Size(333, 28);
            this.comboBoxSuppliers.TabIndex = 4;
            // 
            // textBoxProductUnit
            // 
            this.textBoxProductUnit.Location = new System.Drawing.Point(176, 141);
            this.textBoxProductUnit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxProductUnit.Name = "textBoxProductUnit";
            this.textBoxProductUnit.Size = new System.Drawing.Size(333, 27);
            this.textBoxProductUnit.TabIndex = 2;
            // 
            // textBoxProductPrice
            // 
            this.textBoxProductPrice.Location = new System.Drawing.Point(176, 102);
            this.textBoxProductPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxProductPrice.Name = "textBoxProductPrice";
            this.textBoxProductPrice.Size = new System.Drawing.Size(333, 27);
            this.textBoxProductPrice.TabIndex = 1;
            // 
            // textBoxProductName
            // 
            this.textBoxProductName.Location = new System.Drawing.Point(176, 64);
            this.textBoxProductName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxProductName.Name = "textBoxProductName";
            this.textBoxProductName.Size = new System.Drawing.Size(333, 27);
            this.textBoxProductName.TabIndex = 0;
            // 
            // groupBoxAddProduct
            // 
            this.groupBoxAddProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxAddProduct.Controls.Add(this.descriptionLabel);
            this.groupBoxAddProduct.Controls.Add(this.supplierLabel);
            this.groupBoxAddProduct.Controls.Add(this.unitLabel);
            this.groupBoxAddProduct.Controls.Add(this.priceLabel);
            this.groupBoxAddProduct.Controls.Add(this.nameLabel);
            this.groupBoxAddProduct.Controls.Add(this.textBoxProductName);
            this.groupBoxAddProduct.Controls.Add(this.textBoxProductPrice);
            this.groupBoxAddProduct.Controls.Add(this.buttonAddProduct);
            this.groupBoxAddProduct.Controls.Add(this.comboBoxSuppliers);
            this.groupBoxAddProduct.Controls.Add(this.textBoxProductUnit);
            this.groupBoxAddProduct.Controls.Add(this.textBoxProductDescription);
            this.groupBoxAddProduct.Location = new System.Drawing.Point(545, 717);
            this.groupBoxAddProduct.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxAddProduct.Name = "groupBoxAddProduct";
            this.groupBoxAddProduct.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxAddProduct.Size = new System.Drawing.Size(538, 367);
            this.groupBoxAddProduct.TabIndex = 8;
            this.groupBoxAddProduct.TabStop = false;
            this.groupBoxAddProduct.Text = "Termékfelvétel";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(15, 70);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(35, 20);
            this.nameLabel.TabIndex = 7;
            this.nameLabel.Text = "Név";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(15, 109);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(69, 20);
            this.priceLabel.TabIndex = 8;
            this.priceLabel.Text = "Egységár";
            // 
            // unitLabel
            // 
            this.unitLabel.AutoSize = true;
            this.unitLabel.Location = new System.Drawing.Point(15, 148);
            this.unitLabel.Name = "unitLabel";
            this.unitLabel.Size = new System.Drawing.Size(135, 20);
            this.unitLabel.TabIndex = 9;
            this.unitLabel.Text = "Mennyiségi egység";
            // 
            // supplierLabel
            // 
            this.supplierLabel.AutoSize = true;
            this.supplierLabel.Location = new System.Drawing.Point(15, 226);
            this.supplierLabel.Name = "supplierLabel";
            this.supplierLabel.Size = new System.Drawing.Size(73, 20);
            this.supplierLabel.TabIndex = 10;
            this.supplierLabel.Text = "Beszállító";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(15, 187);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(47, 20);
            this.descriptionLabel.TabIndex = 11;
            this.descriptionLabel.Text = "Leírás";
            // 
            // ProductsComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBoxAddProduct);
            this.Controls.Add(this.dataGridViewProducts);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ProductsComponent";
            this.Size = new System.Drawing.Size(1083, 1084);
            this.Load += new System.EventHandler(this.ProductsComponent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).EndInit();
            this.groupBoxAddProduct.ResumeLayout(false);
            this.groupBoxAddProduct.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewProducts;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnProductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnProductPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnProductUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnProductDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSupplierName;
        private System.Windows.Forms.TextBox textBoxProductDescription;
        private System.Windows.Forms.Button buttonAddProduct;
        private System.Windows.Forms.ComboBox comboBoxSuppliers;
        private System.Windows.Forms.TextBox textBoxProductUnit;
        private System.Windows.Forms.TextBox textBoxProductPrice;
        private System.Windows.Forms.TextBox textBoxProductName;
        private System.Windows.Forms.GroupBox groupBoxAddProduct;
        private System.Windows.Forms.Label unitLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label supplierLabel;
        private System.Windows.Forms.Label descriptionLabel;
    }
}
