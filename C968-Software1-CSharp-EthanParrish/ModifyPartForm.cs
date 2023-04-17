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
    public partial class ModifyPartForm : Form
    {
        bool nameValidator = false;
        bool inventoryValidator = false;
        bool priceValidator = false;
        bool maxValidator = false;
        bool minValidator = false;
        bool partTypeValidator = false;

        public ModifyPartForm(Part part)
        {
            InitializeComponent();

            populateData(part);
        }

        private bool saveButton()
        {
            return (nameValidator && inventoryValidator && priceValidator && maxValidator && minValidator && partTypeValidator);
        }

        private void populateData(Part part)
        {
            Inhouse inhouse = new Inhouse();
            Outsourced outsourced = new Outsourced();

            if (part is Outsourced)
            {
                outsourced = (Outsourced)part;
                modifyInHouseRadioButton.Checked = false;
                modifyOutsourcedRadioButton.Checked = true;
                modifyCompanyMachineIDLabel.Text = "Company Name";
                modifyCompanyMachineIDTextBox.Text = outsourced.CompanyName;
            }

            if (part is Inhouse)
            {
                inhouse = (Inhouse)part;
                modifyOutsourcedRadioButton.Checked = false;
                modifyInHouseRadioButton.Checked = true;
                modifyCompanyMachineIDLabel.Text = "Machine ID";
                modifyCompanyMachineIDTextBox.Text = inhouse.MachineID.ToString();
            }

            modifyPartIDTextBox.Text = part.PartID.ToString();
            modifyPartNameTextBox.Text = part.Name;
            modifyPartPriceCostTextBox.Text = part.Price.ToString();
            modifyPartInventoryTextBox.Text = part.InStock.ToString();
            modifyPartMaxTextBox.Text = part.Max.ToString();
            modifyPartMinTextBox.Text = part.Min.ToString();
        }

        private void cancelModifyPartsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var mainScreenForm = new MainScreenForm();
            mainScreenForm.ShowDialog();
        }

        private void saveModifyPartsButton_Click(object sender, EventArgs e)
        {
            if (InputValidators.minMaxValidator(modifyPartMinTextBox.Text, modifyPartMaxTextBox.Text,
                                                modifyPartInventoryTextBox.Text))
            {
                if (modifyOutsourcedRadioButton.Checked)
                {
                    Outsourced part = new Outsourced();
                    part.PartID = int.Parse(modifyPartIDTextBox.Text);
                    part.Name = modifyPartNameTextBox.Text;
                    part.InStock = int.Parse(modifyPartInventoryTextBox.Text);
                    part.Price = decimal.Parse(modifyPartPriceCostTextBox.Text);
                    part.Max = int.Parse(modifyPartMaxTextBox.Text);
                    part.Min = int.Parse(modifyPartMinTextBox.Text);
                    part.CompanyName = modifyCompanyMachineIDTextBox.Text;

                    Inventory.updatePart(part.PartID, part);

                    this.Hide();
                    var mainScreenForm = new MainScreenForm();
                    mainScreenForm.ShowDialog();
                }
                if (modifyInHouseRadioButton.Checked)
                {
                    Inhouse part = new Inhouse();
                    part.PartID = int.Parse(modifyPartIDTextBox.Text);
                    part.Name = modifyPartNameTextBox.Text;
                    part.InStock = int.Parse(modifyPartInventoryTextBox.Text);
                    part.Price = decimal.Parse(modifyPartPriceCostTextBox.Text);
                    part.Max = int.Parse(modifyPartMaxTextBox.Text);
                    part.Min = int.Parse(modifyPartMinTextBox.Text);
                    part.MachineID = int.Parse(modifyCompanyMachineIDTextBox.Text);

                    Inventory.updatePart(part.PartID, part);

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

        private void modifyPartNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!InputValidators.textboxValidator(modifyPartNameTextBox.Text))
            {
                modifyPartNameTextBox.BackColor = Color.Salmon;
                nameValidator = false;
                saveModifyPartsButton.Enabled = saveButton();
            }
            else
            {
                modifyPartNameTextBox.BackColor = Color.White;
                nameValidator = true;
                saveModifyPartsButton.Enabled = saveButton();
            }
        }

        private void modifyPartInventoryTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!InputValidators.numberValidator((modifyPartInventoryTextBox.Text)))
            {
                modifyPartInventoryTextBox.BackColor = Color.Salmon;
                inventoryValidator = false;
                saveModifyPartsButton.Enabled = saveButton();
            }
            else
            {
                modifyPartInventoryTextBox.BackColor = Color.White;
                inventoryValidator = true;
                saveModifyPartsButton.Enabled = saveButton();
            }
        }

        private void modifyPartPriceCostTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!InputValidators.numberValidator((modifyPartPriceCostTextBox.Text)))
            {
                modifyPartPriceCostTextBox.BackColor = Color.Salmon;
                priceValidator = false;
                saveModifyPartsButton.Enabled = saveButton();
            }
            else
            {
                modifyPartPriceCostTextBox.BackColor = Color.White;
                priceValidator = true;
                saveModifyPartsButton.Enabled = saveButton();
            }
        }

        private void modifyPartMaxTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!InputValidators.numberValidator((modifyPartMaxTextBox.Text)))
            {
                modifyPartMaxTextBox.BackColor = Color.Salmon;
                maxValidator = false;
                saveModifyPartsButton.Enabled = saveButton();
            }
            else
            {
                modifyPartMaxTextBox.BackColor = Color.White;
                maxValidator = true;
                saveModifyPartsButton.Enabled = saveButton();
            }
        }

        private void modifyPartMinTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!InputValidators.numberValidator((modifyPartMinTextBox.Text)))
            {
                modifyPartMinTextBox.BackColor = Color.Salmon;
                minValidator = false;
                saveModifyPartsButton.Enabled = saveButton();
            }
            else
            {
                modifyPartMinTextBox.BackColor = Color.White;
                minValidator = true;
                saveModifyPartsButton.Enabled = saveButton();
            }
        }

        private void modifyCompanyMachineIDTextBox_TextChanged(object sender, EventArgs e)
        {
            var type = modifyOutsourcedRadioButton.Checked;

            if (type)
            {
                if (!InputValidators.textboxValidator(modifyCompanyMachineIDTextBox.Text))
                {
                    modifyCompanyMachineIDTextBox.BackColor = Color.Salmon;
                    partTypeValidator = false;
                    saveModifyPartsButton.Enabled = saveButton();
                }
                else
                {
                    modifyCompanyMachineIDTextBox.BackColor = Color.White;
                    partTypeValidator = true;
                    saveModifyPartsButton.Enabled = saveButton();
                }
            }
            else
            {
                if (!InputValidators.numberValidator((modifyCompanyMachineIDTextBox.Text)))
                {
                    modifyCompanyMachineIDTextBox.BackColor = Color.Salmon;
                    partTypeValidator = false;
                    saveModifyPartsButton.Enabled = saveButton();
                }
                else
                {
                    modifyCompanyMachineIDTextBox.BackColor = Color.White;
                    partTypeValidator = true;
                    saveModifyPartsButton.Enabled = saveButton();
                }
            }
        }

        private void modifyOutsourcedRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            bool type;

            if (modifyOutsourcedRadioButton.Checked)
            {
                modifyCompanyMachineIDLabel.Text = "Company Name";
                type = true;
            }
            else
            {
                modifyCompanyMachineIDLabel.Text = "Machine ID";
                type = false;
            }

            if (type)
            {
                if (!InputValidators.textboxValidator(modifyCompanyMachineIDTextBox.Text))
                {
                    modifyCompanyMachineIDTextBox.BackColor = Color.Salmon;
                    partTypeValidator = false;
                    saveModifyPartsButton.Enabled = saveButton();
                }
                else
                {
                    modifyCompanyMachineIDTextBox.BackColor = Color.White;
                    partTypeValidator = true;
                    saveModifyPartsButton.Enabled = saveButton();
                }
            }
            else
            {
                if (!InputValidators.numberValidator((modifyCompanyMachineIDTextBox.Text)))
                {
                    modifyCompanyMachineIDTextBox.BackColor = Color.Salmon;
                    partTypeValidator = false;
                    saveModifyPartsButton.Enabled = saveButton();
                }
                else
                {
                    modifyCompanyMachineIDTextBox.BackColor = Color.White;
                    partTypeValidator = true;
                    saveModifyPartsButton.Enabled = saveButton();
                }
            }
        }
    }
}
