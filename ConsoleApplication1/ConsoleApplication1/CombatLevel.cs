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
        private Party Party;
        public CombatLevel(GoodGuy disney,BadGuy boss, int minions,Party party):base(disney)
        {
            this.MinionFactory = new MinionFactory();
            this.TargetMinions = minions;
            this.Party = party;
            Initialize(boss);
            for (int i = 0; i < minions; i++)
            {
                CreateMinions();
            }
            ChangeNulls();
        }

        public override void PrintLevelObjective()
        {
            Console.WriteLine(this.GetDisney()+" needs your help!!\n");
            Console.WriteLine("Defeat "+TargetMinions+" Minions");
        }

        public void CreateMinions()
        {
            int row, col;
            do
            {
                row = Random();
                col = Random();
            } while (!(GetLevel()[row, col].GetRoomType() is GenericRoom) || (GetLevel()[row, col].GetMinion() != null));
            GetLevel()[row, col].SetMinion(MinionFactory.CreateParty());
            GetLevel()[row, col].AddSize();
        }
        public override bool Objective()
        {
            if (this.TargetMinions<=this.Party.GetEnemiesDefeated())
            {
                return true;
            }
            return false;
        }


    }
}
