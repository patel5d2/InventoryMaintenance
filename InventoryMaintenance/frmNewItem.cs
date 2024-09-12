using System;
using System.Windows.Forms;

namespace InventoryMaintenance
{
    public partial class frmNewItem : Form
    {
        // Declare the inventory item.
        private InvItem invItem = null;

        public frmNewItem()
        {
            InitializeComponent();
        }

        // Method to get and return the new item.
        public InvItem GetNewItem()
        {
            this.ShowDialog();  // Display the form as a modal dialog box.
            return invItem;     // Return the newly created item (or null if canceled).
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                // Create a new item based on the user input.
                invItem = new InvItem(Convert.ToInt32(txtItemNo.Text), txtDescription.Text, Convert.ToDecimal(txtPrice.Text));

                // Close the form.
                this.Close();
            }
        }

        private bool IsValidData()
        {
            // Validate that the necessary fields are provided and are of the correct data type.
            return Validator.IsPresent(txtItemNo) &&
                   Validator.IsInt32(txtItemNo) &&
                   Validator.IsPresent(txtDescription) &&
                   Validator.IsPresent(txtPrice) &&
                   Validator.IsDecimal(txtPrice);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Close the form without saving a new item.
            this.Close();
        }

        private void frmNewItem_Load(object sender, EventArgs e)
        {
            // Any initialization logic when the form loads, if necessary.
        }
    }
}
