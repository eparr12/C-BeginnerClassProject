namespace C968_Software1_CSharp_EthanParrish
{
    partial class AddProductForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.minLabel = new System.Windows.Forms.Label();
            this.maxLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.inventoryLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.addProductMinTextBox = new System.Windows.Forms.TextBox();
            this.addProductMaxTextBox = new System.Windows.Forms.TextBox();
            this.addProductInventoryTextBox = new System.Windows.Forms.TextBox();
            this.addProductPriceTextBox = new System.Windows.Forms.TextBox();
            this.addProductNameTextBox = new System.Windows.Forms.TextBox();
            this.addProductIDTextBox = new System.Windows.Forms.TextBox();
            this.addProductLabel = new System.Windows.Forms.Label();
            this.searchAddProductsTextBox = new System.Windows.Forms.TextBox();
            this.candidatePartsLabel = new System.Windows.Forms.Label();
            this.associatedProductsLabel = new System.Windows.Forms.Label();
            this.addProductsAddButton = new System.Windows.Forms.Button();
            this.addProductsCandidateGridView = new System.Windows.Forms.DataGridView();
            this.addProductsDeleteButton = new System.Windows.Forms.Button();
            this.addProductsCancelButton = new System.Windows.Forms.Button();
            this.addProductsSaveButton = new System.Windows.Forms.Button();
            this.addProductsAssociatedGridView = new System.Windows.Forms.DataGridView();
            this.partsSearchLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.addProductsCandidateGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addProductsAssociatedGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // minLabel
            // 
            this.minLabel.AutoSize = true;
            this.minLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F);
            this.minLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.minLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.minLabel.Location = new System.Drawing.Point(426, 521);
            this.minLabel.Name = "minLabel";
            this.minLabel.Size = new System.Drawing.Size(63, 37);
            this.minLabel.TabIndex = 37;
            this.minLabel.Text = "Min";
            // 
            // maxLabel
            // 
            this.maxLabel.AutoSize = true;
            this.maxLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F);
            this.maxLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.maxLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.maxLabel.Location = new System.Drawing.Point(178, 521);
            this.maxLabel.Name = "maxLabel";
            this.maxLabel.Size = new System.Drawing.Size(67, 37);
            this.maxLabel.TabIndex = 36;
            this.maxLabel.Text = "Max";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F);
            this.priceLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.priceLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.priceLabel.Location = new System.Drawing.Point(171, 462);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(74, 37);
            this.priceLabel.TabIndex = 35;
            this.priceLabel.Text = "Price";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F);
            this.nameLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.nameLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.nameLabel.Location = new System.Drawing.Point(157, 344);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(88, 37);
            this.nameLabel.TabIndex = 34;
            this.nameLabel.Text = "Name";
            // 
            // inventoryLabel
            // 
            this.inventoryLabel.AutoSize = true;
            this.inventoryLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F);
            this.inventoryLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.inventoryLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.inventoryLabel.Location = new System.Drawing.Point(117, 403);
            this.inventoryLabel.Name = "inventoryLabel";
            this.inventoryLabel.Size = new System.Drawing.Size(128, 37);
            this.inventoryLabel.TabIndex = 33;
            this.inventoryLabel.Text = "Inventory";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F);
            this.idLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.idLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.idLabel.Location = new System.Drawing.Point(202, 285);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(43, 37);
            this.idLabel.TabIndex = 32;
            this.idLabel.Text = "ID";
            // 
            // addProductMinTextBox
            // 
            this.addProductMinTextBox.BackColor = System.Drawing.Color.Salmon;
            this.addProductMinTextBox.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.addProductMinTextBox.Location = new System.Drawing.Point(515, 524);
            this.addProductMinTextBox.Name = "addProductMinTextBox";
            this.addProductMinTextBox.Size = new System.Drawing.Size(111, 35);
            this.addProductMinTextBox.TabIndex = 31;
            this.addProductMinTextBox.TextChanged += new System.EventHandler(this.addProductMinTextBox_TextChanged);
            // 
            // addProductMaxTextBox
            // 
            this.addProductMaxTextBox.BackColor = System.Drawing.Color.Salmon;
            this.addProductMaxTextBox.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.addProductMaxTextBox.Location = new System.Drawing.Point(279, 524);
            this.addProductMaxTextBox.Name = "addProductMaxTextBox";
            this.addProductMaxTextBox.Size = new System.Drawing.Size(111, 35);
            this.addProductMaxTextBox.TabIndex = 30;
            this.addProductMaxTextBox.TextChanged += new System.EventHandler(this.addProductMaxTextBox_TextChanged);
            // 
            // addProductInventoryTextBox
            // 
            this.addProductInventoryTextBox.BackColor = System.Drawing.Color.Salmon;
            this.addProductInventoryTextBox.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.addProductInventoryTextBox.Location = new System.Drawing.Point(279, 406);
            this.addProductInventoryTextBox.Name = "addProductInventoryTextBox";
            this.addProductInventoryTextBox.Size = new System.Drawing.Size(210, 35);
            this.addProductInventoryTextBox.TabIndex = 29;
            this.addProductInventoryTextBox.TextChanged += new System.EventHandler(this.addProductInventoryTextBox_TextChanged);
            // 
            // addProductPriceTextBox
            // 
            this.addProductPriceTextBox.BackColor = System.Drawing.Color.Salmon;
            this.addProductPriceTextBox.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.addProductPriceTextBox.Location = new System.Drawing.Point(279, 465);
            this.addProductPriceTextBox.Name = "addProductPriceTextBox";
            this.addProductPriceTextBox.Size = new System.Drawing.Size(210, 35);
            this.addProductPriceTextBox.TabIndex = 28;
            this.addProductPriceTextBox.TextChanged += new System.EventHandler(this.addProductPriceTextBox_TextChanged);
            // 
            // addProductNameTextBox
            // 
            this.addProductNameTextBox.BackColor = System.Drawing.Color.Salmon;
            this.addProductNameTextBox.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.addProductNameTextBox.Location = new System.Drawing.Point(279, 347);
            this.addProductNameTextBox.Name = "addProductNameTextBox";
            this.addProductNameTextBox.Size = new System.Drawing.Size(210, 35);
            this.addProductNameTextBox.TabIndex = 27;
            this.addProductNameTextBox.TextChanged += new System.EventHandler(this.addProductNameTextBox_TextChanged);
            // 
            // addProductIDTextBox
            // 
            this.addProductIDTextBox.Enabled = false;
            this.addProductIDTextBox.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.addProductIDTextBox.Location = new System.Drawing.Point(279, 288);
            this.addProductIDTextBox.Name = "addProductIDTextBox";
            this.addProductIDTextBox.Size = new System.Drawing.Size(210, 35);
            this.addProductIDTextBox.TabIndex = 26;
            // 
            // addProductLabel
            // 
            this.addProductLabel.AutoSize = true;
            this.addProductLabel.Font = new System.Drawing.Font("Segoe UI Light", 27.75F);
            this.addProductLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.addProductLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.addProductLabel.Location = new System.Drawing.Point(7, 8);
            this.addProductLabel.Name = "addProductLabel";
            this.addProductLabel.Size = new System.Drawing.Size(217, 50);
            this.addProductLabel.TabIndex = 24;
            this.addProductLabel.Text = "Add Product";
            // 
            // searchAddProductsTextBox
            // 
            this.searchAddProductsTextBox.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.searchAddProductsTextBox.Location = new System.Drawing.Point(1149, 46);
            this.searchAddProductsTextBox.Name = "searchAddProductsTextBox";
            this.searchAddProductsTextBox.Size = new System.Drawing.Size(259, 35);
            this.searchAddProductsTextBox.TabIndex = 44;
            this.searchAddProductsTextBox.TextChanged += new System.EventHandler(this.searchAddProductsTextBox_TextChanged);
            // 
            // candidatePartsLabel
            // 
            this.candidatePartsLabel.AutoSize = true;
            this.candidatePartsLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F);
            this.candidatePartsLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.candidatePartsLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.candidatePartsLabel.Location = new System.Drawing.Point(749, 80);
            this.candidatePartsLabel.Name = "candidatePartsLabel";
            this.candidatePartsLabel.Size = new System.Drawing.Size(241, 37);
            this.candidatePartsLabel.TabIndex = 38;
            this.candidatePartsLabel.Text = "All Candidate Parts";
            // 
            // associatedProductsLabel
            // 
            this.associatedProductsLabel.AutoSize = true;
            this.associatedProductsLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F);
            this.associatedProductsLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.associatedProductsLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.associatedProductsLabel.Location = new System.Drawing.Point(749, 456);
            this.associatedProductsLabel.Name = "associatedProductsLabel";
            this.associatedProductsLabel.Size = new System.Drawing.Size(424, 37);
            this.associatedProductsLabel.TabIndex = 45;
            this.associatedProductsLabel.Text = "Parts Associated With This Product";
            // 
            // addProductsAddButton
            // 
            this.addProductsAddButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.addProductsAddButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.addProductsAddButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.addProductsAddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addProductsAddButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F);
            this.addProductsAddButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.addProductsAddButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.addProductsAddButton.Location = new System.Drawing.Point(1280, 364);
            this.addProductsAddButton.Name = "addProductsAddButton";
            this.addProductsAddButton.Size = new System.Drawing.Size(128, 47);
            this.addProductsAddButton.TabIndex = 52;
            this.addProductsAddButton.Text = "Add";
            this.addProductsAddButton.UseVisualStyleBackColor = true;
            this.addProductsAddButton.Click += new System.EventHandler(this.addProductsAddButton_Click);
            // 
            // addProductsCandidateGridView
            // 
            this.addProductsCandidateGridView.AllowUserToAddRows = false;
            this.addProductsCandidateGridView.AllowUserToDeleteRows = false;
            this.addProductsCandidateGridView.BackgroundColor = System.Drawing.Color.White;
            this.addProductsCandidateGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.addProductsCandidateGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.addProductsCandidateGridView.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.addProductsCandidateGridView.Location = new System.Drawing.Point(756, 120);
            this.addProductsCandidateGridView.MultiSelect = false;
            this.addProductsCandidateGridView.Name = "addProductsCandidateGridView";
            this.addProductsCandidateGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProductsCandidateGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.addProductsCandidateGridView.Size = new System.Drawing.Size(652, 228);
            this.addProductsCandidateGridView.TabIndex = 51;
            // 
            // addProductsDeleteButton
            // 
            this.addProductsDeleteButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.addProductsDeleteButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.addProductsDeleteButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.addProductsDeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addProductsDeleteButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F);
            this.addProductsDeleteButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.addProductsDeleteButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.addProductsDeleteButton.Location = new System.Drawing.Point(1280, 745);
            this.addProductsDeleteButton.Name = "addProductsDeleteButton";
            this.addProductsDeleteButton.Size = new System.Drawing.Size(128, 47);
            this.addProductsDeleteButton.TabIndex = 58;
            this.addProductsDeleteButton.Text = "Delete";
            this.addProductsDeleteButton.UseVisualStyleBackColor = true;
            this.addProductsDeleteButton.Click += new System.EventHandler(this.addProductsButton_Click);
            // 
            // addProductsCancelButton
            // 
            this.addProductsCancelButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.addProductsCancelButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.addProductsCancelButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.addProductsCancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addProductsCancelButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F);
            this.addProductsCancelButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.addProductsCancelButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.addProductsCancelButton.Location = new System.Drawing.Point(1280, 814);
            this.addProductsCancelButton.Name = "addProductsCancelButton";
            this.addProductsCancelButton.Size = new System.Drawing.Size(128, 47);
            this.addProductsCancelButton.TabIndex = 57;
            this.addProductsCancelButton.Text = "Cancel";
            this.addProductsCancelButton.UseVisualStyleBackColor = true;
            this.addProductsCancelButton.Click += new System.EventHandler(this.addProductsCancelButton_Click);
            // 
            // addProductsSaveButton
            // 
            this.addProductsSaveButton.Enabled = false;
            this.addProductsSaveButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.addProductsSaveButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.addProductsSaveButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.addProductsSaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addProductsSaveButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F);
            this.addProductsSaveButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.addProductsSaveButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.addProductsSaveButton.Location = new System.Drawing.Point(1137, 814);
            this.addProductsSaveButton.Name = "addProductsSaveButton";
            this.addProductsSaveButton.Size = new System.Drawing.Size(128, 47);
            this.addProductsSaveButton.TabIndex = 56;
            this.addProductsSaveButton.Text = "Save";
            this.addProductsSaveButton.UseVisualStyleBackColor = true;
            this.addProductsSaveButton.Click += new System.EventHandler(this.addProductsSaveButton_Click);
            // 
            // addProductsAssociatedGridView
            // 
            this.addProductsAssociatedGridView.AllowUserToAddRows = false;
            this.addProductsAssociatedGridView.AllowUserToDeleteRows = false;
            this.addProductsAssociatedGridView.BackgroundColor = System.Drawing.Color.White;
            this.addProductsAssociatedGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.addProductsAssociatedGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.addProductsAssociatedGridView.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.addProductsAssociatedGridView.Location = new System.Drawing.Point(756, 496);
            this.addProductsAssociatedGridView.MultiSelect = false;
            this.addProductsAssociatedGridView.Name = "addProductsAssociatedGridView";
            this.addProductsAssociatedGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProductsAssociatedGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.addProductsAssociatedGridView.Size = new System.Drawing.Size(652, 228);
            this.addProductsAssociatedGridView.TabIndex = 55;
            // 
            // partsSearchLabel
            // 
            this.partsSearchLabel.AutoSize = true;
            this.partsSearchLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F);
            this.partsSearchLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.partsSearchLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.partsSearchLabel.Location = new System.Drawing.Point(1017, 43);
            this.partsSearchLabel.Name = "partsSearchLabel";
            this.partsSearchLabel.Size = new System.Drawing.Size(95, 37);
            this.partsSearchLabel.TabIndex = 59;
            this.partsSearchLabel.Text = "Search";
            // 
            // AddProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1496, 880);
            this.Controls.Add(this.partsSearchLabel);
            this.Controls.Add(this.addProductsDeleteButton);
            this.Controls.Add(this.addProductsCancelButton);
            this.Controls.Add(this.addProductsSaveButton);
            this.Controls.Add(this.addProductsAssociatedGridView);
            this.Controls.Add(this.addProductsAddButton);
            this.Controls.Add(this.addProductsCandidateGridView);
            this.Controls.Add(this.associatedProductsLabel);
            this.Controls.Add(this.searchAddProductsTextBox);
            this.Controls.Add(this.candidatePartsLabel);
            this.Controls.Add(this.minLabel);
            this.Controls.Add(this.maxLabel);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.inventoryLabel);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.addProductMinTextBox);
            this.Controls.Add(this.addProductMaxTextBox);
            this.Controls.Add(this.addProductInventoryTextBox);
            this.Controls.Add(this.addProductPriceTextBox);
            this.Controls.Add(this.addProductNameTextBox);
            this.Controls.Add(this.addProductIDTextBox);
            this.Controls.Add(this.addProductLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "AddProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product";
            this.Load += new System.EventHandler(this.AddProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.addProductsCandidateGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addProductsAssociatedGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label minLabel;
        private System.Windows.Forms.Label maxLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label inventoryLabel;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.TextBox addProductMinTextBox;
        private System.Windows.Forms.TextBox addProductMaxTextBox;
        private System.Windows.Forms.TextBox addProductInventoryTextBox;
        private System.Windows.Forms.TextBox addProductPriceTextBox;
        private System.Windows.Forms.TextBox addProductNameTextBox;
        private System.Windows.Forms.TextBox addProductIDTextBox;
        private System.Windows.Forms.Label addProductLabel;
        private System.Windows.Forms.TextBox searchAddProductsTextBox;
        private System.Windows.Forms.Label candidatePartsLabel;
        private System.Windows.Forms.Label associatedProductsLabel;
        private System.Windows.Forms.Button addProductsAddButton;
        private System.Windows.Forms.DataGridView addProductsCandidateGridView;
        private System.Windows.Forms.Button addProductsDeleteButton;
        private System.Windows.Forms.Button addProductsCancelButton;
        private System.Windows.Forms.Button addProductsSaveButton;
        private System.Windows.Forms.DataGridView addProductsAssociatedGridView;
        private System.Windows.Forms.Label partsSearchLabel;
    }
}