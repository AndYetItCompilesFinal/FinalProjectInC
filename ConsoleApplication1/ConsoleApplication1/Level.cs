using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public abstract class Level
    {
        private Room[,] level = new Room[5, 5];
        private GoodGuy Disney;
        private BadGuy Boss;
        private MinionBehavior NoMinion = new NoMinions();
        private UniqueLevelItemBehavior NoUnique = new NoUniqueItems();
        private PotionBehavior NoPotion = new NoPotion();
        private PotionState PotionState = new PotionState();
        private MinionState MinionState = new MinionState();
        private ExitState ExitState = new ExitState();
        private UniqueState UniqueState = new UniqueState();
        private BattleState BattleState = new BattleState();

        public abstract bool Objective();
        public abstract void PrintLevelObjective();
        public Level(GoodGuy disney)
        {
            this.Disney = disney;
        }

        public void Initialize(BadGuy boss)
        {
            this.Boss = boss;
            Entrance();
            Exit();
            GenerateRooms();
            Potion(new HealthPotionHP10());//10hp
            Potion(new HealthPotionHP15());//15hp
            Potion(new MaxHealthPotion());//maxhp
            Potion(new Poison10HP());//poison
        }//end of class
        public void Entrance()
        {
            int row = Random();
            int col = Random();
            this.level[row, col] = new Room(row, col, new Entrance());
        }
        public void Exit()
        {
            int row, col;
            do
            {
                row = Random();
                col = Random();
            } while (this.level[row, col] != null);
            this.level[row, col] = new Room(row, col, new Exit());
        }
        public void GenerateRooms()
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
        public void Potion(PotionBehavior potion)
        {
            int row, col;
            do
            {
                row = Random();
                col = Random();
            } while (!(this.level[row, col].GetRoomType() is GenericRoom) || !(this.level[row, col].GetPotion() == null));
            this.level[row, col].SetPotion(potion);
            this.level[row, col].AddSize();
        }
        public void ChangeNulls()
        {
            for (int row = 0; row < level.GetLength(0); row++)
            {
                for (int col = 0; col < level.GetLength(1); col++)
                {
                    if (this.level[row, col].GetMinion() == null)
                    {
                        this.level[row, col].SetMinion(NoMinion);
                    }
                    if (this.level[row, col].GetUnique()==null)
                    {
                        this.level[row, col].SetUnique(NoUnique);
                    }

                    if (this.level[row, col].GetPotion() == null)
                    {
                        this.level[row, col].SetPotion(NoPotion);
                    }
                }//inner for loop
            }//outer for loop
        }
        public GoodGuy GetDisney()
        {
            return Disney;
        }
        public Room[,] GetLevel()
        {
            return level;
        }
        public bool ExecuteRoom(Context context, int row, int col, Party party, Backpack pack)
        {
            //backpack
            //party
            Console.WriteLine(level[row,col]);
            if (!(level[row, col].GetPotion() is NoPotion))
            {
                PotionState.DoAction(context, level[row, col], party, pack, this, BattleState,null);
                //potionstate
            }//end of if
            if (!(level[row, col].GetMinion() is NoMinions))
            {
                MinionState.DoAction(context, level[row, col], party, pack, this, BattleState,null);
                //minionorbattlestate
            }
            //int index;
            if (level[row, col].GetUnique() is UniqueItem)
            {
                UniqueState.DoAction(context, level[row, col], party, pack, this, BattleState,null);
                //uniquestate
            }
            if (level[row, col].GetRoomType() is Exit)
            {
                return ExitState.DoAction(context, level[row, col], party, pack, this, BattleState,new BadGuy[]{this.Boss});
                //exitstate
            }//end 
            Console.WriteLine(this);
            return false;
        }

        public String ItemType(Room room)
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
                        result = result + ItemType(this.level[row, col]) + "|";
                    }
                    else
                        result = result + ItemType(this.level[row, col]) + "*";
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

        public int Random()
        {
            Random random = new Random();
            return random.Next(5);
        }//end of method

    }
}
