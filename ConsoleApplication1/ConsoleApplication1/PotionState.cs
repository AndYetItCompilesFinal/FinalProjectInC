using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class PotionState: State
    {
        public bool DoAction(Context context, Room room, Party party, Backpack pack, Level level, BattleState battleState, BadGuy[] bad)
        {
            context.SetState(this);
            int choice;
            if (!(room.GetPotion() is Poison10HP))
            {
                do
                {
                    Console.WriteLine("You have found a potion");
                    Console.WriteLine("What would you like to do:");
                    Console.WriteLine("1. Use it");
                    Console.WriteLine("2. Put it in your backpack");
                    Console.WriteLine("3. Leave in room");
                    Console.WriteLine();


                    Console.Write("Choice-->");
                    bool tryParse = int.TryParse(Console.ReadLine(), out choice);
                    if (!tryParse)
                    {
                        choice = -1;
                    }
                    Console.WriteLine();
                    if (choice < 1 || choice > 3)
                    {
                        Console.WriteLine("I am sorry that is an invalid menu choice.");
                        Console.WriteLine("Please try again");
                        Console.WriteLine();
                    }//end of if

                } while (choice < 1 || choice > 3);
                switch (choice)
                {
                    case 1:
                        party.UsePotion(room.GetPotion());
                        room.SetPotion(new NoPotion());
                        room.SubtractSize();
                        break;
                    case 2:
                        pack.Add(room.GetPotion());
                        room.SetPotion(new NoPotion());
                        room.SubtractSize();
                        break;
                    default:
                        break;
                }//end of switch
            }
            else
            {
                pack.Add(room.GetPotion());
                room.SetPotion(new NoPotion());
                room.SubtractSize();
            }

            return false;


        }
    }
}
