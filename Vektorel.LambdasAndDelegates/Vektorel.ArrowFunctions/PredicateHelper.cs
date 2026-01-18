using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vektorel.ArrowFunctions
{
    class PredicateHelper
    {
        //Func delegate kullanımı, tanıma bağlı olarak;
        //son generic parametre return olmak üzere diğerleri fonksiyon parametresi gibi düşünülnelidir
        public int MultiplyBy2(Func<int, int> function, int value)
        {
            return function(value) * 2;
        }
    }

    class PlayGround
    {
        public void Try()
        {
            var ph = new PredicateHelper();
            var a = ph.MultiplyBy2(x => x + 3, 9);
        }

        public int B(int v)
        {
            return v + 3;
        }

        public int Topla(int a)
        {
            Func<int, int> localFunction = x => x + 10;
            return localFunction(a);
        }
    }
}
