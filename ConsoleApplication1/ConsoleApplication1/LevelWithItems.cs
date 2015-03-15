using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class LevelWithItems : Level
    {
        private List<UniqueItem> Target;
        private Backpack Pack;
        public LevelWithItems(GoodGuy disney,BadGuy boss, String[] items, String[] target, Backpack pack):base(disney)
        {

            
            Initialize(boss);
            this.Target = new List<UniqueItem>();
            TargetToList(target);
            this.Pack = pack;
            foreach (string item in items)
            {
                CreateUniqueItems(item);
            }
            ChangeNulls();
        }


        public override void PrintLevelObjective()
        {
            Console.WriteLine(GetDisney() + " needs your help!!\n");
            Console.WriteLine("Find these items for " + GetDisney() + ":");
            foreach (UniqueItem item in this.Target)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }

        public void TargetToList(String[] target)
        {
            bool result = false;
            foreach (string item in target)
            {
                result = false;
                foreach (UniqueItem o in this.Target)
                {
                    if (item.Equals(o.GetDescription()))
                    {
                        o.AddQuantity();
                        result = true;
                    }
                }
                if (!result)
                {
                    this.Target.Add(new UniqueItem(item));
                }
            }
        }

        public void CreateUniqueItems(String description)
        {
            int row, col;
            do
            {
                row = Random();
                col = Random();
            } while (!(this.GetLevel()[row, col].GetRoomType() is GenericRoom) || !(GetLevel()[row, col].GetUnique() == null));
            GetLevel()[row, col].SetUnique(new UniqueItem(description));
            GetLevel()[row, col].AddSize();
        }

        public override bool Objective()
        {
            return Pack.ContainsTarget(this.Target);
        }

    }
}
