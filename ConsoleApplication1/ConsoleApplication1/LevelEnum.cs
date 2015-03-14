using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class LevelEnum: IEnumerator
    {
        private Level[] tower;

    // Enumerators are positioned before the first element 
    // until the first MoveNext() call. 
    int position = -1;

    public LevelEnum(Level[] list)
    {
        tower = list;
    }

    public bool MoveNext()
    {
        position++;
        return (position < tower.Length);
    }

    public void Reset()
    {
        position = -1;
    }

    object IEnumerator.Current
    {
        get
        {
            return Current;
        }
    }

    public Level Current
    {
        get
        {
            try
            {
                return tower[position];
            }
            catch (IndexOutOfRangeException)
            {
                throw new InvalidOperationException();
            }
        }
    }
    }
}
