using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public class Room
    {
        private MinionBehavior minion = null;
        private UniqueLevelItemBehavior unique = null;
        private RoomTypeBehavior type = null;
        private PotionBehavior potion = null;
        private int row;
        private int col;
        private int size;
        public Room(int row, int col, RoomTypeBehavior type)
        {
            this.row = row;
            this.col = col;
            this.type = type;
            this.size = 0;
        }
        public UniqueLevelItemBehavior GetUnique()
        {
            return unique;
        }
        public MinionBehavior GetMinion()
        {
            return minion;
        }
        public RoomTypeBehavior GetRoomType()
        {
            return type;
        }
        public PotionBehavior GetPotion()
        {
            return potion;
        }
        public int GetSize()
        {
            return size;
        }
        public void SetPotion(PotionBehavior potion)
        {
            this.potion = potion;
        }
        public void SetMinion(MinionBehavior minion)
        {
            this.minion = minion;
        }
        public void SetUnique(UniqueLevelItemBehavior unique)
        {
            this.unique = unique;
        }
        public void SubtractSize()
        {
            size--;
        }
        public void AddSize()
        {
            size++;
        }

        public override string ToString()
        {
            String result = "";
            if (type is Exit)
            {
                return "";
            }
            result += type.ToString();
            if (this.size == 0)
            {
                result += " is empty";
            }
            else
            {
                if (!(minion is NoMinions))
                {
                    result += minion.ToString();
                }
                if (!(potion is NoPotion))
                {
                    result += potion.getDescription();
                }
                if (!(unique is NoUniqueItems))
                {
                    result += unique.getDescription();
                }
            }
            return result;
        }
    }
}
