using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public class UniqueLevelItemBehavior
    {
        private string description;
        private int quantity;
        public UniqueLevelItemBehavior(string description,int quantity)
        {
            this.description = description;
            this.quantity = quantity;
        }
        public UniqueLevelItemBehavior()
        {

        }
        public string GetDescription()
        {
            return description;
        }
        public int GetQuantity()
        {
            return quantity;
        }
        public void AddQuantity()
        {
            quantity++;
        }

        public override string ToString()
        {
            if (quantity == 1)
            {
                return description;
            }
            else
                return description + " (" + quantity + ")";   
        }

        public string getDescription()
        {
            return ", " + description;
        }

    }
}
