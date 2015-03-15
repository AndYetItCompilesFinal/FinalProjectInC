using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class BattleState:State
    {
        private List<Character> Characters;
        private BadGuy[] Bad;
        private Backpack Pack;
        private Party Party;
        private static Random Rand = new Random();
        public bool DoAction(Context context, Room room, Party party, Backpack pack, Level level, BattleState battleState,BadGuy[] bad)
        {
            context.SetState(this);
            Console.WriteLine("You are fighting:");
            this.Pack = pack;
            this.Party = party;
            this.Bad = bad;
            this.Characters = new List<Character>();
            //adding all characters to list
            for (int i = 0; i < bad.Length; i++)
            {
                //printing enemies
                Console.WriteLine(Bad[i]);
                Characters.Add(Bad[i]);
            }
            for (int i = 0; i < 3; i++)
            {
                Characters.Add(party.GetParty(i));
            }
            Console.WriteLine();
            //selection sort
            SortBySpeed();

            bool win = Round();
            if (win)
            {
                Console.WriteLine("Your party won the fight!");
                return true;
            }
            else
            {
                Console.WriteLine("Your party lost the fight!");
                return false;
            }
        }//end of constructor



        public void SortBySpeed()
        {
            for (int i = 0; i < Characters.Count - 1; i++)
            {
                int index = i;
                for (int j = i + 1; j < Characters.Count; j++)
                {
                    if (Characters[j].GetSpeed() > Characters[index].GetSpeed())
                    {
                        index = j;
                    }
                }
                if (index != i)
                {
                    Character temp = Characters[i];
                    Characters[i] = Characters[index];
                    Characters[index] = temp;
                }
            }
            //end of sort
        }

        //Continues to go through turn order and runs turn operations
        public bool Round()
        {
            //if at least one memver from each group is alive
            while (Party.PartyAlive() && !EnemyAlive(Bad))
            {
                foreach (Character character in Characters)
                {
                    if (character.IsAlive())
                    {
                        Console.WriteLine(character.ToString() + "'s turn!");
                        Console.WriteLine();
                        //if good guy
                        if (character is GoodGuy)
                        {
                            if (DisplayMenu((GoodGuy)character))
                            {
                                return true;
                            }
                        }
                        //if badguy
                        else
                        {
                            if (!VillanTurn((BadGuy)character))
                            {
                                if (!Party.PartyAlive())
                                {
                                    //party loses
                                    return false;
                                }
                            }
                        }
                    }
                }
            }
            return true;
        }

        //Calculates a random damage in a range
        public int Damage(int str, int basenum)
        {
            int dmg = basenum;
            for (int i = 1; i <= str; i++)
            {
                dmg += ((int)((Rand.NextDouble() * 5) + 1));
            }
            dmg += basenum;
            return dmg;
        }

        //Lets user pick to attack or use an item
        public bool DisplayMenu(GoodGuy goodguy)
        {
            int choice;
            do
            {
                Console.WriteLine("Do you want to: ");
                Console.WriteLine("1. Attack");
                Console.WriteLine("2. Use Item");
                Console.WriteLine("Enter your choice: ");
                bool tryParse = int.TryParse(Console.ReadLine(), out choice);
                if (!tryParse)
                {
                    choice = -1;
                }
                Console.WriteLine();
                if (choice < 1 || choice > 2)
                {

                    Console.WriteLine("Invalid menu choice");
                }

            } while (choice < 1 || choice > 2);
            if (choice == 1)//attack
            {
                int baseAttack = goodguy.ChooseAttack();
                int dmg = Damage(goodguy.GetAttack(), baseAttack);
                int index = ChooseTarget();
                //possibility of dodge
                if (Bad[index].DodgeAttempt())
                {
                    Console.WriteLine("The attack missed.");
                }
                //attack hits
                else
                {
                    Console.WriteLine("The attack hit for " + dmg + ".");
                    Console.WriteLine();
                    if (!Bad[index].ApplyDamage(dmg))
                    {
                        Remove(index);
                        if (EnemyAlive(Bad))
                        {
                            return true;
                        }
                    }
                }
                Console.WriteLine();
            }
            else//use item
            {
                PotionBehavior potion=Pack.UseItem();
                if (!(potion is NoPotion))
                {
                    if (potion is Poison10HP)
                    {
                        int x = ChooseTarget();
                        Bad[x].ApplyDamage(potion.getHP());
                        Pack.Remove(potion);
                    }
                    else
                    {
                        Party.UsePotion(potion);
                        Pack.Remove(potion);
                    }
                }
                else
                {
                    Console.WriteLine("Your backpack is empty");
                }
            }
            return false;
        }

        //Automatically runs through the villan's turn, returning whether the hero survived the attack
        public bool VillanTurn(BadGuy badguy)
        {
            int baseAttack;
            int damageValue;
            baseAttack = badguy.ChooseAttack();
            damageValue = Damage(badguy.GetAttack(), baseAttack);
            // choose hero to attack
            int choice;
            bool survived = true;
            do
            {
                choice = ((int)(Rand.NextDouble() * 3));
                //choose a party member that is alive
            } while (!Party.GetParty(choice).IsAlive());
                    if (Party.GetParty(choice).DodgeAttempt())
                    {
                        Console.WriteLine("The attack missed.");
                    }
                    else
                    {
                        Console.WriteLine("The attack hit for " + damageValue + ".");
                        survived = Party.GetParty(choice).ApplyDamage(damageValue);
                    }
            return survived;
        }

        //Lets the user choose the target to attack
        public int ChooseTarget()
        {
            int target = 0;
            while (target < 1 || target > Bad.Length)
            {
                Console.WriteLine("Who do you want to attack?");
                for (int i = 0; i < Bad.Length; i++)
                {
                    Console.WriteLine(i + 1 + ". " + Bad[i].ToString()); ;
                }
                Console.WriteLine("Enter the number here: ");

                bool tryParse = int.TryParse(Console.ReadLine(), out target);
                if (!tryParse)
                {
                    target = -1;
                }
                Console.WriteLine();

                if (target < 1 || target > Bad.Length)
                {
                    Console.WriteLine("Invalid number.");
                }
            }
            return target - 1;
        }

        //returns whether the good guys won or not
        public bool EnemyAlive(BadGuy[] bad)
        {
            for (int i = 0; i < bad.Length; i++)
            {
                if (bad[i].IsAlive())
                {
                    return false;
                }
            }
            return true;
        }

        public void Remove(int index)
        {
            if (Bad.Length != 1)
            {
                BadGuy[] temp = new BadGuy[Bad.Length - 1];
                for (int i = 0; i < index; i++)
                {
                    temp[i] = Bad[i];
                }
                for (int i = index + 1; i < Bad.Length; i++)
                {
                    temp[i - 1] = Bad[i];
                }
                Bad = temp;
            }
        }
    }
}
