using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class LevelWithItems : Level
    {
        public List<UniqueItem> target;
        public Backpack pack;
        public LevelWithItems(GoodGuy disney, WeaponBehavior weapon, BossBehavior boss, String[] items, String[] target, Backpack pack)
        {

            this.disney = disney;
            initialize(weapon, boss);
            this.target = new List<UniqueItem>();
            targetToList(target);
            this.pack = pack;
            foreach (string item in items)
            {
                createUniqueItems(item);
            }
            changenulls();
            printLevelObjective();
        }


        public void printLevelObjective()
        {
            Console.WriteLine(disney + " needs your help!!\n");
            Console.WriteLine("Find these items for " + disney + ":");
            foreach (UniqueItem item in this.target)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }

        public void targetToList(String[] target)
        {
            bool result = false;
            foreach (string item in target)
            {
                result = false;
                foreach (UniqueItem o in this.target)
                {
                    if (item.Equals(o.description))
                    {
                        o.quantity++;
                        result = true;
                    }
                }
                if (!result)
                {
                    this.target.Add(new UniqueItem(item));
                }
            }
        }

        public void createUniqueItems(String description)
        {
            int row, col;
            do
            {
                row = random();
                col = random();
            } while (!(this.level[row, col].type is GenericRoom) || !(this.level[row, col].unique==null));
            this.level[row, col].unique = new UniqueItem(description);
            this.level[row, col].size++;
        }

        public override bool objective()
        {
            bool result = false;
            foreach (UniqueItem item in target)
            {
                result = false;
                foreach (Object o in pack.list)
                {
                        if(o is UniqueItem)
                        {
                            UniqueItem obj = (UniqueItem)o;
                            if (obj.description.Equals(item.description)&&obj.quantity>=item.quantity)
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

    }
}
