using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C968_Software1_CSharp_EthanParrish.ClassLibrary
{
    public static class Inventory
    {

        static Inventory()
        {
            Products = new BindingList<Product>();
            AllParts = new BindingList<Part>();
        }

        public static BindingList<Product> Products { get; set; }
        public static BindingList<Part> AllParts { get; set; }

        public static void addProduct(Product product)
        {
            int listSize = Products.Count();

            if (listSize > 0)
            {
                product.ProductID = Products[listSize - 1].ProductID + 1;
            }
            else
            {
                product.ProductID = 1;
            }

            Products.Add(product);

            int index = Products.IndexOf(product);

            Products[index].InStock = Products[index].InStock + 1;
        }

        public static bool removeProduct(int productId)
        {
            int initialList = Products.Count();
            Products.Remove(Inventory.Products.SingleOrDefault(p => p.ProductID == productId));
            int finalList = Products.Count();

            if (initialList > finalList)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static Product lookupProduct(int productId)
        {
            return Inventory.Products.SingleOrDefault(p => p.ProductID == productId);
        }

        public static void updateProduct(int productId, Product product)
        {
            int i = 0;
            while (Inventory.Products[i].ProductID != productId)
            {
                i++;
            }

            Inventory.Products[i] = product;
        }

        public static void addPart(Part part)
        {
            int listSize = AllParts.Count();

            if (listSize > 0)
            {
                part.PartID = AllParts[listSize - 1].PartID + 1;
            }
            else
            {
                part.PartID = 1;
            }

            AllParts.Add(part);
        }

        public static bool deletePart(Part part)
        {
            if (part == null)
            {
                return false;
            }
            else
            {
                Inventory.AllParts.Remove(part);
                return true;
            }
        }

        public static Part lookupPart(int partId)
        {
            return Inventory.AllParts.SingleOrDefault(p => p.PartID == partId);
        }

        public static void updatePart(int partId, Part part)
        {
            int i = 0;
            while (Inventory.AllParts[i].PartID != partId)
            {
                i++;
            }

            Inventory.AllParts[i] = part;
        }
    }
}
