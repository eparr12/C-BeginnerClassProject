namespace C968_Software1_CSharp_EthanParrish
{
    partial class ModifyProductForm
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
            this.modifyProductsDeleteButton = new System.Windows.Forms.Button();
            this.modifyProductsCancelButton = new System.Windows.Forms.Button();
            this.modifyProductsSaveButton = new System.Windows.Forms.Button();
            this.modifyProductsAssociatedGridView = new System.Windows.Forms.DataGridView();
            this.modifyProductsAddButton = new System.Windows.Forms.Button();
            this.modifyProductsCandidateGridView = new System.Windows.Forms.DataGridView();
            this.associatedProductsLabel = new System.Windows.Forms.Label();
            this.searchModifyProductsTextBox = new System.Windows.Forms.TextBox();
            this.candidatePartsLabel = new System.Windows.Forms.Label();
            this.minLabel = new System.Windows.Forms.Label();
            this.maxLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.inventoryLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.modifyProductMinTextBox = new System.Windows.Forms.TextBox();
            this.modifyProductMaxTextBox = new System.Windows.Forms.TextBox();
            this.modifyProductInventoryTextBox = new System.Windows.Forms.TextBox();
            this.modifyProductPriceTextBox = new System.Windows.Forms.TextBox();
            this.modifyProductNameTextBox = new System.Windows.Forms.TextBox();
            this.modifyProductIDTextBox = new System.Windows.Forms.TextBox();
            this.modifyProductLabel = new System.Windows.Forms.Label();
            this.partsSearchLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.modifyProductsAssociatedGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modifyProductsCandidateGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // modifyProductsDeleteButton
            // 
            this.modifyProductsDeleteButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.modifyProductsDeleteButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.modifyProductsDeleteButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.modifyProductsDeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modifyProductsDeleteButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F);
            this.modifyProductsDeleteButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.modifyProductsDeleteButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.modifyProductsDeleteButton.Location = new System.Drawing.Point(1277, 742);
            this.modifyProductsDeleteButton.Name = "modifyProductsDeleteButton";
            this.modifyProductsDeleteButton.Size = new System.Drawing.Size(128, 47);
            this.modifyProductsDeleteButton.TabIndex = 81;
            this.modifyProductsDeleteButton.Text = "Delete";
            this.modifyProductsDeleteButton.UseVisualStyleBackColor = true;
            this.modifyProductsDeleteButton.Click += new System.EventHandler(this.modifyProductsButton_Click);
            // 
            // modifyProductsCancelButton
            // 
            this.modifyProductsCancelButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.modifyProductsCancelButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.modifyProductsCancelButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.modifyProductsCancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modifyProductsCancelButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F);
            this.modifyProductsCancelButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.modifyProductsCancelButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.modifyProductsCancelButton.Location = new System.Drawing.Point(1277, 811);
            this.modifyProductsCancelButton.Name = "modifyProductsCancelButton";
            this.modifyProductsCancelButton.Size = new System.Drawing.Size(128, 47);
            this.modifyProductsCancelButton.TabIndex = 80;
            this.modifyProductsCancelButton.Text = "Cancel";
            this.modifyProductsCancelButton.UseVisualStyleBackColor = true;
            this.modifyProductsCancelButton.Click += new System.EventHandler(this.modifyProductsCancelButton_Click);
            // 
            // modifyProductsSaveButton
            // 
            this.modifyProductsSaveButton.Enabled = false;
            this.modifyProductsSaveButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.modifyProductsSaveButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.modifyProductsSaveButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.modifyProductsSaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modifyProductsSaveButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F);
            this.modifyProductsSaveButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.modifyProductsSaveButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.modifyProductsSaveButton.Location = new System.Drawing.Point(1134, 811);
            this.modifyProductsSaveButton.Name = "modifyProductsSaveButton";
            this.modifyProductsSaveButton.Size = new System.Drawing.Size(128, 47);
            this.modifyProductsSaveButton.TabIndex = 79;
            this.modifyProductsSaveButton.Text = "Save";
            this.modifyProductsSaveButton.UseVisualStyleBackColor = true;
            this.modifyProductsSaveButton.Click += new System.EventHandler(this.modifyProductsSaveButton_Click);
            // 
            // modifyProductsAssociatedGridView
            // 
            this.modifyProductsAssociatedGridView.AllowUserToAddRows = false;
            this.modifyProductsAssociatedGridView.AllowUserToDeleteRows = false;
            this.modifyProductsAssociatedGridView.BackgroundColor = System.Drawing.Color.White;
            this.modifyProductsAssociatedGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.modifyProductsAssociatedGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.modifyProductsAssociatedGridView.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.modifyProductsAssociatedGridView.Location = new System.Drawing.Point(753, 493);
            this.modifyProductsAssociatedGridView.MultiSelect = false;
            this.modifyProductsAssociatedGridView.Name = "modifyProductsAssociatedGridView";
            this.modifyProductsAssociatedGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyProductsAssociatedGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.modifyProductsAssociatedGridView.Size = new System.Drawing.Size(652, 228);
            this.modifyProductsAssociatedGridView.TabIndex = 78;
            // 
            // modifyProductsAddButton
            // 
            this.modifyProductsAddButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.modifyProductsAddButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.modifyProductsAddButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.modifyProductsAddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modifyProductsAddButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F);
            this.modifyProductsAddButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.modifyProductsAddButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.modifyProductsAddButton.Location = new System.Drawing.Point(1277, 361);
            this.modifyProductsAddButton.Name = "modifyProductsAddButton";
            this.modifyProductsAddButton.Size = new System.Drawing.Size(128, 47);
            this.modifyProductsAddButton.TabIndex = 77;
            this.modifyProductsAddButton.Text = "Add";
            this.modifyProductsAddButton.UseVisualStyleBackColor = true;
            this.modifyProductsAddButton.Click += new System.EventHandler(this.modifyProductsAddButton_Click);
            // 
            // modifyProductsCandidateGridView
            // 
            this.modifyProductsCandidateGridView.AllowUserToAddRows = false;
            this.modifyProductsCandidateGridView.AllowUserToDeleteRows = false;
            this.modifyProductsCandidateGridView.BackgroundColor = System.Drawing.Color.White;
            this.modifyProductsCandidateGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.modifyProductsCandidateGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.modifyProductsCandidateGridView.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.modifyProductsCandidateGridView.Location = new System.Drawing.Point(753, 117);
            this.modifyProductsCandidateGridView.MultiSelect = false;
            this.modifyProductsCandidateGridView.Name = "modifyProductsCandidateGridView";
            this.modifyProductsCandidateGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyProductsCandidateGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.modifyProductsCandidateGridView.Size = new System.Drawing.Size(652, 228);
            this.modifyProductsCandidateGridView.TabIndex = 76;
            // 
            // associatedProductsLabel
            // 
            this.associatedProductsLabel.AutoSize = true;
            this.associatedProductsLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F);
            this.associatedProductsLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.associatedProductsLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.associatedProductsLabel.Location = new System.Drawing.Point(746, 453);
            this.associatedProductsLabel.Name = "associatedProductsLabel";
            this.associatedProductsLabel.Size = new System.Drawing.Size(424, 37);
            this.associatedProductsLabel.TabIndex = 75;
            this.associatedProductsLabel.Text = "Parts Associated With This Product";
            // 
            // searchModifyProductsTextBox
            // 
            this.searchModifyProductsTextBox.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.searchModifyProductsTextBox.Location = new System.Drawing.Point(1146, 43);
            this.searchModifyProductsTextBox.Name = "searchModifyProductsTextBox";
            this.searchModifyProductsTextBox.Size = new System.Drawing.Size(259, 35);
            this.searchModifyProductsTextBox.TabIndex = 74;
            this.searchModifyProductsTextBox.TextChanged += new System.EventHandler(this.searchModifyProductsTextBox_TextChanged);
            // 
            // candidatePartsLabel
            // 
            this.candidatePartsLabel.AutoSize = true;
            this.candidatePartsLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F);
            this.candidatePartsLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.candidatePartsLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.candidatePartsLabel.Location = new System.Drawing.Point(746, 77);
            this.candidatePartsLabel.Name = "candidatePartsLabel";
            this.candidatePartsLabel.Size = new System.Drawing.Size(241, 37);
            this.candidatePartsLabel.TabIndex = 72;
            this.candidatePartsLabel.Text = "All Candidate Parts";
            // 
            // minLabel
            // 
            this.minLabel.AutoSize = true;
            this.minLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F);
            this.minLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.minLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.minLabel.Location = new System.Drawing.Point(423, 518);
            this.minLabel.Name = "minLabel";
            this.minLabel.Size = new System.Drawing.Size(63, 37);
            this.minLabel.TabIndex = 71;
            this.minLabel.Text = "Min";
            // 
            // maxLabel
            // 
            this.maxLabel.AutoSize = true;
            this.maxLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F);
            this.maxLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.maxLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.maxLabel.Location = new System.Drawing.Point(175, 518);
            this.maxLabel.Name = "maxLabel";
            this.maxLabel.Size = new System.Drawing.Size(67, 37);
            this.maxLabel.TabIndex = 70;
            this.maxLabel.Text = "Max";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F);
            this.priceLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.priceLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.priceLabel.Location = new System.Drawing.Point(168, 459);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(74, 37);
            this.priceLabel.TabIndex = 69;
            this.priceLabel.Text = "Price";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F);
            this.nameLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.nameLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.nameLabel.Location = new System.Drawing.Point(154, 341);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(88, 37);
            this.nameLabel.TabIndex = 68;
            this.nameLabel.Text = "Name";
            // 
            // inventoryLabel
            // 
            this.inventoryLabel.AutoSize = true;
            this.inventoryLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F);
            this.inventoryLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.inventoryLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.inventoryLabel.Location = new System.Drawing.Point(114, 400);
            this.inventoryLabel.Name = "inventoryLabel";
            this.inventoryLabel.Size = new System.Drawing.Size(128, 37);
            this.inventoryLabel.TabIndex = 67;
            this.inventoryLabel.Text = "Inventory";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F);
            this.idLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.idLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.idLabel.Location = new System.Drawing.Point(199, 282);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(43, 37);
            this.idLabel.TabIndex = 66;
            this.idLabel.Text = "ID";
            // 
            // modifyProductMinTextBox
            // 
            this.modifyProductMinTextBox.BackColor = System.Drawing.Color.Salmon;
            this.modifyProductMinTextBox.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.modifyProductMinTextBox.Location = new System.Drawing.Point(512, 521);
            this.modifyProductMinTextBox.Name = "modifyProductMinTextBox";
            this.modifyProductMinTextBox.Size = new System.Drawing.Size(111, 35);
            this.modifyProductMinTextBox.TabIndex = 65;
            this.modifyProductMinTextBox.TextChanged += new System.EventHandler(this.modifyProductMinTextBox_TextChanged);
            // 
            // modifyProductMaxTextBox
            // 
            this.modifyProductMaxTextBox.BackColor = System.Drawing.Color.Salmon;
            this.modifyProductMaxTextBox.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.modifyProductMaxTextBox.Location = new System.Drawing.Point(276, 521);
            this.modifyProductMaxTextBox.Name = "modifyProductMaxTextBox";
            this.modifyProductMaxTextBox.Size = new System.Drawing.Size(111, 35);
            this.modifyProductMaxTextBox.TabIndex = 64;
            this.modifyProductMaxTextBox.TextChanged += new System.EventHandler(this.modifyProductMaxTextBox_TextChanged);
            // 
            // modifyProductInventoryTextBox
            // 
            this.modifyProductInventoryTextBox.BackColor = System.Drawing.Color.Salmon;
            this.modifyProductInventoryTextBox.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.modifyProductInventoryTextBox.Location = new System.Drawing.Point(276, 403);
            this.modifyProductInventoryTextBox.Name = "modifyProductInventoryTextBox";
            this.modifyProductInventoryTextBox.Size = new System.Drawing.Size(210, 35);
            this.modifyProductInventoryTextBox.TabIndex = 63;
            this.modifyProductInventoryTextBox.TextChanged += new System.EventHandler(this.modifyProductInventoryTextBox_TextChanged);
            // 
            // modifyProductPriceTextBox
            // 
            this.modifyProductPriceTextBox.BackColor = System.Drawing.Color.Salmon;
            this.modifyProductPriceTextBox.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.modifyProductPriceTextBox.Location = new System.Drawing.Point(276, 462);
            this.modifyProductPriceTextBox.Name = "modifyProductPriceTextBox";
            this.modifyProductPriceTextBox.Size = new System.Drawing.Size(210, 35);
            this.modifyProductPriceTextBox.TabIndex = 62;
            this.modifyProductPriceTextBox.TextChanged += new System.EventHandler(this.modifyProductPriceTextBox_TextChanged);
            // 
            // modifyProductNameTextBox
            // 
            this.modifyProductNameTextBox.BackColor = System.Drawing.Color.Salmon;
            this.modifyProductNameTextBox.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.modifyProductNameTextBox.Location = new System.Drawing.Point(276, 344);
            this.modifyProductNameTextBox.Name = "modifyProductNameTextBox";
            this.modifyProductNameTextBox.Size = new System.Drawing.Size(210, 35);
            this.modifyProductNameTextBox.TabIndex = 61;
            this.modifyProductNameTextBox.TextChanged += new System.EventHandler(this.modifyProductNameTextBox_TextChanged);
            // 
            // modifyProductIDTextBox
            // 
            this.modifyProductIDTextBox.Enabled = false;
            this.modifyProductIDTextBox.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.modifyProductIDTextBox.Location = new System.Drawing.Point(276, 285);
            this.modifyProductIDTextBox.Name = "modifyProductIDTextBox";
            this.modifyProductIDTextBox.Size = new System.Drawing.Size(210, 35);
            this.modifyProductIDTextBox.TabIndex = 60;
            // 
            // modifyProductLabel
            // 
            this.modifyProductLabel.AutoSize = true;
            this.modifyProductLabel.Font = new System.Drawing.Font("Segoe UI Light", 27.75F);
            this.modifyProductLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.modifyProductLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.modifyProductLabel.Location = new System.Drawing.Point(4, 5);
            this.modifyProductLabel.Name = "modifyProductLabel";
            this.modifyProductLabel.Size = new System.Drawing.Size(261, 50);
            this.modifyProductLabel.TabIndex = 59;
            this.modifyProductLabel.Text = "Modify Product";
            // 
            // partsSearchLabel
            // 
            this.partsSearchLabel.AutoSize = true;
            this.partsSearchLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F);
            this.partsSearchLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.partsSearchLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.partsSearchLabel.Location = new System.Drawing.Point(1017, 40);
            this.partsSearchLabel.Name = "partsSearchLabel";
            this.partsSearchLabel.Size = new System.Drawing.Size(95, 37);
            this.partsSearchLabel.TabIndex = 82;
            this.partsSearchLabel.Text = "Search";
            // 
            // ModifyProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1496, 880);
            this.Controls.Add(this.partsSearchLabel);
            this.Controls.Add(this.modifyProductsDeleteButton);
            this.Controls.Add(this.modifyProductsCancelButton);
            this.Controls.Add(this.modifyProductsSaveButton);
            this.Controls.Add(this.modifyProductsAssociatedGridView);
            this.Controls.Add(this.modifyProductsAddButton);
            this.Controls.Add(this.modifyProductsCandidateGridView);
            this.Controls.Add(this.associatedProductsLabel);
            this.Controls.Add(this.searchModifyProductsTextBox);
            this.Controls.Add(this.candidatePartsLabel);
            this.Controls.Add(this.minLabel);
            this.Controls.Add(this.maxLabel);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.inventoryLabel);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.modifyProductMinTextBox);
            this.Controls.Add(this.modifyProductMaxTextBox);
            this.Controls.Add(this.modifyProductInventoryTextBox);
            this.Controls.Add(this.modifyProductPriceTextBox);
            this.Controls.Add(this.modifyProductNameTextBox);
            this.Controls.Add(this.modifyProductIDTextBox);
            this.Controls.Add(this.modifyProductLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "ModifyProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product";
            this.Load += new System.EventHandler(this.ModifyProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.modifyProductsAssociatedGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modifyProductsCandidateGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button modifyProductsDeleteButton;
        private System.Windows.Forms.Button modifyProductsCancelButton;
        private System.Windows.Forms.Button modifyProductsSaveButton;
        private System.Windows.Forms.DataGridView modifyProductsAssociatedGridView;
        private System.Windows.Forms.Button modifyProductsAddButton;
        private System.Windows.Forms.DataGridView modifyProductsCandidateGridView;
        private System.Windows.Forms.Label associatedProductsLabel;
        private System.Windows.Forms.TextBox searchModifyProductsTextBox;
        private System.Windows.Forms.Label candidatePartsLabel;
        private System.Windows.Forms.Label minLabel;
        private System.Windows.Forms.Label maxLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label inventoryLabel;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.TextBox modifyProductMinTextBox;
        private System.Windows.Forms.TextBox modifyProductMaxTextBox;
        private System.Windows.Forms.TextBox modifyProductInventoryTextBox;
        private System.Windows.Forms.TextBox modifyProductPriceTextBox;
        private System.Windows.Forms.TextBox modifyProductNameTextBox;
        private System.Windows.Forms.TextBox modifyProductIDTextBox;
        private System.Windows.Forms.Label modifyProductLabel;
        private System.Windows.Forms.Label partsSearchLabel;
    }
}