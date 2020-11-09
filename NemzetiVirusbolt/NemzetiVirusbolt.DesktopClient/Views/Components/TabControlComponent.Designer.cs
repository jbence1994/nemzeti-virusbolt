namespace NemzetiVirusbolt.DesktopClient.Views.Components
{
    partial class TabControlComponent
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageStock = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.deleteButton = new System.Windows.Forms.Button();
            this.modifyButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchLabel = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.itemNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplier = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.netPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grossPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addButton = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageStock);
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1092, 897);
            this.tabControl.TabIndex = 0;
            // 
            // tabPageStock
            // 
            this.tabPageStock.Location = new System.Drawing.Point(4, 25);
            this.tabPageStock.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageStock.Name = "tabPageStock";
            this.tabPageStock.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageStock.Size = new System.Drawing.Size(1084, 868);
            this.tabPageStock.TabIndex = 0;
            this.tabPageStock.Text = "Raktárkészlet";
            this.tabPageStock.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.addButton);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(1084, 868);
            this.tabPage1.TabIndex = 1;
            this.tabPage1.Text = "Új termék felvétele";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
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
            this.dataGridView1.Location = new System.Drawing.Point(6, 71);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1047, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.deleteButton);
            this.tabPage2.Controls.Add(this.modifyButton);
            this.tabPage2.Controls.Add(this.searchButton);
            this.tabPage2.Controls.Add(this.searchTextBox);
            this.tabPage2.Controls.Add(this.searchLabel);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1084, 868);
            this.tabPage2.TabIndex = 2;
            this.tabPage2.Text = "Keresés";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(674, 131);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 5;
            this.deleteButton.Text = "Töröl";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // modifyButton
            // 
            this.modifyButton.Location = new System.Drawing.Point(566, 131);
            this.modifyButton.Name = "modifyButton";
            this.modifyButton.Size = new System.Drawing.Size(75, 23);
            this.modifyButton.TabIndex = 4;
            this.modifyButton.Text = "Módosít";
            this.modifyButton.UseVisualStyleBackColor = true;
            this.modifyButton.Click += new System.EventHandler(this.modifyButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(448, 24);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 31);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "Keres";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(132, 28);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(284, 22);
            this.searchTextBox.TabIndex = 1;
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Location = new System.Drawing.Point(52, 31);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(64, 17);
            this.searchLabel.TabIndex = 0;
            this.searchLabel.Text = "Keresés:";
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1084, 868);
            this.tabPage3.TabIndex = 3;
            // 
            // name
            // 
            this.name.HeaderText = "Név";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 125;
            // 
            // quantity
            // 
            this.quantity.HeaderText = "Mennyiség";
            this.quantity.MinimumWidth = 6;
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            this.quantity.Width = 125;
            // 
            // unit
            // 
            this.unit.HeaderText = "Mennyiségi egység";
            this.unit.MinimumWidth = 6;
            this.unit.Name = "unit";
            this.unit.ReadOnly = true;
            this.unit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.unit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.unit.Width = 125;
            // 
            // itemNum
            // 
            this.itemNum.HeaderText = "Cikkszám";
            this.itemNum.MinimumWidth = 6;
            this.itemNum.Name = "itemNum";
            this.itemNum.ReadOnly = true;
            this.itemNum.Width = 125;
            // 
            // barCode
            // 
            this.barCode.HeaderText = "Vonalkód";
            this.barCode.MinimumWidth = 6;
            this.barCode.Name = "barCode";
            this.barCode.ReadOnly = true;
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
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(957, 272);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "Hozzáad";
            this.addButton.UseVisualStyleBackColor = true;
            // 
            // TabControlComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TabControlComponent";
            this.Size = new System.Drawing.Size(1092, 897);
            this.Load += new System.EventHandler(this.TabControlComponent_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageStock;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button modifyButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewComboBoxColumn unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn barCode;
        private System.Windows.Forms.DataGridViewComboBoxColumn supplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn netPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn grossPrice;
        private System.Windows.Forms.Button addButton;
    }
}
