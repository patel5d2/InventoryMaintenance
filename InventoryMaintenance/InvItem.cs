using System;

namespace InventoryMaintenance
{
    public class InvItem
    {
        // Properties for item number, description, and price
        public int ItemNo { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

        // Default constructor
        public InvItem() { }

        // Parameterized constructor
        public InvItem(int itemNo, string description, decimal price)
        {
            ItemNo = itemNo;
            Description = description;
            Price = price;
        }

        // Method to return formatted display text for the item
        public string GetDisplayText()
        {
            return $"{ItemNo}    {Description} (${Price.ToString("0.00")})";
        }
    }
}
