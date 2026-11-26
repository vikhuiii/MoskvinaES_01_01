using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moskvina_01_02
{
    public class Pitanie_2:Pitanie
    {
        int P;
        public int _P { get { return P; } set { P = value; } }
        double Qp;
        public double _Qp { get { return Qp; } set { Qp = value; } }
        
        public Pitanie_2(string _name, int _countBelk, int _countUgl,int _p) :base(_name, _countBelk, _countUgl)
        {
            _p = P;
        }

        public double calculateQp(double Q)
        {
            if (P >= 0 && P <= 20)
            {
                Qp= Q - 0.5 * P * 9;
            }
            else { Qp= Q * 1.5 + P * 10; }
            return Qp;


        }
    }
}
