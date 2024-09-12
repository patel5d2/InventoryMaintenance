using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;

namespace InventoryMaintenance
{
    public static class InvItemDB
    {
        private const string Path = "InventoryItems.xml";

        // Method to retrieve the list of items from the XML file
        public static List<InvItem> GetItems()
        {
            List<InvItem> items = new List<InvItem>();

            if (File.Exists(Path))
            {
                XElement xml = XElement.Load(Path);
                foreach (XElement element in xml.Elements("Item"))
                {
                    int itemNo = (int)element.Element("ItemNo");
                    string description = (string)element.Element("Description");
                    decimal price = (decimal)element.Element("Price");

                    InvItem item = new InvItem(itemNo, description, price);
                    items.Add(item);
                }
            }

            return items;
        }

        // Method to save the list of items to the XML file
        public static void SaveItems(List<InvItem> items)
        {
            XElement xml = new XElement("Items",
                from item in items
                select new XElement("Item",
                    new XElement("ItemNo", item.ItemNo),
                    new XElement("Description", item.Description),
                    new XElement("Price", item.Price)
                )
            );

            xml.Save(Path);
        }
    }
}
