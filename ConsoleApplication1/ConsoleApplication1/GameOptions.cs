using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class GameOptions
    {
        private Move move;
        private bool end;
        private Backpack pack;
        private Party party;
        public GameOptions(Move move, Backpack pack, Party party)
        {
            this.party = party;
            this.pack = pack;
            this.move = move;
            end = false;
        }

        public void run()
      {
      	int choice;
         do{
            do{
               Console.WriteLine("Please select from the following menu choices:");
               Console.WriteLine("1.Move through the castle");
               Console.WriteLine("2.Open Backpack");
               Console.WriteLine("3.View Party Stats");
               Console.WriteLine("4.Quit");
               Console.WriteLine();		  	
               
               
               Console.Write("Choice-->");
               bool tryParse = int.TryParse(Console.ReadLine(), out choice);
               if (!tryParse)
               {
                   choice = -1;
               }
               Console.WriteLine();
               if (choice<1 || choice>4)
               {
                  Console.WriteLine("I am sorry that is an invalid menu choice.");
                  Console.WriteLine("Please try again");
                  Console.WriteLine();
               }
               
            } while (choice<1 || choice>4);
            
            switch (choice)
            {
               case 1: 
                  this.end=move.changeDirection();
                  break;
               case 2:
                 Console.WriteLine(pack);
                  break;
               case 3:
                  for(int i=0;i<3;i++)
                  {
                     Console.WriteLine(party.GetParty(i).PrintStats());
                     Console.WriteLine();
                  }
                  break;
               default:
						end=true;
                  break;
            }
         }while (end==false);
      }//end of method
    }
}
