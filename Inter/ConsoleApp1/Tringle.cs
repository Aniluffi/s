using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Tringle
    {
        int a;
        int b;
        int c;

        public Tringle(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public double S()
        {
            //формула Герона
            //полупериметр

            double p = P() / 2;
            //сама формула
            return Math.Sqrt(p*(p-a)*(p-b)*(p-c));
        }

        public double P()
        {
            return a + b + c;
        }

        public string ToString()
        {
            return $"Сторона a = {a} \n" +
                $"Сторона c = {c} \n" +
                $"Сторона b = {b} \n" +
                $"S = {S()}\n" +
                $"P = {P()}\n\n";
        }
    }
}
