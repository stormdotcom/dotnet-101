using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Myclass
    {
        public int getNumber()
        {
            return 112;
        }
        public string getString()
        {
            return "Test";
        }

        // overloading
        public float getNumber(double a)
        {
            double b = a + 11.1;
            return (float) b;
        }
    }
}
