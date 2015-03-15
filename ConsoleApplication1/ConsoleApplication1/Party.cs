using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public class Party
    {
        private GoodGuy[] Party;
        private List<string> Characters;
        private int EnemiesDefeated;

        public Party(GoodGuy a, GoodGuy b, GoodGuy c,List<string> characters)
        {
            this.Characters = characters;
            Party = new GoodGuy[3];
            this.EnemiesDefeated = 0;
            Party[0] = a;
            Party[1] = b;
            Party[2] = c;
        }
        public int GetEnemiesDefeated()
        {
            return this.EnemiesDefeated;
        }
        public void AddEnemiesDefeated(int value)
        {
            this.EnemiesDefeated += value;
        }

        //return GoodGuy at the specified index
        public GoodGuy GetParty(int index)
        {
            return Party[index];
        }

        //sets the GoodGuy at the specified index
        public void SetParty(GoodGuy chara, int index)
        {
            Party[index] = chara;
        }

        //prints the names of party members
        public override string ToString()
        {
            String str = ("Your party consists of " + Party[0].ToString() + ", " + Party[1].ToString() + ", and " + Party[2].ToString() + ". ");
            return str;
        }

        //returns true if the party is still alive within battle
        public bool PartyAlive()
        {
            if (!Party[0].IsAlive() && !Party[1].IsAlive() && !Party[2].IsAlive())
            {
                return false;
            }
            return true;
        }


        //asks if they would like to add the unlocked character to party
        //if so swaped and change the available characters
        //if not add character to available characters
        public void UnlockCharacter(GoodGuy character, Party party)
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
                Characters.Add(party.GetParty(choice).ToString());
                party.SetParty(character, choice);
                Console.WriteLine(this);
                Console.WriteLine();
            }
            else
            {
                Characters.Add(character.ToString());
            }
        }

        public void UsePotion(PotionBehavior potion)
        {
            int choice;
            do
            {
                Console.WriteLine("Who would you like to use the potion on");
                for (int x = 0; x < 3; x++)
                {
                    Console.WriteLine((x + 1) + ". " + Party[x]);
                }
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
            Party[choice - 1].AddHp(potion.getHP());
        }

        internal void UpdateStats()
        {
            Party[0].FullHeal();
            Party[1].FullHeal();
            Party[2].FullHeal();
        }
    }
}
