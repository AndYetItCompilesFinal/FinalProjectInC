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

        public PotionBehavior UseItem()
        {
            if(list.Count==0)
            {
                return new NoPotion();
            }
            int i;
            int choice;
            int index;
            do{
                i = 0;
                index = 0;
            Console.WriteLine("What item would you like to use:");
            foreach(Object o in list)
            {
                if(o is PotionBehavior)
                {
                    Console.WriteLine((i + 1) + ") " + o.ToString());
                    i++;
                }
                index++;
            }
            Console.WriteLine();

            Console.Write("Choice-->");
            bool tryParse = int.TryParse(Console.ReadLine(), out choice);
            if (!tryParse)
            {
                choice = -1;
            }
            if (choice < 1 || choice > i)
            {
                Console.WriteLine("I am sorry that is an invalid menu choice.");
                Console.WriteLine("Please try again");
                Console.WriteLine();
            }
            } while (choice < 1 || choice > i);
            return (PotionBehavior)list[choice-1];
        }

        public void DeleteUniqueItems()
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
        
        public void Remove(Object o)
        {
            list.Remove(o);
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
                            Console.WriteLine(o.ToString() + " added to backpack");
                            list[i] = listobj;
                            result = true;
                        }
                    }

                }
            }
            if (!result)
            {
                list.Add(o);
                Console.WriteLine(o.ToString() +" added to backpack");
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
