using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Tower:IEnumerable
    {
        private Level[] tower;
        public Tower(Backpack pack,Party party)
        {
            
            Level level1= new CombatLevel(new RobinHood(), new KingRichard(),4,party);
            Level level2 = new CombatLevel(new Mulan(), new Shanyu(), 4, party);
            Level level3=new LevelWithItems(new Belle(),new Gaston(),new String[]{"Rose","Teacup","Clock","Candlestick","Book","Book","Book"},new String[]{"Rose","Book","Book","Teacup"},pack);
            Level level4=new LevelWithItems(new PeterPan(),new CaptainHook(),new String[]{"Fairy Dust","Fairy Dust","Fairy Dust","Treasure","Treasure","Teddy Bear"},new String[]{"Fairy Dust","Fairy Dust","Treasure","Teddy Bear"},pack);
            Level level5=new CombatLevel(new Simba(),new Scar(),4,party);
            Level level6=new LevelWithItems(new Aladdin(),new Jafar(),new String[]{"Magic Carpet","Treasure","Treasure","Magic Lamp","Apple","Apple"},new String[]{"Magic Carpet","Treasure","Magic Lamp","Apple"},pack);
            Level level7=new CombatLevel(new MrIncerdible(),new Syndrome(),4,party);
            Level level8=new CombatLevel(new Hercules(),new Hades(),4,party);
            Level level9=new LevelWithItems(new Mike(),new Randal(),new String[]{"Doll","Door","Door","Door","Scream","Scream"},new String[]{"Doll","Door","Scream","Scream"},pack);
            Level level10=new LevelWithItems(new Ariel(),new Ursula(),new String[]{"Fork","Thimble","Statue","Painting","Chess Piece","Book"},new String[]{"Fork","Thimble","Painting","Chess Piece"},pack);

            //tower = new Level[] { level1, level2 ,level3,level4,level5,level6,level7,level8,level9,level10};
            tower = new Level[] { level10 };
        }

        public Level GetLevel(int cur)
        {
            return tower[cur];
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)GetEnumerator();
        }

        public LevelEnum GetEnumerator()
        {
            return new LevelEnum(tower);
        }

    }
}
