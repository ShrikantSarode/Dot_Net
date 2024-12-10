using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ShrikantDotNet
{
    public class Simple
    {    
     
        public void m1()
        {

            int _a = 10;
            double _b = _a;

            float _c = 10.11f;
            int _d = (int)_c;

            Console.WriteLine("Implicit :"+_b);
            Console.WriteLine("Explicit :" + _d);

        }
    }
}
