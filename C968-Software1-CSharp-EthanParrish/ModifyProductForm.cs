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
    public partial class ModifyProductForm : Form
    {
        BindingList<Part> associatedParts = new BindingList<Part>();
        BindingList<Part> candidateParts = new BindingList<Part>();
        bool nameValidator = false;
        bool inventoryValidator = false;
        bool priceValidator = false;
        bool maxValidator = false;
        bool minValidator = false;

        public ModifyProductForm(Product product)
        {
            InitializeComponent();

            foreach (Part part in Inventory.AllParts)
            {
                candidateParts.Add(part);
            }

            modifyProductsCandidateGridView.DataSource = candidateParts;

            populateData(product);

            modifyProductsAssociatedGridView.DataSource = associatedParts;

            AssociatePartButton();

            candidatePartButton();
        }
        private bool saveButton()
        {
            return (nameValidator && inventoryValidator && priceValidator && maxValidator &&
                    minValidator);
        }
        private void AssociatePartButton()
        {
            if (associatedParts.Count > 0)
            {
                modifyProductsDeleteButton.Enabled = true;
            }
            else
            {
                modifyProductsDeleteButton.Enabled = false;
            }

            modifyProductsSaveButton.Enabled = saveButton();
        }
        private void candidatePartButton()
        {
            if (candidateParts.Count > 0)
            {
                modifyProductsAddButton.Enabled = true;
            }
            else
            {
                modifyProductsAddButton.Enabled = false;
            }
        }
        private void selectionValidation()
        {
            MessageBox.Show("Please make a selection!");
            return;
        }

        private void populateData(Product product)
        {
            modifyProductIDTextBox.Text = product.ProductID.ToString();
            modifyProductNameTextBox.Text = product.Name;
            modifyProductPriceTextBox.Text = product.Price.ToString();
            modifyProductInventoryTextBox.Text = product.InStock.ToString();
            modifyProductMaxTextBox.Text = product.Max.ToString();
            modifyProductMinTextBox.Text = product.Min.ToString();
            associatedParts = product.AssociatedParts;

            if (associatedParts == null)
            {
                associatedParts = new BindingList<Part>();
            }
            else
            {
                foreach (Part part in associatedParts)
                {
                    candidateParts.Remove(part);
                }
            }
        }

        private void modifyProductsAddButton_Click(object sender, EventArgs e)
        {
            if (modifyProductsCandidateGridView.SelectedRows.Count == 0)
            {
                selectionValidation();
            }
            else
            {
                var part = Inventory.lookupPart(int.Parse(modifyProductsCandidateGridView.SelectedCells[0].Value.ToString()));
                associatedParts.Add(part);
                candidateParts.Remove(part);
                AssociatePartButton();
                candidatePartButton();
            }
        }

        private void modifyProductsButton_Click(object sender, EventArgs e)
        {
            if (modifyProductsAssociatedGridView.SelectedRows.Count == 0)
            {
                selectionValidation();
            }
            else
            {
                var part = Inventory.lookupPart(int.Parse(modifyProductsAssociatedGridView.SelectedCells[0].Value.ToString()));
                candidateParts.Add(part);
                associatedParts.Remove(part);
                AssociatePartButton();
                candidatePartButton();
            }
        }

        private void modifyProductsSaveButton_Click(object sender, EventArgs e)
        {
            if (InputValidators.minMaxValidator(modifyProductMinTextBox.Text, modifyProductMaxTextBox.Text,
                                                modifyProductInventoryTextBox.Text))
            {
                var product = new Product();

                int id = int.Parse(modifyProductIDTextBox.Text);
                product.ProductID = id;
                product.Name = modifyProductNameTextBox.Text;
                product.InStock = int.Parse(modifyProductInventoryTextBox.Text);
                product.Price = decimal.Parse(modifyProductPriceTextBox.Text);
                product.Max = int.Parse(modifyProductMaxTextBox.Text);
                product.Min = int.Parse(modifyProductMinTextBox.Text);
                product.AssociatedParts = associatedParts;

                Inventory.updateProduct(id, product);

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

        private void modifyProductsCancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var mainScreenForm = new MainScreenForm();
            mainScreenForm.ShowDialog();
        }

        private void ModifyProductForm_Load(object sender, EventArgs e)
        {
            modifyProductsCandidateGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 16F);
            modifyProductsCandidateGridView.Columns[0].HeaderText = "Product ID";
            modifyProductsCandidateGridView.Columns[1].HeaderText = "Name";
            modifyProductsCandidateGridView.Columns[2].HeaderText = "Price";
            modifyProductsCandidateGridView.Columns[3].HeaderText = "Inventory";
            modifyProductsCandidateGridView.Columns[4].HeaderText = "Min";
            modifyProductsCandidateGridView.Columns[5].HeaderText = "Max";

            modifyProductsAssociatedGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 16F);
            modifyProductsAssociatedGridView.Columns[0].HeaderText = "Product ID";
            modifyProductsAssociatedGridView.Columns[1].HeaderText = "Name";
            modifyProductsAssociatedGridView.Columns[2].HeaderText = "Price";
            modifyProductsAssociatedGridView.Columns[3].HeaderText = "Inventory";
            modifyProductsAssociatedGridView.Columns[4].HeaderText = "Min";
            modifyProductsAssociatedGridView.Columns[5].HeaderText = "Max";
        }

        private void searchModifyProductsTextBox_TextChanged(object sender, EventArgs e)
        {
            modifyProductsCandidateGridView.ClearSelection();

            for (int i = 0; i < (modifyProductsCandidateGridView.Rows.Count); i++)
            {
                var cellValue = modifyProductsCandidateGridView.Rows[i].Cells["Name"].Value;
                if (cellValue != null && cellValue.ToString().ToLower().Contains(searchModifyProductsTextBox.Text.ToLower()))
                {
                    modifyProductsCandidateGridView.Rows[i].Selected = true;
                }
            }
        }

        private void modifyProductNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!InputValidators.textboxValidator(modifyProductNameTextBox.Text))
            {
                modifyProductNameTextBox.BackColor = Color.Salmon;
                nameValidator = false;
                modifyProductsSaveButton.Enabled = saveButton();
            }
            else
            {
                modifyProductNameTextBox.BackColor = Color.White;
                nameValidator = true;
                modifyProductsSaveButton.Enabled = saveButton();
            }
        }

        private void modifyProductInventoryTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!InputValidators.numberValidator((modifyProductInventoryTextBox.Text)))
            {
                modifyProductInventoryTextBox.BackColor = Color.Salmon;
                inventoryValidator = false;
                modifyProductsSaveButton.Enabled = saveButton();
            }
            else
            {
                modifyProductInventoryTextBox.BackColor = Color.White;
                inventoryValidator = true;
                modifyProductsSaveButton.Enabled = saveButton();
            }
        }

        private void modifyProductPriceTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!InputValidators.numberValidator((modifyProductPriceTextBox.Text)))
            {
                modifyProductPriceTextBox.BackColor = Color.Salmon;
                priceValidator = false;
                modifyProductsSaveButton.Enabled = saveButton();
            }
            else
            {
                modifyProductPriceTextBox.BackColor = Color.White;
                priceValidator = true;
                modifyProductsSaveButton.Enabled = saveButton();
            }
        }

        private void modifyProductMaxTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!InputValidators.numberValidator((modifyProductMaxTextBox.Text)))
            {
                modifyProductMaxTextBox.BackColor = Color.Salmon;
                maxValidator = false;
                modifyProductsSaveButton.Enabled = saveButton();
            }
            else
            {
                modifyProductMaxTextBox.BackColor = Color.White;
                maxValidator = true;
                modifyProductsSaveButton.Enabled = saveButton();
            }
        }

        private void modifyProductMinTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!InputValidators.numberValidator((modifyProductMinTextBox.Text)))
            {
                modifyProductMinTextBox.BackColor = Color.Salmon;
                minValidator = false;
                modifyProductsSaveButton.Enabled = saveButton();
            }
            else
            {
                modifyProductMinTextBox.BackColor = Color.White;
                minValidator = true;
                modifyProductsSaveButton.Enabled = saveButton();
            }
        }
    }
}
