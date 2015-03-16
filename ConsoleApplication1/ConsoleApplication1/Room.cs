using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public class Room
    {
        private MinionBehavior Minion = null;
        private UniqueLevelItemBehavior Unique = null;
        private RoomTypeBehavior Type = null;
        private PotionBehavior Potion = null;
        private int Row;
        private int Col;
        private int Size;
        private bool HasVisited;
        public Room(int row, int col, RoomTypeBehavior type)
        {
            this.Row = row;
            this.Col = col;
            this.Type = type;
            this.Size = 0;
            this.HasVisited = false;
        }
        public UniqueLevelItemBehavior GetUnique()
        {
            return Unique;
        }
        public MinionBehavior GetMinion()
        {
            return Minion;
        }
        public RoomTypeBehavior GetRoomType()
        {
            return Type;
        }
        public PotionBehavior GetPotion()
        {
            return Potion;
        }
        public int GetSize()
        {
            return Size;
        }
        public bool GetHasVisited()
        {
            return this.HasVisited;
        }
        public void SetHasVisited()
        {
            this.HasVisited = true;
        }
        public void SetPotion(PotionBehavior potion)
        {
            this.Potion = potion;
        }
        public void SetMinion(MinionBehavior minion)
        {
            this.Minion = minion;
        }
        public void SetUnique(UniqueLevelItemBehavior unique)
        {
            this.Unique = unique;
        }
        public void SubtractSize()
        {
            Size--;
        }
        public void AddSize()
        {
            Size++;
        }

        public override string ToString()
        {
            String result = "";
            if (Type is Exit)
            {
                return "";
            }
            result += Type.ToString();
            if (this.Size == 0)
            {
                result += " is empty";
            }
            else
            {
                if (!(Minion is NoMinions))
                {
                    result += Minion.ToString();
                }
                if (!(Potion is NoPotion))
                {
                    result += Potion.getDescription();
                }
                if (!(Unique is NoUniqueItems))
                {
                    result += Unique.getDescription();
                }
            }
            return result;
        }
    }
}
