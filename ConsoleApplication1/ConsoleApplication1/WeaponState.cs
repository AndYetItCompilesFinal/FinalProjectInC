using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class WeaponState:State
    {
        public bool DoAction(Context context, Room room, Party party, Backpack pack, Level level, BattleState battleState)
        {
            context.setState(this);
            int choice;
            Console.WriteLine("You have found a weapon");
            do
            {
                Console.WriteLine("What would you like to do:");
                Console.WriteLine("1. Use this Weapon");
                Console.WriteLine("2. Leave in room");
                Console.WriteLine();


                Console.Write("Choice-->");
                bool tryParse = int.TryParse(Console.ReadLine(), out choice);
                if (!tryParse)
                {
                    choice = -1;
                }
                Console.WriteLine();
                if (choice < 1 || choice > 2)
                {
                    Console.WriteLine("I am sorry that is an invalid menu choice.");
                    Console.WriteLine("Please try again");
                    Console.WriteLine();
                }
            } while (choice < 1 || choice > 2);

            switch (choice)
            {
                case 1:
                    MainCharacter main = (MainCharacter)party.GetMain();
                    main.SetWeapon(room.weapon);
                    room.weapon = new NoWeapon();
                    room.size--;
                    break;
                default:
                    break;
            }//end of switch
            return false;
        }

    }
}
