using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public class Room
    {
        public WeaponBehavior weapon = null;
        public MinionBehavior minion = null;
        public BossBehavior boss = null;
        public UniqueLevelItemBehavior unique = null;
        public RoomTypeBehavior type = null;
        public PotionBehavior potion = null;
        public int row;
        public int col;
        public int size;
        public Room(int row, int col, RoomTypeBehavior type)
        {
            this.row = row;
            this.col = col;
            this.type = type;
            this.size = 0;
        }

        public override string ToString()
        {
            String result = "";
            result += type.ToString();
            if (this.size == 0)
            {
                result += " is empty";
            }
            else
            {
                if (!(weapon is NoWeapon))
                {
                    result += weapon.ToString();
                }
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
