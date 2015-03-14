using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //create party
            GoodGuyFactory partyfactory = new GoodGuyFactory();
            Party party = partyfactory.CreateParty();
            Console.WriteLine(party);
            Console.WriteLine();

            
            Backpack pack=new Backpack();
            BadGuy hades=new Hades();

            ////make tower
            Tower tower=new Tower(pack,party);
            Move move = new Move(party, pack);
            GameOptions mainMenu = new GameOptions(move, pack, party);
            foreach(Level level in tower)
            {
                Console.WriteLine(level);
                move.findEntrance(level);
                mainMenu.run();
            }

           
            
            Console.ReadLine();
        }
    }
}
