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
using static System.Net.Mime.MediaTypeNames;

namespace C968_Software1_CSharp_EthanParrish
{
    public partial class AddPartForm : Form
    {
        bool nameValidator = false;
        bool inventoryValidator = false;
        bool priceValidator = false;
        bool maxValidator = false;
        bool minValidator = false;
        bool partTypeValidator = false;

        public AddPartForm()
        {
            InitializeComponent();
        }

        private bool saveButton()
        {
            return (nameValidator && inventoryValidator && priceValidator && maxValidator && minValidator && partTypeValidator);
        }

        private void cancelAddPartsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var mainScreenForm = new MainScreenForm();
            mainScreenForm.ShowDialog();
        }

        private void saveAddPartsButton_Click(object sender, EventArgs e)
        {
            if (InputValidators.minMaxValidator(addPartMinTextBox.Text, addPartMaxTextBox.Text, 
                                                addPartInventoryTextBox.Text))
            {
                if (addPartOutsourcedRadioButton.Checked)
                {
                    Outsourced part = new Outsourced();
                    part.Name = addPartNameTextBox.Text;
                    part.InStock = int.Parse(addPartInventoryTextBox.Text);
                    part.Price = decimal.Parse(addPartPriceCostTextBox.Text);
                    part.Max = int.Parse(addPartMaxTextBox.Text);
                    part.Min = int.Parse(addPartMinTextBox.Text);
                    part.CompanyName = addCompanyMachineIDTextBox.Text;

                    Inventory.addPart(part);

                    this.Hide();
                    var mainScreenForm = new MainScreenForm();
                    mainScreenForm.ShowDialog();
                }
                if (addPartInHouseRadioButton.Checked)
                {
                    Inhouse part = new Inhouse();
                    part.Name = addPartNameTextBox.Text;
                    part.InStock = int.Parse(addPartInventoryTextBox.Text);
                    part.Price = decimal.Parse(addPartPriceCostTextBox.Text);
                    part.Max = int.Parse(addPartMaxTextBox.Text);
                    part.Min = int.Parse(addPartMinTextBox.Text);
                    part.MachineID = int.Parse(addCompanyMachineIDTextBox.Text);

                    Inventory.addPart(part);

                    this.Hide();
                    var mainScreenForm = new MainScreenForm();
                    mainScreenForm.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Min must be less than Max and Inventory must be between Min and Max!");
                return;
            }
        }

        private void addPartNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!InputValidators.textboxValidator(addPartNameTextBox.Text))
            {
                addPartNameTextBox.BackColor = Color.Salmon;
                nameValidator = false;
                saveAddPartsButton.Enabled = saveButton();
            }
            else
            {
                addPartNameTextBox.BackColor = Color.White;
                nameValidator = true;
                saveAddPartsButton.Enabled = saveButton();
            }
        }

        private void addPartInventoryTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!InputValidators.numberValidator((addPartInventoryTextBox.Text)))
            {
                addPartInventoryTextBox.BackColor = Color.Salmon;
                inventoryValidator = false;
                saveAddPartsButton.Enabled = saveButton();
            }
            else
            {
                addPartInventoryTextBox.BackColor = Color.White;
                inventoryValidator = true;
                saveAddPartsButton.Enabled = saveButton();
            }
        }

        private void addPartPriceCostTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!InputValidators.numberValidator((addPartPriceCostTextBox.Text)))
            {
                addPartPriceCostTextBox.BackColor = Color.Salmon;
                priceValidator = false;
                saveAddPartsButton.Enabled = saveButton();
            }
            else
            {
                addPartPriceCostTextBox.BackColor = Color.White;
                priceValidator = true;
                saveAddPartsButton.Enabled = saveButton();
            }
        }

        private void addPartMaxTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!InputValidators.numberValidator((addPartMaxTextBox.Text)))
            {
                addPartMaxTextBox.BackColor = Color.Salmon;
                maxValidator = false;
                saveAddPartsButton.Enabled = saveButton();
            }
            else
            {
                addPartMaxTextBox.BackColor = Color.White;
                maxValidator = true;
                saveAddPartsButton.Enabled = saveButton();
            }
        }

        private void addPartMinTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!InputValidators.numberValidator((addPartMinTextBox.Text)))
            {
                addPartMinTextBox.BackColor = Color.Salmon;
                minValidator = false;
                saveAddPartsButton.Enabled = saveButton();
            }
            else
            {
                addPartMinTextBox.BackColor = Color.White;
                minValidator = true;
                saveAddPartsButton.Enabled = saveButton();
            }
        }

        private void addCompanyMachineIDTextBox_TextChanged(object sender, EventArgs e)
        {
            var type = addPartOutsourcedRadioButton.Checked;

            if (type)
            {
                if (!InputValidators.textboxValidator(addCompanyMachineIDTextBox.Text))
                {
                    addCompanyMachineIDTextBox.BackColor = Color.Salmon;
                    partTypeValidator = false;
                    saveAddPartsButton.Enabled = saveButton();
                }
                else
                {
                    addCompanyMachineIDTextBox.BackColor = Color.White;
                    partTypeValidator = true;
                    saveAddPartsButton.Enabled = saveButton();
                }
            }
            else
            {
                if (!InputValidators.numberValidator((addCompanyMachineIDTextBox.Text)))
                {
                    addCompanyMachineIDTextBox.BackColor = Color.Salmon;
                    partTypeValidator = false;
                    saveAddPartsButton.Enabled = saveButton();
                }
                else
                {
                    addCompanyMachineIDTextBox.BackColor = Color.White;
                    partTypeValidator = true;
                    saveAddPartsButton.Enabled = saveButton();
                }
            }
        }
        private void addPartOutsourcedRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (addPartOutsourcedRadioButton.Checked)
            {
                addCompanyMachineIDLabel.Text = "Company Name";
            }
            else
            {
                addCompanyMachineIDLabel.Text = "Machine ID";
            }

            var type = addPartOutsourcedRadioButton.Checked;

            if (type)
            {
                if (!InputValidators.textboxValidator(addCompanyMachineIDTextBox.Text))
                {
                    addCompanyMachineIDTextBox.BackColor = Color.Salmon;
                    partTypeValidator = false;
                    saveAddPartsButton.Enabled = saveButton();
                }
                else
                {
                    addCompanyMachineIDTextBox.BackColor = Color.White;
                    partTypeValidator = true;
                    saveAddPartsButton.Enabled = saveButton();
                }
            }
            else
            {
                if (!InputValidators.numberValidator((addCompanyMachineIDTextBox.Text)))
                {
                    addCompanyMachineIDTextBox.BackColor = Color.Salmon;
                    partTypeValidator = false;
                    saveAddPartsButton.Enabled = saveButton();
                }
                else
                {
                    addCompanyMachineIDTextBox.BackColor = Color.White;
                    partTypeValidator = true;
                    saveAddPartsButton.Enabled = saveButton();
                }
            }
        }
    }
}
