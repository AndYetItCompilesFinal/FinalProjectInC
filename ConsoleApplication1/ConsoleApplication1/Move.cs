using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Move
    {
        private int CurrentRow;
        private int CurrentCol;
        private Level Level=null;
        private Room[,] Rooms;
        private Party Party;
        private Backpack Pack;
        private Context Context;
        public Move(Party party, Backpack pack)
        {
            this.Party = party;
            this.Pack = pack;
            Context = new Context();
        }


        public void findEntrance(Level level)
        {
            this.Level = level;
            this.Rooms = level.GetLevel();
            for (int row = 0; row < Rooms.GetLength(0); row++)
            {
                for (int col = 0; col < Rooms.GetLength(1); col++)
                {
                    if (Rooms[row, col].GetRoomType() is Entrance)
                    {
                        this.CurrentRow = row;
                        this.CurrentCol = col;
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
                    if (CurrentRow > 0)
                    {
                        return moveNorth();
                    }
                    else
                        Console.WriteLine("Cannot move north");
                    break;
                case 2:
                    if (CurrentRow < 4)
                    {
                        return moveSouth();
                    }
                    else
                        Console.WriteLine("Cannot move south");
                    break;
                case 3:
                    if (CurrentCol < 4)
                    {
                        return moveEast();
                    }
                    else
                        Console.WriteLine("Cannot move east");
                    break;
                case 4:
                    if (CurrentCol > 0)
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
            this.CurrentCol++;
            return Level.ExecuteRoom(this.Context,this.CurrentRow, this.CurrentCol,this.Party,this.Pack);
        }

        public bool moveWest()
        {
            this.CurrentCol--;
            return Level.ExecuteRoom(this.Context, this.CurrentRow, this.CurrentCol, this.Party, this.Pack);
        }

        public bool moveSouth()
        {
            this.CurrentRow++;
            return Level.ExecuteRoom(this.Context, this.CurrentRow, this.CurrentCol, this.Party, this.Pack);
        }

        public bool moveNorth()
        {
            this.CurrentRow--;
            return Level.ExecuteRoom(this.Context, this.CurrentRow, this.CurrentCol, this.Party, this.Pack);
        }

    }
}
