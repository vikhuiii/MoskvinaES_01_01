using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moskvina_01_02
{
    public class Pitanie
    {
        string name;
        public string Name { get { return name; } set { name = value; } }
        int countBelk;
        public int CountBelk { get { return countBelk; } set { countBelk = value; } }
        int countUgl;
        public int CountUgl { get { return countUgl; } set { countUgl = value; } }
        double Q;
        double _Q { get { return Q; } set { Q = value; } }
        public Pitanie(string _name, int _taktChast, int _valeMemory)
        {
            name = _name;
            countBelk = _taktChast;
            countUgl = _valeMemory;
        }
        public double calculateQ()
        {
            Q= countUgl * 8 + countBelk * 5;
            return Q;
        }
    }
}
