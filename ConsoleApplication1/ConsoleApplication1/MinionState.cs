using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class MinionState:State
    {
        public bool DoAction(Context context, Room room, Party party, Backpack pack, Level level, BattleState battleState)
        {
            int num = room.minion.GetMinions();
            bool win;
            Console.WriteLine("There is a bad guy in the room!!");
            Console.WriteLine("Battle " + num + " Minions");
            Console.WriteLine();
            if (num == 1)
            {
                win=battleState.Battle(party, room.minion.Minion, pack);
            }
            else
            {
                win=battleState.Battle(party, room.minion.Minions, pack);
            }
            if (win)
            {
                party.enemiesDefeated += room.minion.Numofminions;
                room.minion = new NoMinions();
                room.size--;
            }
            
            return win ;
        }
    }
}
