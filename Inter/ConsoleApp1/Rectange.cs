using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Rectange:IFunck
    {
        int a;
        int b;

        public Rectange(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public double S()
        {
            return a * b;
        }

        public double P() 
        {
            return (a + b) * 2;
        }

        public string ToString()
        {
            return $"Сторона a = {a} \n" +
                $"Сторона b = {b} \n" +
                $"S = {S()}\n" +
                $"P = {P()}\n\n";
        }
    }
}
