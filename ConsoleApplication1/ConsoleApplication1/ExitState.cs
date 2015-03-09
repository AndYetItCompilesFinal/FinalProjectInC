using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class ExitState:State
    {
        public bool DoAction(Context context, Room room, Party party, Backpack pack, Level level)
        {
            context.setState(this);
            Console.WriteLine("You reached the stairs!");
            if (!level.objective())
            {
                Console.WriteLine("Oh no you have not finished your objective");
                return false;
            }
            else
            {
                Console.WriteLine("You completed the level objective!");
                party.unlockCharacter(level.disney, party);//unlock character
                //boss();
                pack.deleteUniqueItems();
                return true;
            }
            
        }
    }
}
