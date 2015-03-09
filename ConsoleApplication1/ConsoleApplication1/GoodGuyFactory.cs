using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    internal class GoodGuyFactory
    {
        List<string> characters;
        public GoodGuyFactory()
        {
            //creates list of available characters
            this.characters = new List<String>()
                                    {
                                        "Pooh Bear",
                                        "Pocahontas",
                                        "Chicken Little",
                                        "Stitch",
                                        "Dumbo",
                                        "Pluto"
                                    };
        }

        //creates party and sends in list of available characters
        public Party CreateParty()
        {
            return new Party(MainCharacter(), ChooseCharacter(), ChooseCharacter(),this.characters);
        }
        //finds nameand creates the main character
        public GoodGuy MainCharacter()
        {
            Console.WriteLine("What is your name?");
            return new MainCharacter(Console.ReadLine(), new Weapon(10));
        }

        //dispays the available characters add asks for the one they would
        //like to use. this characters is then removed from list
        public GoodGuy ChooseCharacter()
        {
            int choice;
            int available = characters.Count;
            GoodGuy character = null;
            do
            {
                Console.WriteLine();
                Console.WriteLine("Choose a party member:");
                //Gives user the character choices
                for (int i = 0; i < available; i++)
                {
                    Console.WriteLine((i + 1) + ") " + characters[i]);
                }
                Console.WriteLine("Choice-->");
                bool tryParse = int.TryParse(Console.ReadLine(), out choice);
                if (!tryParse)
                {
                    choice = -1;
                }
                Console.WriteLine();
                //checks for invalid choice
                if (choice < 1 || choice > available)
                {
                    Console.WriteLine("I am sorry that is an invalid menu choice.");
                    Console.WriteLine("Please try again");
                    Console.WriteLine();
                }

            } while (choice < 1 || choice > available);

            string name = (characters[choice - 1]).ToString();
            //creates the character chosen
            if ("Pooh Bear".Equals(name))
            {
                character = new PoohBear();
                characters.Remove("Pooh Bear");
            }
            if ("Pocahontas".Equals(name))
            {
                character = new Pocahontas();
                characters.Remove("Pocahontas");
            }
            if ("Chicken Little".Equals(name))
            {
                character = new ChickenLittle();
                characters.Remove("Chicken Little");
            }
            if ("Stitch".Equals(name))
            {
                character = new Stitch();
                characters.Remove("Stitch");
            }
            if ("Dumbo".Equals(name))
            {
                character = new Dumbo();
                characters.Remove("Dumbo");
            }
            if ("Pluto".Equals(name))
            {
                character = new Pluto();
                characters.Remove("Pluto");
            }

            return character;
        }



    }
}
