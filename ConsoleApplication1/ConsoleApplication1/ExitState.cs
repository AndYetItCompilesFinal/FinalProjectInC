using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class ExitState:State
    {
        public bool DoAction(Context context, Room room, Party party, Backpack pack, Level level, BattleState battleState,BadGuy[] bad)
        {
            context.setState(this);
            if (!level.objective())
            {
                Console.WriteLine("Oh no you have not finished your objective");
                return false;
            }
            else
            {
                Console.WriteLine("You completed the level objective!");
                party.unlockCharacter(level.GetDisney(), party);//unlock character
                pack.deleteUniqueItems();
                Console.WriteLine("Boss Battle!!!!!!");
                return battleState.DoAction(context,room,party,pack,level,battleState,bad);
            }
            
        }
    }
}
