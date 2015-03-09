using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public class Backpack
    {
        public List<Object> list;

        public Backpack()
        {
            this.list = new List<Object>();
        }

        public void deleteUniqueItems()
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] is UniqueItem)
                {
                    list.Remove(i);
                    i--;
                }
            }

        }

        public void add(Object o)
        {
            bool result = false;
            for (int i = 0; i < list.Count; i++)
            {
                if (o is UniqueItem)
                {
                    if (list[i].ToString().Equals(o.ToString()))
                    {
                        UniqueItem obj = (UniqueItem)o;
                        obj.quantity++;
                        o = obj;
                        result = true;
                    }
                }
            } 
            if (!result)
            {
                list.Add(o);
            }
        }

        public override String ToString()
        {
            String result = "Backpack:\n";
            foreach (Object o in list)
            {
                result += o.ToString();
                result += "\n";
            }
            return result;
        }
    }
}
