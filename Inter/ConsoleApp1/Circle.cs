using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Circle:IFunck
    {
        int r;

        public Circle(int r)
        {
            this.r = r;
        }

        public double S()
        {
            return Math.PI * Math.Pow(r,2);
        }
        public double P()
        {
            return 2 * Math.PI * r;
        }
        public string ToString()
        {
            return $"Радиус = {r} \n" +
                $"S = {S()}\n" +
                $"P = {P()}\n\n";
        }
    }
}
