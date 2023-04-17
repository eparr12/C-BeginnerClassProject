using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C968_Software1_CSharp_EthanParrish.ClassLibrary
{
    public class Product
    {
        public BindingList<Part> AssociatedParts { get; set; }
        public int ProductID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }

        public void addAssociatedPart(Part associatedPart)
        {
            AssociatedParts.Add(associatedPart);
        }

        public bool removeAssociatedPart(int associatedPartID)
        {
            try
            {
                AssociatedParts.RemoveAt(associatedPartID);
                return true;
            }
            catch
            { 
                return false; 
            }
        }

        public Part lookupAssociatedPart(int associatedPartID)
        {
            return AssociatedParts.SingleOrDefault(p => p.PartID == associatedPartID);
        }
    }
}
