using C968_Software1_CSharp_EthanParrish.ClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C968_Software1_CSharp_EthanParrish
{
    public partial class AddProductForm : Form
    {
        BindingList<Part> associatedParts = new BindingList<Part>();
        BindingList<Part> candidateParts = new BindingList<Part>();
        bool nameValidator = false;
        bool inventoryValidator = false;
        bool priceValidator = false;
        bool maxValidator = false;
        bool minValidator = false;

        public AddProductForm()
        {
            InitializeComponent();

            foreach (Part part in Inventory.AllParts)
            {
                candidateParts.Add(part);
            }

            addProductsCandidateGridView.DataSource = candidateParts;

            addProductsAssociatedGridView.DataSource = associatedParts;

            AssociatePartButton();

            candidatePartButton();
        }
        private bool saveButton()
        {
            return (nameValidator && inventoryValidator && priceValidator && maxValidator && minValidator);
        }

        private void AssociatePartButton()
        {
            if (associatedParts.Count > 0)
            {
                addProductsDeleteButton.Enabled = true;
            }
            else
            {
                addProductsDeleteButton.Enabled = false;
            }

            addProductsSaveButton.Enabled = saveButton();
        }

        private void candidatePartButton()
        {
            if (candidateParts.Count > 0)
            {
                addProductsAddButton.Enabled = true;
            }
            else
            {
                addProductsAddButton.Enabled = false;
            }
        }

        private void selectionValidation()
        {
            MessageBox.Show("Please make a selection!");
            return;
        }

        private void addProductsAddButton_Click(object sender, EventArgs e)
        {
            if (addProductsCandidateGridView.SelectedRows.Count == 0)
            {
                selectionValidation();
            }
            else
            {
                var part = Inventory.lookupPart(int.Parse(addProductsCandidateGridView.SelectedCells[0].Value.ToString()));
                associatedParts.Add(part);
                candidateParts.Remove(part);
                AssociatePartButton();
                candidatePartButton();
            }
        }

        private void addProductsButton_Click(object sender, EventArgs e)
        {
            if (addProductsAssociatedGridView.SelectedRows.Count == 0)
            {
                selectionValidation();
            }
            else
            {
                var part = Inventory.lookupPart(int.Parse(addProductsAssociatedGridView.SelectedCells[0].Value.ToString()));
                candidateParts.Add(part);
                associatedParts.Remove(part);
                AssociatePartButton();
                candidatePartButton();
            }
        }

        private void addProductsSaveButton_Click(object sender, EventArgs e)
        {
            if (InputValidators.minMaxValidator(addProductMinTextBox.Text, addProductMaxTextBox.Text,
                                                addProductInventoryTextBox.Text))
            {
                var product = new Product();

                product.Name = addProductNameTextBox.Text;
                product.InStock = int.Parse(addProductInventoryTextBox.Text);
                product.Price = decimal.Parse(addProductPriceTextBox.Text);
                product.Max = int.Parse(addProductMaxTextBox.Text);
                product.Min = int.Parse(addProductMinTextBox.Text);
                product.AssociatedParts = associatedParts;

                Inventory.addProduct(product);

                this.Hide();
                var mainScreenForm = new MainScreenForm();
                mainScreenForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Min must be less than Max and Inventory must be between Min and Max!");
                return;
            }
        }

        private void addProductsCancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var mainScreenForm = new MainScreenForm();
            mainScreenForm.ShowDialog();
        }

        private void AddProductForm_Load(object sender, EventArgs e)
        {
            addProductsCandidateGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 16F);
            addProductsCandidateGridView.Columns[0].HeaderText = "Product ID";
            addProductsCandidateGridView.Columns[1].HeaderText = "Name";
            addProductsCandidateGridView.Columns[2].HeaderText = "Price";
            addProductsCandidateGridView.Columns[3].HeaderText = "Inventory";
            addProductsCandidateGridView.Columns[4].HeaderText = "Min";
            addProductsCandidateGridView.Columns[5].HeaderText = "Max";

            addProductsAssociatedGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 16F);
            addProductsAssociatedGridView.Columns[0].HeaderText = "Product ID";
            addProductsAssociatedGridView.Columns[1].HeaderText = "Name";
            addProductsAssociatedGridView.Columns[2].HeaderText = "Price";
            addProductsAssociatedGridView.Columns[3].HeaderText = "Inventory";
            addProductsAssociatedGridView.Columns[4].HeaderText = "Min";
            addProductsAssociatedGridView.Columns[5].HeaderText = "Max";
        }

        private void searchAddProductsTextBox_TextChanged(object sender, EventArgs e)
        {
            addProductsCandidateGridView.ClearSelection();

            for (int i = 0; i < (addProductsCandidateGridView.Rows.Count); i++)
            {
                var cellValue = addProductsCandidateGridView.Rows[i].Cells["Name"].Value;
                if (cellValue != null && cellValue.ToString().ToLower().Contains(searchAddProductsTextBox.Text.ToLower()))
                {
                    addProductsCandidateGridView.Rows[i].Selected = true;
                }
            }
        }

        private void addProductNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!InputValidators.textboxValidator(addProductNameTextBox.Text))
            {
                addProductNameTextBox.BackColor = Color.Salmon;
                nameValidator = false;
                addProductsSaveButton.Enabled = saveButton();
            }
            else
            {
                addProductNameTextBox.BackColor = Color.White;
                nameValidator = true;
                addProductsSaveButton.Enabled = saveButton();
            }
        }

        private void addProductInventoryTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!InputValidators.numberValidator((addProductInventoryTextBox.Text)))
            {
                addProductInventoryTextBox.BackColor = Color.Salmon;
                inventoryValidator = false;
                addProductsSaveButton.Enabled = saveButton();
            }
            else
            {
                addProductInventoryTextBox.BackColor = Color.White;
                inventoryValidator = true;
                addProductsSaveButton.Enabled = saveButton();
            }
        }

        private void addProductPriceTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!InputValidators.numberValidator((addProductPriceTextBox.Text)))
            {
                addProductPriceTextBox.BackColor = Color.Salmon;
                priceValidator = false;
                addProductsSaveButton.Enabled = saveButton();
            }
            else
            {
                addProductPriceTextBox.BackColor = Color.White;
                priceValidator = true;
                addProductsSaveButton.Enabled = saveButton();
            }
        }

        private void addProductMaxTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!InputValidators.numberValidator((addProductMaxTextBox.Text)))
            {
                addProductMaxTextBox.BackColor = Color.Salmon;
                maxValidator = false;
                addProductsSaveButton.Enabled = saveButton();
            }
            else
            {
                addProductMaxTextBox.BackColor = Color.White;
                maxValidator = true;
                addProductsSaveButton.Enabled = saveButton();
            }
        }

        private void addProductMinTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!InputValidators.numberValidator((addProductMinTextBox.Text)))
            {
                addProductMinTextBox.BackColor = Color.Salmon;
                minValidator = false;
                addProductsSaveButton.Enabled = saveButton();
            }
            else
            {
                addProductMinTextBox.BackColor = Color.White;
                minValidator = true;
                addProductsSaveButton.Enabled = saveButton();
            }
        }
    }
}
