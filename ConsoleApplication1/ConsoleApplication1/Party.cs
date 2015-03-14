using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public class Party
    {
        private GoodGuy[] party;
        private List<string> characters;
        private int enemiesDefeated;

        public Party(GoodGuy a, GoodGuy b, GoodGuy c,List<string> characters)
        {
            this.characters = characters;
            party = new GoodGuy[3];
            this.enemiesDefeated = 0;
            party[0] = a;
            party[1] = b;
            party[2] = c;
        }
        public int GetEnemiesDefeated()
        {
            return this.enemiesDefeated;
        }
        public void AddEnemiesDefeated(int value)
        {
            this.enemiesDefeated += value;
        }

        //return GoodGuy at the specified index
        public GoodGuy GetParty(int index)
        {
            return party[index];
        }

        //sets the GoodGuy at the specified index
        public void SetParty(GoodGuy chara, int index)
        {
            party[index] = chara;
        }

        //prints the names of party members
        public override string ToString()
        {
            String str = ("Your party consists of " + party[0].ToString() + ", " + party[1].ToString() + ", and " + party[2].ToString() + ". ");
            return str;
        }

        //returns true if the party is still alive within battle
        public bool PartyAlive()
        {
            if (!party[0].IsAlive() && !party[1].IsAlive() && !party[2].IsAlive())
            {
                return false;
            }
            return true;
        }


        //asks if they would like to add the unlocked character to party
        //if so swaped and change the available characters
        //if not add character to available characters
        public void unlockCharacter(GoodGuy character, Party party)
        {
            int choice;
            do
            {
                Console.WriteLine("You have unlocked " + character.ToString());
                Console.WriteLine("Would you like to add them to your party?");
                Console.WriteLine("1) yes");
                Console.WriteLine("2) no");

                Console.WriteLine("Choice-->");
                bool tryParse = int.TryParse(Console.ReadLine(), out choice);
                if (!tryParse)
                {
                    choice = -1;
                }
                Console.WriteLine();

                if (choice != 1 && choice != 2)
                {
                    Console.WriteLine("I am sorry that is an invalid menu choice.");
                    Console.WriteLine("Please try again");
                    Console.WriteLine();

                }

            } while (choice != 1 && choice != 2);
            if (choice == 1)
            {
                do
                {
                    Console.WriteLine("Who would you like to swap?");
                    Console.WriteLine("1) " + party.GetParty(1).ToString());
                    Console.WriteLine("2) " + party.GetParty(2).ToString());
                    Console.WriteLine("Choice-->");

                    bool tryParse = int.TryParse(Console.ReadLine(), out choice);
                    if (!tryParse)
                    {
                        choice = -1;
                    }
                    Console.WriteLine();

                    if (choice != 1 && choice != 2)
                    {
                        Console.WriteLine("I am sorry that is an invalid menu choice.");
                        Console.WriteLine("Please try again");
                        Console.WriteLine();
                    }
                } while (choice != 1 && choice != 2);
                characters.Add(party.GetParty(choice).ToString());
                party.SetParty(character, choice);
                Console.WriteLine(this);
                Console.WriteLine();
            }
            else
            {
                characters.Add(character.ToString());
            }
        }

    }
}
