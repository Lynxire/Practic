using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class1
    {
        public double formula (double x,double y)
        {
            double g = 1;
            return g = Math.Log(Math.Pow(y, -Math.Sqrt(Math.Abs(x)))) * (Math.Sin(x) + Math.Pow(Math.E, x + y));
        }
    }
}
