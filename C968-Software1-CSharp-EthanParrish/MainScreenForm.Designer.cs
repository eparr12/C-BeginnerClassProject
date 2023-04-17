namespace C968_Software1_CSharp_EthanParrish
{
    partial class MainScreenForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreenForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.inventoryManagementSystemLabel = new System.Windows.Forms.Label();
            this.partsLabel = new System.Windows.Forms.Label();
            this.partsGridView = new System.Windows.Forms.DataGridView();
            this.addPartsButton = new System.Windows.Forms.Button();
            this.modifyPartsButton = new System.Windows.Forms.Button();
            this.deletePartsButton = new System.Windows.Forms.Button();
            this.searchPartsTextBox = new System.Windows.Forms.TextBox();
            this.searchProductsTextBox = new System.Windows.Forms.TextBox();
            this.deleteProductsButton = new System.Windows.Forms.Button();
            this.modifyProductsButton = new System.Windows.Forms.Button();
            this.addProductsButton = new System.Windows.Forms.Button();
            this.productsLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.productsGridView = new System.Windows.Forms.DataGridView();
            this.productsSearchLabel = new System.Windows.Forms.Label();
            this.partsSearchLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.partsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // inventoryManagementSystemLabel
            // 
            resources.ApplyResources(this.inventoryManagementSystemLabel, "inventoryManagementSystemLabel");
            this.inventoryManagementSystemLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.inventoryManagementSystemLabel.Name = "inventoryManagementSystemLabel";
            // 
            // partsLabel
            // 
            resources.ApplyResources(this.partsLabel, "partsLabel");
            this.partsLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.partsLabel.Name = "partsLabel";
            // 
            // partsGridView
            // 
            this.partsGridView.AllowUserToDeleteRows = false;
            this.partsGridView.BackgroundColor = System.Drawing.Color.White;
            this.partsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.partsGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.partsGridView.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            resources.ApplyResources(this.partsGridView, "partsGridView");
            this.partsGridView.MultiSelect = false;
            this.partsGridView.Name = "partsGridView";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partsGridView.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.partsGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partsGridView.RowTemplate.Height = 26;
            this.partsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // 
            // addPartsButton
            // 
            this.addPartsButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.addPartsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.addPartsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            resources.ApplyResources(this.addPartsButton, "addPartsButton");
            this.addPartsButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.addPartsButton.Name = "addPartsButton";
            this.addPartsButton.UseVisualStyleBackColor = true;
            this.addPartsButton.Click += new System.EventHandler(this.addPartsButton_Click);
            // 
            // modifyPartsButton
            // 
            resources.ApplyResources(this.modifyPartsButton, "modifyPartsButton");
            this.modifyPartsButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.modifyPartsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.modifyPartsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.modifyPartsButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.modifyPartsButton.Name = "modifyPartsButton";
            this.modifyPartsButton.UseVisualStyleBackColor = true;
            this.modifyPartsButton.Click += new System.EventHandler(this.modifyPartsButton_Click);
            // 
            // deletePartsButton
            // 
            resources.ApplyResources(this.deletePartsButton, "deletePartsButton");
            this.deletePartsButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.deletePartsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.deletePartsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.deletePartsButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.deletePartsButton.Name = "deletePartsButton";
            this.deletePartsButton.UseVisualStyleBackColor = true;
            this.deletePartsButton.Click += new System.EventHandler(this.deletePartsButton_Click);
            // 
            // searchPartsTextBox
            // 
            resources.ApplyResources(this.searchPartsTextBox, "searchPartsTextBox");
            this.searchPartsTextBox.Name = "searchPartsTextBox";
            this.searchPartsTextBox.TextChanged += new System.EventHandler(this.searchPartsTextBox_TextChanged);
            // 
            // searchProductsTextBox
            // 
            resources.ApplyResources(this.searchProductsTextBox, "searchProductsTextBox");
            this.searchProductsTextBox.Name = "searchProductsTextBox";
            this.searchProductsTextBox.TextChanged += new System.EventHandler(this.searchProductsTextBox_TextChanged);
            // 
            // deleteProductsButton
            // 
            resources.ApplyResources(this.deleteProductsButton, "deleteProductsButton");
            this.deleteProductsButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.deleteProductsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.deleteProductsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.deleteProductsButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.deleteProductsButton.Name = "deleteProductsButton";
            this.deleteProductsButton.UseVisualStyleBackColor = true;
            this.deleteProductsButton.Click += new System.EventHandler(this.deleteProductsButton_Click);
            // 
            // modifyProductsButton
            // 
            resources.ApplyResources(this.modifyProductsButton, "modifyProductsButton");
            this.modifyProductsButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.modifyProductsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.modifyProductsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.modifyProductsButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.modifyProductsButton.Name = "modifyProductsButton";
            this.modifyProductsButton.UseVisualStyleBackColor = true;
            this.modifyProductsButton.Click += new System.EventHandler(this.modifyProductsButton_Click);
            // 
            // addProductsButton
            // 
            this.addProductsButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.addProductsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.addProductsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            resources.ApplyResources(this.addProductsButton, "addProductsButton");
            this.addProductsButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.addProductsButton.Name = "addProductsButton";
            this.addProductsButton.UseVisualStyleBackColor = true;
            this.addProductsButton.Click += new System.EventHandler(this.addProductsButton_Click);
            // 
            // productsLabel
            // 
            resources.ApplyResources(this.productsLabel, "productsLabel");
            this.productsLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.productsLabel.Name = "productsLabel";
            // 
            // exitButton
            // 
            this.exitButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.exitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.exitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            resources.ApplyResources(this.exitButton, "exitButton");
            this.exitButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.exitButton.Name = "exitButton";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // productsGridView
            // 
            this.productsGridView.AllowUserToAddRows = false;
            this.productsGridView.AllowUserToDeleteRows = false;
            this.productsGridView.BackgroundColor = System.Drawing.Color.White;
            this.productsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.productsGridView.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            resources.ApplyResources(this.productsGridView, "productsGridView");
            this.productsGridView.MultiSelect = false;
            this.productsGridView.Name = "productsGridView";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productsGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.productsGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productsGridView.RowTemplate.Height = 26;
            this.productsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // 
            // productsSearchLabel
            // 
            resources.ApplyResources(this.productsSearchLabel, "productsSearchLabel");
            this.productsSearchLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.productsSearchLabel.Name = "productsSearchLabel";
            // 
            // partsSearchLabel
            // 
            resources.ApplyResources(this.partsSearchLabel, "partsSearchLabel");
            this.partsSearchLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.partsSearchLabel.Name = "partsSearchLabel";
            // 
            // MainScreenForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.partsSearchLabel);
            this.Controls.Add(this.productsSearchLabel);
            this.Controls.Add(this.productsGridView);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.searchProductsTextBox);
            this.Controls.Add(this.deleteProductsButton);
            this.Controls.Add(this.modifyProductsButton);
            this.Controls.Add(this.addProductsButton);
            this.Controls.Add(this.productsLabel);
            this.Controls.Add(this.searchPartsTextBox);
            this.Controls.Add(this.deletePartsButton);
            this.Controls.Add(this.modifyPartsButton);
            this.Controls.Add(this.addPartsButton);
            this.Controls.Add(this.partsGridView);
            this.Controls.Add(this.partsLabel);
            this.Controls.Add(this.inventoryManagementSystemLabel);
            this.Name = "MainScreenForm";
            this.Load += new System.EventHandler(this.MainScreenForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.partsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label inventoryManagementSystemLabel;
        private System.Windows.Forms.Label partsLabel;
        private System.Windows.Forms.DataGridView partsGridView;
        private System.Windows.Forms.Button addPartsButton;
        private System.Windows.Forms.Button modifyPartsButton;
        private System.Windows.Forms.Button deletePartsButton;
        private System.Windows.Forms.TextBox searchPartsTextBox;
        private System.Windows.Forms.TextBox searchProductsTextBox;
        private System.Windows.Forms.Button deleteProductsButton;
        private System.Windows.Forms.Button modifyProductsButton;
        private System.Windows.Forms.Button addProductsButton;
        private System.Windows.Forms.Label productsLabel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.DataGridView productsGridView;
        private System.Windows.Forms.Label productsSearchLabel;
        private System.Windows.Forms.Label partsSearchLabel;
    }
}