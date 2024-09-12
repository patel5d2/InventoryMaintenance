using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace InventoryMaintenance
{
    public partial class frmInvMaint : Form
    {
        // Declare the list of inventory items.
        private List<InvItem> invItems = null;

        public frmInvMaint()
        {
            InitializeComponent();
        }

        private void frmInvMaint_Load(object sender, EventArgs e)
        {
            // Get the list of items from the database.
            invItems = InvItemDB.GetItems();
            FillItemListBox();
        }

        private void FillItemListBox()
        {
            // Clear the current items in the listbox.
            lstItems.Items.Clear();

            // Load the listbox with the items from the list.
            foreach (InvItem item in invItems)
            {
                lstItems.Items.Add(item.GetDisplayText());
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Create an instance of the New Item form and get a new item from it.
            frmNewItem newItemForm = new frmNewItem();
            InvItem newItem = newItemForm.GetNewItem();

            // If a new item was returned, add it to the list, save the list, and refresh the list box.
            if (newItem != null)
            {
                invItems.Add(newItem);
                InvItemDB.SaveItems(invItems);
                FillItemListBox();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Get the selected item index from the listbox.
            int i = lstItems.SelectedIndex;

            // Check if an item is selected.
            if (i != -1)
            {
                // Get the item to delete.
                InvItem itemToDelete = invItems[i];

                // Display a confirmation dialog for deletion.
                DialogResult result = MessageBox.Show($"Are you sure you want to delete {itemToDelete.Description}?",
                                                      "Confirm Delete", MessageBoxButtons.YesNo);

                // If deletion is confirmed, remove the item, save the list, and refresh the listbox.
                if (result == DialogResult.Yes)
                {
                    invItems.RemoveAt(i);
                    InvItemDB.SaveItems(invItems);
                    FillItemListBox();
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }

        private void lstItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Event handler for selected item changes in the list box, if needed for future logic.
        }
    }
}
