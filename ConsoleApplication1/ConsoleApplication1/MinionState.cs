using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class MinionState:State
    {
        public bool DoAction(Context context, Room room, Party party, Backpack pack, Level level, BattleState battleState,BadGuy[] bad)
        {
            context.setState(this);
            BadGuy[] minions = room.GetMinion().GetMinions();
            int num = minions.Length;
            bool win;
            Console.WriteLine("There is a bad guy in the room!!");
            Console.WriteLine("Battle " + num + " Minions");
            Console.WriteLine();
            if (num == 1)
            {
                win = battleState.DoAction(context, room, party, pack, level, battleState, minions);
            }
            else
            {
                win = battleState.DoAction(context, room, party, pack, level, battleState, minions);
            }
            if (win)
            {
                party.AddEnemiesDefeated(num);
                room.SetMinion(new NoMinions());
                room.SubtractSize();
            }
            
            return win ;
        }
    }
}
