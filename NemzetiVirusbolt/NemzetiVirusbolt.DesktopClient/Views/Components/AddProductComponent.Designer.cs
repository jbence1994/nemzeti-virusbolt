using System.Windows.Forms;

namespace NemzetiVirusbolt.DesktopClient.Views.Components
{
    partial class AddProductComponent
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.itemNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplier = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.netPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grossPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.quantityBox = new System.Windows.Forms.TextBox();
            this.supplierBox = new System.Windows.Forms.TextBox();
            this.priceBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.supplierLabel = new System.Windows.Forms.Label();
            this.netPriceLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.descriptionBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Transparent;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.quantity,
            this.unit,
            this.itemNum,
            this.barCode,
            this.supplier,
            this.netPrice,
            this.grossPrice});
            this.dataGridView1.Location = new System.Drawing.Point(3, 2);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1173, 150);
            this.dataGridView1.TabIndex = 1;
            // 
            // name
            // 
            this.name.HeaderText = "Név";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.Width = 125;
            // 
            // quantity
            // 
            this.quantity.HeaderText = "Mennyiség";
            this.quantity.MinimumWidth = 6;
            this.quantity.Name = "quantity";
            this.quantity.Width = 125;
            // 
            // unit
            // 
            this.unit.HeaderText = "Mennyiségi egység";
            this.unit.Items.AddRange(new object[] {
            "darab",
            "csomag",
            "doboz"});
            this.unit.MinimumWidth = 6;
            this.unit.Name = "unit";
            this.unit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.unit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.unit.Width = 125;
            // 
            // itemNum
            // 
            this.itemNum.HeaderText = "Cikkszám";
            this.itemNum.MinimumWidth = 6;
            this.itemNum.Name = "itemNum";
            this.itemNum.Width = 125;
            // 
            // barCode
            // 
            this.barCode.HeaderText = "Vonalkód";
            this.barCode.MinimumWidth = 6;
            this.barCode.Name = "barCode";
            this.barCode.Width = 125;
            // 
            // supplier
            // 
            this.supplier.HeaderText = "Gyártó";
            this.supplier.MinimumWidth = 6;
            this.supplier.Name = "supplier";
            this.supplier.Width = 125;
            // 
            // netPrice
            // 
            this.netPrice.HeaderText = "Nettó ár (ft)";
            this.netPrice.MinimumWidth = 6;
            this.netPrice.Name = "netPrice";
            this.netPrice.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.netPrice.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.netPrice.Width = 125;
            // 
            // grossPrice
            // 
            this.grossPrice.HeaderText = "Bruttó ár (ft)";
            this.grossPrice.MinimumWidth = 6;
            this.grossPrice.Name = "grossPrice";
            this.grossPrice.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.grossPrice.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.grossPrice.Width = 125;
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(320, 204);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(248, 22);
            this.nameBox.TabIndex = 2;
            // 
            // quantityBox
            // 
            this.quantityBox.Location = new System.Drawing.Point(320, 252);
            this.quantityBox.Name = "quantityBox";
            this.quantityBox.Size = new System.Drawing.Size(248, 22);
            this.quantityBox.TabIndex = 3;
            // 
            // supplierBox
            // 
            this.supplierBox.Location = new System.Drawing.Point(320, 410);
            this.supplierBox.Name = "supplierBox";
            this.supplierBox.Size = new System.Drawing.Size(248, 22);
            this.supplierBox.TabIndex = 7;
            // 
            // priceBox
            // 
            this.priceBox.Location = new System.Drawing.Point(320, 304);
            this.priceBox.Name = "priceBox";
            this.priceBox.Size = new System.Drawing.Size(248, 22);
            this.priceBox.TabIndex = 8;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nameLabel.Location = new System.Drawing.Point(96, 206);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(41, 20);
            this.nameLabel.TabIndex = 10;
            this.nameLabel.Text = "Név";
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.quantityLabel.Location = new System.Drawing.Point(96, 254);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(98, 20);
            this.quantityLabel.TabIndex = 11;
            this.quantityLabel.Text = "Mennyiség";
            // 
            // supplierLabel
            // 
            this.supplierLabel.AutoSize = true;
            this.supplierLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.supplierLabel.Location = new System.Drawing.Point(96, 412);
            this.supplierLabel.Name = "supplierLabel";
            this.supplierLabel.Size = new System.Drawing.Size(65, 20);
            this.supplierLabel.TabIndex = 15;
            this.supplierLabel.Text = "Gyártó";
            // 
            // netPriceLabel
            // 
            this.netPriceLabel.AutoSize = true;
            this.netPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.netPriceLabel.Location = new System.Drawing.Point(96, 306);
            this.netPriceLabel.Name = "netPriceLabel";
            this.netPriceLabel.Size = new System.Drawing.Size(60, 20);
            this.netPriceLabel.TabIndex = 16;
            this.netPriceLabel.Text = "Ár (ft)";
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addButton.Location = new System.Drawing.Point(387, 504);
            this.addButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(107, 48);
            this.addButton.TabIndex = 18;
            this.addButton.Text = "Hozzáad";
            this.addButton.UseVisualStyleBackColor = true;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.descriptionLabel.Location = new System.Drawing.Point(94, 358);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(62, 20);
            this.descriptionLabel.TabIndex = 19;
            this.descriptionLabel.Text = "Leírás";
            // 
            // descriptionBox
            // 
            this.descriptionBox.Location = new System.Drawing.Point(320, 356);
            this.descriptionBox.Name = "descriptionBox";
            this.descriptionBox.Size = new System.Drawing.Size(248, 22);
            this.descriptionBox.TabIndex = 20;
            // 
            // AddProductComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.descriptionBox);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.netPriceLabel);
            this.Controls.Add(this.supplierLabel);
            this.Controls.Add(this.quantityLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.priceBox);
            this.Controls.Add(this.supplierBox);
            this.Controls.Add(this.quantityBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddProductComponent";
            this.Size = new System.Drawing.Size(1179, 679);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewComboBoxColumn unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn barCode;
        private System.Windows.Forms.DataGridViewComboBoxColumn supplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn netPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn grossPrice;
        private TextBox nameBox;
        private TextBox quantityBox;
        private TextBox supplierBox;
        private TextBox priceBox;
        private Label nameLabel;
        private Label quantityLabel;
        private Label supplierLabel;
        private Label netPriceLabel;
        private Button addButton;
        private Label descriptionLabel;
        private TextBox descriptionBox;

        // private AddProductComponent item = (AddProductComponent)DataGridView.CurrentRow.DataBoundItem;


    }       
}
