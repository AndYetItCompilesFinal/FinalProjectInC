using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Move
    {
        private int currentRow;
        private int currentCol;
        private Level level=null;
        private Room[,] rooms;
        private Party party;
        private Backpack pack;
        private Context context;
        public Move(Party party, Backpack pack)
        {
            this.party = party;
            this.pack = pack;
            context = new Context();
        }


        public void findEntrance(Level level)
        {
            this.level = level;
            this.rooms = level.GetLevel();
            for (int row = 0; row < rooms.GetLength(0); row++)
            {
                for (int col = 0; col < rooms.GetLength(1); col++)
                {
                    if (rooms[row, col].GetRoomType() is Entrance)
                    {
                        this.currentRow = row;
                        this.currentCol = col;
                    }//end of if
                }//end of inner for loop
            }//end of outer for loop
        }//end of method


        public bool changeDirection()
        {
            int choice;

            do
            {
                Console.WriteLine("Which direction would you like to go:");
                Console.WriteLine("1.North");
                Console.WriteLine("2.South");
                Console.WriteLine("3.East");
                Console.WriteLine("4.West");
                Console.WriteLine("5.Go back to main menu");
                Console.WriteLine();


                Console.Write("Choice-->");
                bool tryParse = int.TryParse(Console.ReadLine(), out choice);
                if (!tryParse)
                {
                    choice = -1;
                }
                Console.WriteLine();

                if (choice < 1 || choice > 5)
                {
                    Console.WriteLine("I am sorry that is an invalid menu choice.");
                    Console.WriteLine("Please try again");
                    Console.WriteLine();
                }

            }
            while (choice < 1 || choice > 5);

            switch (choice)
            {
                case 1:
                    if (currentRow > 0)
                    {
                        return moveNorth();
                    }
                    else
                        Console.WriteLine("Cannot move north");
                    break;
                case 2:
                    if (currentRow < 4)
                    {
                        return moveSouth();
                    }
                    else
                        Console.WriteLine("Cannot move south");
                    break;
                case 3:
                    if (currentCol < 4)
                    {
                        return moveEast();
                    }
                    else
                        Console.WriteLine("Cannot move east");
                    break;
                case 4:
                    if (currentCol > 0)
                    {
                        return moveWest();
                    }
                    else
                        Console.WriteLine("Cannot move west");
                    break;
                default:

                    break;
            }
            return false;
        }//end of method


        public bool moveEast()
        {
            this.currentCol++;
            return level.executeRoom(this.context,this.currentRow, this.currentCol,this.party,this.pack);
        }

        public bool moveWest()
        {
            this.currentCol--;
            return level.executeRoom(this.context, this.currentRow, this.currentCol, this.party, this.pack);
        }

        public bool moveSouth()
        {
            this.currentRow++;
            return level.executeRoom(this.context, this.currentRow, this.currentCol, this.party, this.pack);
        }

        public bool moveNorth()
        {
            this.currentRow--;
            return level.executeRoom(this.context, this.currentRow, this.currentCol, this.party, this.pack);
        }

    }
}
