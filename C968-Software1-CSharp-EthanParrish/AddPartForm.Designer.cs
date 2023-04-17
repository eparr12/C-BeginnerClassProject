namespace C968_Software1_CSharp_EthanParrish
{
    partial class AddPartForm
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
            this.addPartLabel = new System.Windows.Forms.Label();
            this.addPartInHouseRadioButton = new System.Windows.Forms.RadioButton();
            this.addPartOutsourcedRadioButton = new System.Windows.Forms.RadioButton();
            this.addPartTypePanel = new System.Windows.Forms.Panel();
            this.addPartIDTextBox = new System.Windows.Forms.TextBox();
            this.addPartNameTextBox = new System.Windows.Forms.TextBox();
            this.addPartPriceCostTextBox = new System.Windows.Forms.TextBox();
            this.addPartInventoryTextBox = new System.Windows.Forms.TextBox();
            this.addCompanyMachineIDTextBox = new System.Windows.Forms.TextBox();
            this.addPartMinTextBox = new System.Windows.Forms.TextBox();
            this.addPartMaxTextBox = new System.Windows.Forms.TextBox();
            this.idLabel = new System.Windows.Forms.Label();
            this.inventoryLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.priceCostLabel = new System.Windows.Forms.Label();
            this.maxLabel = new System.Windows.Forms.Label();
            this.minLabel = new System.Windows.Forms.Label();
            this.addCompanyMachineIDLabel = new System.Windows.Forms.Label();
            this.cancelAddPartsButton = new System.Windows.Forms.Button();
            this.saveAddPartsButton = new System.Windows.Forms.Button();
            this.addPartTypePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // addPartLabel
            // 
            this.addPartLabel.AutoSize = true;
            this.addPartLabel.Font = new System.Drawing.Font("Segoe UI Light", 27.75F);
            this.addPartLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.addPartLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.addPartLabel.Location = new System.Drawing.Point(12, 9);
            this.addPartLabel.Name = "addPartLabel";
            this.addPartLabel.Size = new System.Drawing.Size(158, 50);
            this.addPartLabel.TabIndex = 2;
            this.addPartLabel.Text = "Add Part";
            // 
            // addPartInHouseRadioButton
            // 
            this.addPartInHouseRadioButton.AutoSize = true;
            this.addPartInHouseRadioButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.addPartInHouseRadioButton.Location = new System.Drawing.Point(24, 5);
            this.addPartInHouseRadioButton.Name = "addPartInHouseRadioButton";
            this.addPartInHouseRadioButton.Size = new System.Drawing.Size(116, 34);
            this.addPartInHouseRadioButton.TabIndex = 3;
            this.addPartInHouseRadioButton.TabStop = true;
            this.addPartInHouseRadioButton.Text = "In-House";
            this.addPartInHouseRadioButton.UseVisualStyleBackColor = true;
            // 
            // addPartOutsourcedRadioButton
            // 
            this.addPartOutsourcedRadioButton.AutoSize = true;
            this.addPartOutsourcedRadioButton.Checked = true;
            this.addPartOutsourcedRadioButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.addPartOutsourcedRadioButton.Location = new System.Drawing.Point(200, 5);
            this.addPartOutsourcedRadioButton.Name = "addPartOutsourcedRadioButton";
            this.addPartOutsourcedRadioButton.Size = new System.Drawing.Size(139, 34);
            this.addPartOutsourcedRadioButton.TabIndex = 4;
            this.addPartOutsourcedRadioButton.TabStop = true;
            this.addPartOutsourcedRadioButton.Text = "Outsourced";
            this.addPartOutsourcedRadioButton.UseVisualStyleBackColor = true;
            this.addPartOutsourcedRadioButton.CheckedChanged += new System.EventHandler(this.addPartOutsourcedRadioButton_CheckedChanged);
            // 
            // addPartTypePanel
            // 
            this.addPartTypePanel.Controls.Add(this.addPartOutsourcedRadioButton);
            this.addPartTypePanel.Controls.Add(this.addPartInHouseRadioButton);
            this.addPartTypePanel.Location = new System.Drawing.Point(257, 18);
            this.addPartTypePanel.Name = "addPartTypePanel";
            this.addPartTypePanel.Size = new System.Drawing.Size(337, 41);
            this.addPartTypePanel.TabIndex = 5;
            // 
            // addPartIDTextBox
            // 
            this.addPartIDTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.addPartIDTextBox.Enabled = false;
            this.addPartIDTextBox.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.addPartIDTextBox.Location = new System.Drawing.Point(280, 109);
            this.addPartIDTextBox.Name = "addPartIDTextBox";
            this.addPartIDTextBox.Size = new System.Drawing.Size(210, 35);
            this.addPartIDTextBox.TabIndex = 9;
            // 
            // addPartNameTextBox
            // 
            this.addPartNameTextBox.BackColor = System.Drawing.Color.Salmon;
            this.addPartNameTextBox.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.addPartNameTextBox.Location = new System.Drawing.Point(280, 168);
            this.addPartNameTextBox.Name = "addPartNameTextBox";
            this.addPartNameTextBox.Size = new System.Drawing.Size(210, 35);
            this.addPartNameTextBox.TabIndex = 10;
            this.addPartNameTextBox.TextChanged += new System.EventHandler(this.addPartNameTextBox_TextChanged);
            // 
            // addPartPriceCostTextBox
            // 
            this.addPartPriceCostTextBox.BackColor = System.Drawing.Color.Salmon;
            this.addPartPriceCostTextBox.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.addPartPriceCostTextBox.Location = new System.Drawing.Point(280, 286);
            this.addPartPriceCostTextBox.Name = "addPartPriceCostTextBox";
            this.addPartPriceCostTextBox.Size = new System.Drawing.Size(210, 35);
            this.addPartPriceCostTextBox.TabIndex = 11;
            this.addPartPriceCostTextBox.TextChanged += new System.EventHandler(this.addPartPriceCostTextBox_TextChanged);
            // 
            // addPartInventoryTextBox
            // 
            this.addPartInventoryTextBox.BackColor = System.Drawing.Color.Salmon;
            this.addPartInventoryTextBox.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.addPartInventoryTextBox.Location = new System.Drawing.Point(280, 227);
            this.addPartInventoryTextBox.Name = "addPartInventoryTextBox";
            this.addPartInventoryTextBox.Size = new System.Drawing.Size(210, 35);
            this.addPartInventoryTextBox.TabIndex = 12;
            this.addPartInventoryTextBox.TextChanged += new System.EventHandler(this.addPartInventoryTextBox_TextChanged);
            // 
            // addCompanyMachineIDTextBox
            // 
            this.addCompanyMachineIDTextBox.BackColor = System.Drawing.Color.Salmon;
            this.addCompanyMachineIDTextBox.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.addCompanyMachineIDTextBox.Location = new System.Drawing.Point(280, 404);
            this.addCompanyMachineIDTextBox.Name = "addCompanyMachineIDTextBox";
            this.addCompanyMachineIDTextBox.Size = new System.Drawing.Size(210, 35);
            this.addCompanyMachineIDTextBox.TabIndex = 13;
            this.addCompanyMachineIDTextBox.TextChanged += new System.EventHandler(this.addCompanyMachineIDTextBox_TextChanged);
            // 
            // addPartMinTextBox
            // 
            this.addPartMinTextBox.BackColor = System.Drawing.Color.Salmon;
            this.addPartMinTextBox.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.addPartMinTextBox.Location = new System.Drawing.Point(516, 345);
            this.addPartMinTextBox.Name = "addPartMinTextBox";
            this.addPartMinTextBox.Size = new System.Drawing.Size(111, 35);
            this.addPartMinTextBox.TabIndex = 17;
            this.addPartMinTextBox.TextChanged += new System.EventHandler(this.addPartMinTextBox_TextChanged);
            // 
            // addPartMaxTextBox
            // 
            this.addPartMaxTextBox.BackColor = System.Drawing.Color.Salmon;
            this.addPartMaxTextBox.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.addPartMaxTextBox.Location = new System.Drawing.Point(280, 345);
            this.addPartMaxTextBox.Name = "addPartMaxTextBox";
            this.addPartMaxTextBox.Size = new System.Drawing.Size(111, 35);
            this.addPartMaxTextBox.TabIndex = 16;
            this.addPartMaxTextBox.TextChanged += new System.EventHandler(this.addPartMaxTextBox_TextChanged);
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F);
            this.idLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.idLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.idLabel.Location = new System.Drawing.Point(203, 106);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(43, 37);
            this.idLabel.TabIndex = 18;
            this.idLabel.Text = "ID";
            // 
            // inventoryLabel
            // 
            this.inventoryLabel.AutoSize = true;
            this.inventoryLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F);
            this.inventoryLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.inventoryLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.inventoryLabel.Location = new System.Drawing.Point(118, 224);
            this.inventoryLabel.Name = "inventoryLabel";
            this.inventoryLabel.Size = new System.Drawing.Size(128, 37);
            this.inventoryLabel.TabIndex = 19;
            this.inventoryLabel.Text = "Inventory";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F);
            this.nameLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.nameLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.nameLabel.Location = new System.Drawing.Point(158, 165);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(88, 37);
            this.nameLabel.TabIndex = 20;
            this.nameLabel.Text = "Name";
            // 
            // priceCostLabel
            // 
            this.priceCostLabel.AutoSize = true;
            this.priceCostLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F);
            this.priceCostLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.priceCostLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.priceCostLabel.Location = new System.Drawing.Point(94, 283);
            this.priceCostLabel.Name = "priceCostLabel";
            this.priceCostLabel.Size = new System.Drawing.Size(152, 37);
            this.priceCostLabel.TabIndex = 21;
            this.priceCostLabel.Text = "Price / Cost";
            // 
            // maxLabel
            // 
            this.maxLabel.AutoSize = true;
            this.maxLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F);
            this.maxLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.maxLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.maxLabel.Location = new System.Drawing.Point(179, 342);
            this.maxLabel.Name = "maxLabel";
            this.maxLabel.Size = new System.Drawing.Size(67, 37);
            this.maxLabel.TabIndex = 22;
            this.maxLabel.Text = "Max";
            // 
            // minLabel
            // 
            this.minLabel.AutoSize = true;
            this.minLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F);
            this.minLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.minLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.minLabel.Location = new System.Drawing.Point(427, 342);
            this.minLabel.Name = "minLabel";
            this.minLabel.Size = new System.Drawing.Size(63, 37);
            this.minLabel.TabIndex = 23;
            this.minLabel.Text = "Min";
            // 
            // addCompanyMachineIDLabel
            // 
            this.addCompanyMachineIDLabel.AutoSize = true;
            this.addCompanyMachineIDLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F);
            this.addCompanyMachineIDLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.addCompanyMachineIDLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.addCompanyMachineIDLabel.Location = new System.Drawing.Point(37, 401);
            this.addCompanyMachineIDLabel.Name = "addCompanyMachineIDLabel";
            this.addCompanyMachineIDLabel.Size = new System.Drawing.Size(209, 37);
            this.addCompanyMachineIDLabel.TabIndex = 24;
            this.addCompanyMachineIDLabel.Text = "Company Name";
            // 
            // cancelAddPartsButton
            // 
            this.cancelAddPartsButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.cancelAddPartsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.cancelAddPartsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.cancelAddPartsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelAddPartsButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F);
            this.cancelAddPartsButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.cancelAddPartsButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cancelAddPartsButton.Location = new System.Drawing.Point(499, 481);
            this.cancelAddPartsButton.Name = "cancelAddPartsButton";
            this.cancelAddPartsButton.Size = new System.Drawing.Size(128, 47);
            this.cancelAddPartsButton.TabIndex = 26;
            this.cancelAddPartsButton.Text = "Cancel";
            this.cancelAddPartsButton.UseVisualStyleBackColor = true;
            this.cancelAddPartsButton.Click += new System.EventHandler(this.cancelAddPartsButton_Click);
            // 
            // saveAddPartsButton
            // 
            this.saveAddPartsButton.Enabled = false;
            this.saveAddPartsButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.saveAddPartsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.saveAddPartsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.saveAddPartsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveAddPartsButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F);
            this.saveAddPartsButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.saveAddPartsButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.saveAddPartsButton.Location = new System.Drawing.Point(355, 481);
            this.saveAddPartsButton.Name = "saveAddPartsButton";
            this.saveAddPartsButton.Size = new System.Drawing.Size(128, 47);
            this.saveAddPartsButton.TabIndex = 25;
            this.saveAddPartsButton.Text = "Save";
            this.saveAddPartsButton.UseVisualStyleBackColor = true;
            this.saveAddPartsButton.Click += new System.EventHandler(this.saveAddPartsButton_Click);
            // 
            // AddPartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(683, 560);
            this.Controls.Add(this.cancelAddPartsButton);
            this.Controls.Add(this.saveAddPartsButton);
            this.Controls.Add(this.addCompanyMachineIDLabel);
            this.Controls.Add(this.minLabel);
            this.Controls.Add(this.maxLabel);
            this.Controls.Add(this.priceCostLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.inventoryLabel);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.addPartMinTextBox);
            this.Controls.Add(this.addPartMaxTextBox);
            this.Controls.Add(this.addCompanyMachineIDTextBox);
            this.Controls.Add(this.addPartInventoryTextBox);
            this.Controls.Add(this.addPartPriceCostTextBox);
            this.Controls.Add(this.addPartNameTextBox);
            this.Controls.Add(this.addPartIDTextBox);
            this.Controls.Add(this.addPartTypePanel);
            this.Controls.Add(this.addPartLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "AddPartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Part";
            this.addPartTypePanel.ResumeLayout(false);
            this.addPartTypePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label addPartLabel;
        private System.Windows.Forms.RadioButton addPartInHouseRadioButton;
        private System.Windows.Forms.RadioButton addPartOutsourcedRadioButton;
        private System.Windows.Forms.Panel addPartTypePanel;
        private System.Windows.Forms.TextBox addPartIDTextBox;
        private System.Windows.Forms.TextBox addPartNameTextBox;
        private System.Windows.Forms.TextBox addPartPriceCostTextBox;
        private System.Windows.Forms.TextBox addPartInventoryTextBox;
        private System.Windows.Forms.TextBox addCompanyMachineIDTextBox;
        private System.Windows.Forms.TextBox addPartMinTextBox;
        private System.Windows.Forms.TextBox addPartMaxTextBox;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label inventoryLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label priceCostLabel;
        private System.Windows.Forms.Label maxLabel;
        private System.Windows.Forms.Label minLabel;
        private System.Windows.Forms.Label addCompanyMachineIDLabel;
        private System.Windows.Forms.Button cancelAddPartsButton;
        private System.Windows.Forms.Button saveAddPartsButton;
    }
}