using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class LevelWithItems : Level
    {
        private List<UniqueItem> target;
        private Backpack pack;
        public LevelWithItems(GoodGuy disney,BadGuy boss, String[] items, String[] target, Backpack pack):base(disney)
        {

            
            initialize(boss);
            this.target = new List<UniqueItem>();
            targetToList(target);
            this.pack = pack;
            foreach (string item in items)
            {
                createUniqueItems(item);
            }
            changenulls();
        }


        public override void printLevelObjective()
        {
            Console.WriteLine(GetDisney() + " needs your help!!\n");
            Console.WriteLine("Find these items for " + GetDisney() + ":");
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
                    if (item.Equals(o.GetDescription()))
                    {
                        o.AddQuantity();
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
            } while (!(this.GetLevel()[row, col].GetRoomType() is GenericRoom) || !(GetLevel()[row, col].GetUnique() == null));
            GetLevel()[row, col].SetUnique(new UniqueItem(description));
            GetLevel()[row, col].AddSize();
        }

        public override bool objective()
        {
            return pack.ContainsTarget(this.target);
        }

    }
}
