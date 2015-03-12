using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Tower:IEnumerable
    {
        Level[] tower;
        public Tower(Backpack pack,Party party)
        {
            
            Level level1= new CombatLevel(new RobinHood(), new Weapon(10), new Hades(),1,party);
            Level level2 = new CombatLevel(new Stitch(), new Weapon(10), new Hades(), 1, party);
            Level level3=new LevelWithItems(new Belle(),new Weapon(10),new Hades(),new String[]{"Rose","Teacup","Clock","Candlestick","Book","Book","Book"},new String[]{"Rose","Book","Book","Teacup"},pack);
            Level level4=new LevelWithItems(new PeterPan(),new Weapon(10),new Hades(),new String[]{"Fairy Dust","Fairy Dust","Fairy Dust","Treasure","Treasure","Teddy Bear"},new String[]{"Fairy Dust","Fairy Dust","Treasure","Teddy Bear"},pack);
            Level level5=new CombatLevel(new Simba(),new Weapon(10),new Hades(),1,party);
            Level level6=new LevelWithItems(new Aladdin(),new Weapon(10),new Hades(),new String[]{"Magic Carpet","Treasure","Treasure","Magic Lamp","Apple","Apple"},new String[]{"Magic Carpet","Treasure","Magic Lamp","Apple"},pack);
            Level level7=new CombatLevel(new MrIncerdible(),new Weapon(10),new Hades(),1,party);
            Level level8=new CombatLevel(new Hercules(),new Weapon(10),new Hades(),1,party);
            Level level9=new LevelWithItems(new Mike(),new Weapon(10),new Hades(),new String[]{"Doll","Door","Door","Door","Scream","Scream"},new String[]{"Doll","Door","Sream","Scream"},pack);
            Level level10=new LevelWithItems(new Ariel(),new Weapon(10),new Hades(),new String[]{"Fork","Thimble","Statue","Painting","Chess Piece","Book"},new String[]{"Fork","Thimble","Painting","Chess Piece"},pack);

            tower = new Level[] { level1, level2 ,level3,level4,level5,level6,level7,level8,level9,level10};
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
