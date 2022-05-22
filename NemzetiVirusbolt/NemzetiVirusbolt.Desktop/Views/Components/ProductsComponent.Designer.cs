
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
            this.labelProductDescription = new System.Windows.Forms.Label();
            this.labelProductSupplier = new System.Windows.Forms.Label();
            this.labelProductUnit = new System.Windows.Forms.Label();
            this.labelProductPrice = new System.Windows.Forms.Label();
            this.labelProductName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).BeginInit();
            this.groupBoxAddProduct.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewProducts
            // 
            this.dataGridViewProducts.AllowUserToAddRows = false;
            this.dataGridViewProducts.AllowUserToDeleteRows = false;
            this.dataGridViewProducts.AllowUserToResizeRows = false;
            this.dataGridViewProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
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
            this.dataGridViewProducts.MultiSelect = false;
            this.dataGridViewProducts.Name = "dataGridViewProducts";
            this.dataGridViewProducts.ReadOnly = true;
            this.dataGridViewProducts.RowHeadersWidth = 51;
            this.dataGridViewProducts.RowTemplate.Height = 25;
            this.dataGridViewProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProducts.Size = new System.Drawing.Size(948, 532);
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
            this.textBoxProductDescription.Location = new System.Drawing.Point(154, 135);
            this.textBoxProductDescription.Name = "textBoxProductDescription";
            this.textBoxProductDescription.Size = new System.Drawing.Size(292, 23);
            this.textBoxProductDescription.TabIndex = 3;
            // 
            // buttonAddProduct
            // 
            this.buttonAddProduct.Enabled = false;
            this.buttonAddProduct.Location = new System.Drawing.Point(154, 193);
            this.buttonAddProduct.Name = "buttonAddProduct";
            this.buttonAddProduct.Size = new System.Drawing.Size(292, 23);
            this.buttonAddProduct.TabIndex = 5;
            this.buttonAddProduct.Text = "Termék rögzítése";
            this.buttonAddProduct.UseVisualStyleBackColor = true;
            this.buttonAddProduct.Click += new System.EventHandler(this.ButtonAddProduct_Click);
            // 
            // comboBoxSuppliers
            // 
            this.comboBoxSuppliers.DisplayMember = "Name";
            this.comboBoxSuppliers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSuppliers.FormattingEnabled = true;
            this.comboBoxSuppliers.Location = new System.Drawing.Point(154, 164);
            this.comboBoxSuppliers.Name = "comboBoxSuppliers";
            this.comboBoxSuppliers.Size = new System.Drawing.Size(292, 23);
            this.comboBoxSuppliers.TabIndex = 4;
            // 
            // textBoxProductUnit
            // 
            this.textBoxProductUnit.Location = new System.Drawing.Point(154, 106);
            this.textBoxProductUnit.Name = "textBoxProductUnit";
            this.textBoxProductUnit.Size = new System.Drawing.Size(292, 23);
            this.textBoxProductUnit.TabIndex = 2;
            // 
            // textBoxProductPrice
            // 
            this.textBoxProductPrice.Location = new System.Drawing.Point(154, 76);
            this.textBoxProductPrice.Name = "textBoxProductPrice";
            this.textBoxProductPrice.Size = new System.Drawing.Size(292, 23);
            this.textBoxProductPrice.TabIndex = 1;
            // 
            // textBoxProductName
            // 
            this.textBoxProductName.Location = new System.Drawing.Point(154, 48);
            this.textBoxProductName.Name = "textBoxProductName";
            this.textBoxProductName.Size = new System.Drawing.Size(292, 23);
            this.textBoxProductName.TabIndex = 0;
            // 
            // groupBoxAddProduct
            // 
            this.groupBoxAddProduct.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxAddProduct.Controls.Add(this.labelProductDescription);
            this.groupBoxAddProduct.Controls.Add(this.labelProductSupplier);
            this.groupBoxAddProduct.Controls.Add(this.labelProductUnit);
            this.groupBoxAddProduct.Controls.Add(this.labelProductPrice);
            this.groupBoxAddProduct.Controls.Add(this.labelProductName);
            this.groupBoxAddProduct.Controls.Add(this.textBoxProductName);
            this.groupBoxAddProduct.Controls.Add(this.textBoxProductPrice);
            this.groupBoxAddProduct.Controls.Add(this.buttonAddProduct);
            this.groupBoxAddProduct.Controls.Add(this.comboBoxSuppliers);
            this.groupBoxAddProduct.Controls.Add(this.textBoxProductUnit);
            this.groupBoxAddProduct.Controls.Add(this.textBoxProductDescription);
            this.groupBoxAddProduct.Location = new System.Drawing.Point(0, 538);
            this.groupBoxAddProduct.Name = "groupBoxAddProduct";
            this.groupBoxAddProduct.Size = new System.Drawing.Size(948, 275);
            this.groupBoxAddProduct.TabIndex = 8;
            this.groupBoxAddProduct.TabStop = false;
            this.groupBoxAddProduct.Text = "Termékfelvétel";
            // 
            // labelProductDescription
            // 
            this.labelProductDescription.AutoSize = true;
            this.labelProductDescription.Location = new System.Drawing.Point(111, 138);
            this.labelProductDescription.Name = "labelProductDescription";
            this.labelProductDescription.Size = new System.Drawing.Size(37, 15);
            this.labelProductDescription.TabIndex = 11;
            this.labelProductDescription.Text = "Leírás";
            // 
            // labelProductSupplier
            // 
            this.labelProductSupplier.AutoSize = true;
            this.labelProductSupplier.Location = new System.Drawing.Point(92, 167);
            this.labelProductSupplier.Name = "labelProductSupplier";
            this.labelProductSupplier.Size = new System.Drawing.Size(56, 15);
            this.labelProductSupplier.TabIndex = 10;
            this.labelProductSupplier.Text = "Beszállító";
            // 
            // labelProductUnit
            // 
            this.labelProductUnit.AutoSize = true;
            this.labelProductUnit.Location = new System.Drawing.Point(40, 109);
            this.labelProductUnit.Name = "labelProductUnit";
            this.labelProductUnit.Size = new System.Drawing.Size(108, 15);
            this.labelProductUnit.TabIndex = 9;
            this.labelProductUnit.Text = "Mennyiségi egység";
            // 
            // labelProductPrice
            // 
            this.labelProductPrice.AutoSize = true;
            this.labelProductPrice.Location = new System.Drawing.Point(94, 79);
            this.labelProductPrice.Name = "labelProductPrice";
            this.labelProductPrice.Size = new System.Drawing.Size(54, 15);
            this.labelProductPrice.TabIndex = 8;
            this.labelProductPrice.Text = "Egységár";
            // 
            // labelProductName
            // 
            this.labelProductName.AutoSize = true;
            this.labelProductName.Location = new System.Drawing.Point(120, 51);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new System.Drawing.Size(28, 15);
            this.labelProductName.TabIndex = 7;
            this.labelProductName.Text = "Név";
            // 
            // ProductsComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBoxAddProduct);
            this.Controls.Add(this.dataGridViewProducts);
            this.Name = "ProductsComponent";
            this.Size = new System.Drawing.Size(948, 813);
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
        private System.Windows.Forms.Label labelProductUnit;
        private System.Windows.Forms.Label labelProductPrice;
        private System.Windows.Forms.Label labelProductName;
        private System.Windows.Forms.Label labelProductSupplier;
        private System.Windows.Forms.Label labelProductDescription;
    }
}
