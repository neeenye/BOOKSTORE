using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bookstore
{

    public class Item
    {
        public string Name { get; private set; }
        public decimal Price { get; set; }
        public Item()
        {
            Name = "None";
        }       public Item(string name) { this.Name = name; }

        public string FullName
        {
            get
            {
                return Name + " - " + Price.ToString("F2");
            }
        }
    }

    public class Cart
    {
        public List<Item> Items { get; private set; }

        public void AddItem(Item item)
        {
            Items.Add(item);
        }
        public decimal ComputeTotal()
        {
            decimal total = 0m;
            foreach (Item item in Items)
                total += item.Price;
            return total;
        }
    }

    // fake data
    public class Inventory
    {
        public List<ProductLine> ProductLines;

        public Inventory()
        {
            ProductLines = new List<ProductLine>();
            ProductLines.Add(new ProductLine("CHILDREN BOOKS", 450));
            ProductLines.Add(new ProductLine("HEALTH/FITNESS", 760));
            ProductLines.Add(new ProductLine("HUMOR", 560));
            ProductLines.Add(new ProductLine("RELIGION", 500));
            ProductLines.Add(new ProductLine("COMIC BOOKS",220));
            ProductLines.Add(new ProductLine("FASHION MAGAZINES", 1000));
            ProductLines.Add(new ProductLine("ARTS & PHOTOGRAPHY", 300));        
        }
   

    }

    public class ProductLine
    {
        public Item item;
        public int Qty { get; private set; }
        public ProductLine(string name, decimal price)
        {
            item = new Item(name);
            item.Price = price;
        }
    }
}