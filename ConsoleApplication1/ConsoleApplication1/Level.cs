using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public abstract class Level
    {
        private Room[,] level = new Room[5, 5];
        private int towerPosition;
        private GoodGuy disney;
        private BadGuy boss;
        private MinionBehavior noMinion = new NoMinions();
        private UniqueLevelItemBehavior noUnique = new NoUniqueItems();
        private PotionBehavior noPotion = new NoPotion();
        private PotionState potionState = new PotionState();
        private MinionState minionState = new MinionState();
        private ExitState exitState = new ExitState();
        private UniqueState uniqueState = new UniqueState();
        private BattleState battleState = new BattleState();

        public abstract bool objective();
        public abstract void printLevelObjective();
        public Level(GoodGuy disney)
        {
            this.disney = disney;
        }

        public void initialize(BadGuy boss)
        {
            this.boss = boss;
            entrance();
            exit();
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
        public void exit()
        {
            int row, col;
            do
            {
                row = random();
                col = random();
            } while (this.level[row, col] != null);
            this.level[row, col] = new Room(row, col, new Exit());
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
            } while (!(this.level[row, col].GetRoomType() is GenericRoom) || !(this.level[row, col].GetPotion() == null));
            this.level[row, col].SetPotion(potion);
            this.level[row, col].AddSize();
        }
        public void changenulls()
        {
            for (int row = 0; row < level.GetLength(0); row++)
            {
                for (int col = 0; col < level.GetLength(1); col++)
                {
                    if (this.level[row, col].GetMinion() == null)
                    {
                        this.level[row, col].SetMinion(noMinion);
                    }
                    if (this.level[row, col].GetUnique()==null)
                    {
                        this.level[row, col].SetUnique(noUnique);
                    }

                    if (this.level[row, col].GetPotion() == null)
                    {
                        this.level[row, col].SetPotion(noPotion);
                    }
                }//inner for loop
            }//outer for loop
        }
        public GoodGuy GetDisney()
        {
            return disney;
        }
        public Room[,] GetLevel()
        {
            return level;
        }
        public bool executeRoom(Context context, int row, int col, Party party, Backpack pack)
        {
            //backpack
            //party
            Console.WriteLine(level[row,col]);
            if (!(level[row, col].GetPotion() is NoPotion))
            {
                potionState.DoAction(context, level[row, col], party, pack, this, battleState,null);
                //potionstate
            }//end of if
            if (!(level[row, col].GetMinion() is NoMinions))
            {
                minionState.DoAction(context, level[row, col], party, pack, this, battleState,null);
                //minionorbattlestate
            }
            //int index;
            if (level[row, col].GetUnique() is UniqueItem)
            {
                uniqueState.DoAction(context, level[row, col], party, pack, this, battleState,null);
                //uniquestate
            }
            if (level[row, col].GetRoomType() is Exit)
            {
                return exitState.DoAction(context, level[row, col], party, pack, this, battleState,new BadGuy[]{this.boss});
                //exitstate
            }//end 
            Console.WriteLine(this);
            return false;
        }

        public String itemType(Room room)
        {

            if (room.GetRoomType() is Entrance)
            {
                return "I";
            }
            if (room.GetRoomType() is Exit)
            {
                return "O";
            }
            if (room.GetSize() > 1)
            {
                return "M";
            }
            else if (room.GetUnique() is UniqueItem)
            {
                return "U";
            }
            else if (!(room.GetPotion() is NoPotion))
            {
                return "P";
            }
            else if (!(room.GetMinion() is NoMinions))
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
