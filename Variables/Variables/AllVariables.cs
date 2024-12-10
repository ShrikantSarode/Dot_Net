using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    public class AllVariables
    {
        static String _static = "Static variable";
        String _initi = "Initialize variable";

        //instance variable
        int _instance_Variable;
        public void var()
        {
            String _Local = "Local variable";

            Console.WriteLine(_static);
            Console.WriteLine(_initi);
            Console.WriteLine(_Local);

        }
    }
}
