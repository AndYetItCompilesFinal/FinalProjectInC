using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public abstract class Level
    {
        public Room[,] level = new Room[5, 5];
        public int towerPosition;
        public GoodGuy disney;
        WeaponBehavior noWeapon = new NoWeapon();
        MinionBehavior noMinion = new NoMinions();
        BossBehavior noBoss = new NoBoss();
        UniqueLevelItemBehavior noUnique = new NoUniqueItems();
        PotionBehavior noPotion = new NoPotion();
        PotionState potionState = new PotionState();
        WeaponState weaponState = new WeaponState();
        MinionState minionState = new MinionState();
        ExitState exitState = new ExitState();
        UniqueState uniqueState = new UniqueState();

        public abstract bool objective();

        public void initialize(WeaponBehavior weapon, BossBehavior boss)
        {
            entrance();
            exit(boss);
            levelWeapon(weapon);
            generateRooms();
            potion(new HealthPotionHP10());//10hp
            potion(new HealthPotionHP15());//15hp
            potion(new MaxHealthPotion());//maxhp
            potion(new Poison10HP());//poison
        }//end of class
        public void entrance()
        {
            int row = random();
            int col = random();
            this.level[row, col] = new Room(row, col, new Entrance());
        }
        public void exit(BossBehavior boss)
        {
            int row, col;
            do
            {
                row = random();
                col = random();
            } while (this.level[row, col] != null);
            this.level[row, col] = new Room(row, col, new Exit());
            this.level[row, col].boss = boss;
        }
        public void levelWeapon(WeaponBehavior weapon)
        {
            int row, col;
            do
            {
                row = random();
                col = random();
            } while (this.level[row, col] != null);
            this.level[row, col] = new Room(row, col, new GenericRoom());
            this.level[row, col].weapon = weapon;
            this.level[row, col].size++;
        }
        public void generateRooms()
        {
            for (int row = 0; row < level.GetLength(0); row++)
            {
                for (int col = 0; col < level.GetLength(1); col++)
                {
                    if (this.level[row, col] == null)
                    {
                        this.level[row, col] = new Room(row, col, new GenericRoom());
                    }
                }
            }
        }
        public void potion(PotionBehavior potion)
        {
            int row, col;
            do
            {
                row = random();
                col = random();
            } while (!(this.level[row, col].type is GenericRoom) || !(this.level[row, col].potion == null));
            this.level[row, col].potion = potion;
            this.level[row, col].size++;
        }
        public void changenulls()
        {
            for (int row = 0; row < level.GetLength(0); row++)
            {
                for (int col = 0; col < level.GetLength(1); col++)
                {

                    if (this.level[row, col].weapon == null)
                    {
                        this.level[row, col].weapon = noWeapon;
                    }
                    if (this.level[row, col].minion == null)
                    {
                        this.level[row, col].minion = noMinion;
                    }
                    if (this.level[row, col].boss == null)
                    {
                        this.level[row, col].boss = noBoss;
                    }
                    if (this.level[row, col].unique == null)
                    {
                        this.level[row, col].unique = noUnique;
                    }

                    if (this.level[row, col].potion == null)
                    {
                        this.level[row, col].potion = noPotion;
                    }
                }//inner for loop
            }//outer for loop
        }

        public Room[,] getTwoD()
        {
            return this.level;
        }
        public bool executeRoom(Context context, int row, int col, Party party, Backpack pack)
        {
            //backpack
            //party
            Console.WriteLine(level[row,col]);
            if (!(level[row, col].potion is NoPotion))
            {
                potionState.DoAction(context, level[row, col], party, pack, this);
                //potionstate
            }//end of if

            if (!(level[row, col].weapon is NoWeapon))
            {
                weaponState.DoAction(context, level[row, col], party, pack, this);
                //weaponstate
            }//end of if
            if (!(level[row, col].minion is NoMinions))
            {
                minionState.DoAction(context, level[row, col], party, pack, this);
                //minionorbattlestate
            }
            //int index;
            if (level[row, col].unique is UniqueItem)
            {
                uniqueState.DoAction(context, level[row, col], party, pack, this);
                //uniquestate
            }
            if (level[row, col].type is Exit)
            {
                return exitState.DoAction(context, level[row, col], party, pack, this);
                //exitstate
            }//end 
            Console.WriteLine(this);
            return false;
        }

        public String itemType(Room room)
        {

            if (room.type is Entrance)
            {
                return "I";
            }
            if (room.type is Exit)
            {
                return "O";
            }
            if (room.size > 1)
            {
                return "M";
            }
            else if (room.unique is UniqueItem)
            {
                return "U";
            }
            else if (!(room.potion is NoPotion))
            {
                return "P";
            }
            else if (!(room.weapon is NoWeapon))
            {
                return "W";
            }
            else if (!(room.minion is NoMinions))
            {
                return "B";
            }
            else
            {
                return "E";
            }
        }

        public override string ToString()
        {
            String result = "***********";
            for (int row = 0; row < this.level.GetLength(0); row++)
            {
                result = result + "\n*";
                for (int col = 0; col < this.level.GetLength(1); col++)
                {
                    if (col < level.GetLength(1) - 1)
                    {
                        result = result + itemType(this.level[row, col]) + "|";
                    }
                    else
                        result = result + itemType(this.level[row, col]) + "*";
                }//end of first inner for loop
                result = result + "\n*";
                for (int col2 = 0; col2 < this.level.GetLength(1); col2++)
                {
                    if (row < 4)
                    {
                        result = result + "-*";
                    }
                }//end of second inner for loop
            }//end of outer for loop
            result = result + "**********";

            return result;

        }//end of method

        public int random()
        {
            Random random = new Random();
            return random.Next(5);
        }//end of method

    }
}
