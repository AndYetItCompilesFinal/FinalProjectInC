using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class CombatLevel : Level
    {
        private int TargetMinions;
        private MinionFactory MinionFactory;
        private Party party;
        public CombatLevel(GoodGuy disney,BadGuy boss, int minions,Party party):base(disney)
        {
            this.MinionFactory = new MinionFactory();
            this.TargetMinions = minions;
            this.party = party;
            initialize(boss);
            for (int i = 0; i < minions; i++)
            {
                createMinions();
            }
            changenulls();
        }

        public override void printLevelObjective()
        {
            Console.WriteLine(this.GetDisney()+" needs your help!!\n");
            Console.WriteLine("Defeat "+TargetMinions+" Minions");
        }

        public void createMinions()
        {
            int row, col;
            do
            {
                row = random();
                col = random();
            } while (!(GetLevel()[row, col].GetRoomType() is GenericRoom) || (GetLevel()[row, col].GetMinion() != null));
            GetLevel()[row, col].SetMinion(MinionFactory.createParty());
            GetLevel()[row, col].AddSize();
        }
        public override bool objective()
        {
            if (this.TargetMinions==this.party.GetEnemiesDefeated())
            {
                return true;
            }
            return false;
        }


    }
}
