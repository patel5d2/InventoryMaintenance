using System;
using System.Windows.Forms;

namespace InventoryMaintenance
{
    public static class Validator
    {
        public static bool IsPresent(TextBox textBox)
        {
            if (textBox.Text == "")
            {
                MessageBox.Show(textBox.Tag + " is a required field.", "Entry Error");
                textBox.Focus();
                return false;
            }
            return true;
        }

        public static bool IsInt32(TextBox textBox)
        {
            if (Int32.TryParse(textBox.Text, out int number))
            {
                return true;
            }
            else
            {
                MessageBox.Show(textBox.Tag + " must be an integer.", "Entry Error");
                textBox.Focus();
                return false;
            }
        }

        public static bool IsDecimal(TextBox textBox)
        {
            if (Decimal.TryParse(textBox.Text, out decimal number))
            {
                return true;
            }
            else
            {
                MessageBox.Show(textBox.Tag + " must be a decimal number.", "Entry Error");
                textBox.Focus();
                return false;
            }
        }
    }
}
