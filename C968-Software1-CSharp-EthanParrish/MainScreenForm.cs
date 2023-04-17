using C968_Software1_CSharp_EthanParrish.ClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace C968_Software1_CSharp_EthanParrish
{
    public partial class MainScreenForm : Form
    {
        public MainScreenForm()
        {
            InitializeComponent();

            initializeLists();

            partListButtons();

            productListButtons();
        }

        private void partListButtons()
        {
            if (partsGridView.RowCount > 0)
            {
                modifyPartsButton.Enabled = true;
                deletePartsButton.Enabled = true;
            }
            else
            {
                modifyPartsButton.Enabled = false;
                deletePartsButton.Enabled = false;
            }
        }
        private void productListButtons()
        {
            if (productsGridView.RowCount > 0)
            {
                modifyProductsButton.Enabled = true;
                deleteProductsButton.Enabled = true;
            }
            else
            {
                modifyProductsButton.Enabled = false;
                deleteProductsButton.Enabled = false;
            }
        }
        private void selectionValidation()
        {
            MessageBox.Show("Please make a selection!");
            return;
        }

        private void initializeLists()
        {
            if (Inventory.AllParts.Count == 0)
            {
                Outsourced outsourcedPart = new Outsourced();

                outsourcedPart.Name = "Wheel";
                outsourcedPart.Price = 12.11m;
                outsourcedPart.InStock = 1;
                outsourcedPart.Min = 5;
                outsourcedPart.Max = 25;
                outsourcedPart.CompanyName = "Test";

                Inhouse inhouse = new Inhouse();

                inhouse.Name = "Pedal";
                inhouse.Price = 8.22m;
                inhouse.InStock = 5;
                inhouse.Min = 5;
                inhouse.Max = 25;
                inhouse.MachineID = 1;

                Inventory.addPart(inhouse);
                Inventory.addPart(outsourcedPart);

                partsGridView.DataSource = Inventory.AllParts;
            }

            if (Inventory.Products.Count == 0)
            {
                Product product1 = new Product();
                BindingList<Part> part1 = new BindingList<Part>();
                part1.Add(Inventory.AllParts[0]);

                product1.Name = "Red Bicycle";
                product1.Price = 11.44m;
                product1.InStock = 10;
                product1.Min = 1;
                product1.Max = 25;
                product1.AssociatedParts = part1;

                Product product2 = new Product();
                BindingList<Part> part2 = new BindingList<Part>();
                part2.Add(Inventory.AllParts[0]);

                product2.Name = "Yellow Bicycle";
                product2.Price = 9.66m;
                product2.InStock = 15;
                product2.Min = 1;
                product2.Max = 20;
                product2.AssociatedParts = part2;

                Inventory.addProduct(product1);
                Inventory.addProduct(product2);

                productsGridView.DataSource = Inventory.Products;
            }
            else
            {
                partsGridView.DataSource = Inventory.AllParts;
                productsGridView.DataSource = Inventory.Products;
            }
        }

        private void deletePartsButton_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show($"Are You Sure You Want To Delete This Part??",
                       "Confirm Delete!!",
                       MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                if (partsGridView.SelectedRows.Count == 0)
                {
                    selectionValidation();
                }
                else
                {
                    int id = int.Parse(partsGridView.SelectedCells[0].Value.ToString());
                    Inventory.deletePart(Inventory.lookupPart(id));
                    partListButtons();
                }
            }
        }

        private void addPartsButton_Click(object sender, EventArgs e)
        {
                this.Hide();
                var addPartForm = new AddPartForm();
                addPartForm.ShowDialog();
        }

        private void modifyPartsButton_Click(object sender, EventArgs e)
        {
            if (partsGridView.SelectedRows.Count == 0)
            {
                selectionValidation();
            }
            else
            {
                int id = int.Parse(partsGridView.SelectedCells[0].Value.ToString());
                Part modifyPart = Inventory.lookupPart(id);

                this.Hide();
                var modifyPartForm = new ModifyPartForm(modifyPart);
                modifyPartForm.ShowDialog();
            }
        }

        private void deleteProductsButton_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show($"Are You Sure You Want To Delete This Product??",
                        "Confirm Delete!!",
                        MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                if (productsGridView.SelectedRows.Count == 0)
                {
                    selectionValidation();
                }
                else
                {
                    int id = int.Parse(productsGridView.SelectedCells[0].Value.ToString());
                    var product = Inventory.lookupProduct(id);

                    if (product.AssociatedParts.Count > 0)
                    {
                        MessageBox.Show("You must remove associated parts before deleting!");
                        return;
                    }
                    else
                    {
                        Inventory.removeProduct(id);
                        productListButtons();
                    }
                }
            }
        }

        private void addProductsButton_Click(object sender, EventArgs e)
        {
                this.Hide();
                var addProductForm = new AddProductForm();
                addProductForm.ShowDialog();
        }

        private void modifyProductsButton_Click(object sender, EventArgs e)
        {
            if (productsGridView.SelectedRows.Count == 0)
            {
                selectionValidation();
            }
            else
            {
                int id = int.Parse(productsGridView.SelectedCells[0].Value.ToString());
                Product modifyProduct = Inventory.lookupProduct(id);

                this.Hide();
                var modifyProductForm = new ModifyProductForm(modifyProduct);
                modifyProductForm.ShowDialog();
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MainScreenForm_Load(object sender, EventArgs e)
        {
            initializeLists();

            partsGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 16F);
            partsGridView.Columns[0].HeaderText = "Part ID";
            partsGridView.Columns[1].HeaderText = "Name";
            partsGridView.Columns[2].HeaderText = "Price";
            partsGridView.Columns[3].HeaderText = "Inventory";
            partsGridView.Columns[4].HeaderText = "Min";
            partsGridView.Columns[5].HeaderText = "Max";

            productsGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 16F);
            productsGridView.Columns[0].HeaderText = "Product ID";
            productsGridView.Columns[1].HeaderText = "Name";
            productsGridView.Columns[2].HeaderText = "Price";
            productsGridView.Columns[3].HeaderText = "Inventory";
            productsGridView.Columns[4].HeaderText = "Min";
            productsGridView.Columns[5].HeaderText = "Max";

            partListButtons();

            productListButtons();
        }

        private void searchProductsTextBox_TextChanged(object sender, EventArgs e)
        {
            productsGridView.ClearSelection();

            for (int i = 0; i < (productsGridView.Rows.Count); i++)
            {
                var cellValue = productsGridView.Rows[i].Cells["Name"].Value;
                if (cellValue != null && cellValue.ToString().ToLower().Contains(searchProductsTextBox.Text.ToLower()))
                {
                    productsGridView.Rows[i].Selected = true;
                }
            }
        }

        private void searchPartsTextBox_TextChanged(object sender, EventArgs e)
        {
            partsGridView.ClearSelection();

            for (int i = 0; i < (partsGridView.Rows.Count); i++)
            {
                var cellValue = partsGridView.Rows[i].Cells["Name"].Value;
                if (cellValue != null && cellValue.ToString().ToLower().Contains(searchPartsTextBox.Text.ToLower()))
                {
                    partsGridView.Rows[i].Selected = true;
                }
            }
        }
    }
}
