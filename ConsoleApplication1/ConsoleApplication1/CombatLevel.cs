using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class CombatLevel : Level
    {
        public int minions;
        public MinionFactory minionFactory;
        public Party party;
        public CombatLevel(GoodGuy disney, WeaponBehavior weapon, BossBehavior boss, int minions, int position,Party party)
        {
            this.minionFactory = new MinionFactory();
            this.towerPosition = position;
            this.disney = disney;
            this.minions = minions;
            this.party = party;
            initialize(weapon, boss);
            for (int i = 0; i < minions; i++)
            {
                createMinions();
            }
            changenulls();
        }
        public void createMinions()
        {
            int row, col;
            do
            {
                row = random();
                col = random();
            } while (!(this.level[row, col].type is GenericRoom) || (this.level[row, col].minion != null));
            this.level[row, col].minion = minionFactory.createParty();
            this.level[row, col].size++;
        }
        public override bool objective()
        {
            if (this.minions==this.party.enemiesDefeated)
            {
                return true;
            }
            return false;
        }


    }
}
