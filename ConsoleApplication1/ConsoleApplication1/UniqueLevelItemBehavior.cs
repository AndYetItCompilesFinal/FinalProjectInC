using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public class UniqueLevelItemBehavior
    {
        private string Description;
        private int Quantity;
        public UniqueLevelItemBehavior(string description,int quantity)
        {
            this.Description = description;
            this.Quantity = quantity;
        }
        public UniqueLevelItemBehavior()
        {

        }
        public string GetDescription()
        {
            return Description;
        }
        public int GetQuantity()
        {
            return Quantity;
        }
        public void AddQuantity()
        {
            Quantity++;
        }

        public override string ToString()
        {
            if (Quantity == 1)
            {
                return Description;
            }
            else
                return Description + " (" + Quantity + ")";   
        }

        public string getDescription()
        {
            return ", " + Description;
        }

    }
}
