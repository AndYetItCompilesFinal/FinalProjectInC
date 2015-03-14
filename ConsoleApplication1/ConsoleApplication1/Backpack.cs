﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public class Backpack
    {
        private List<Object> list;

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
                    list.RemoveAt(i);
                    i--;
                }
            }

        }

        public void Add(Object o)
        {
            bool result = false;
            for (int i = 0; i < list.Count; i++)
            {
                if (o is UniqueItem)
                {
                    UniqueItem obj = (UniqueItem)o;

                    if (list[i] is UniqueItem)
                    {
                        UniqueItem listobj = (UniqueItem)list[i];
                        if (listobj.GetDescription().Equals(obj.GetDescription()))
                        {
                            listobj.AddQuantity();
                            list[i] = listobj;
                            result = true;
                        }
                    }

                }
            }
            if (!result)
            {
                list.Add(o);
            }
        }

        public bool ContainsTarget(List<UniqueItem> target)
        {
            bool result = false;
            foreach (UniqueItem item in target)
            {
                result = false;
                foreach (Object o in list)
                {
                    if (o is UniqueItem)
                    {
                        UniqueItem obj = (UniqueItem)o;
                        if (obj.GetDescription().Equals(item.GetDescription()) && obj.GetQuantity() >= item.GetQuantity())
                        {
                            result = true;
                        }
                    }

                }
                if (result == false)
                {
                    return result;
                }
            }
            return result;
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
