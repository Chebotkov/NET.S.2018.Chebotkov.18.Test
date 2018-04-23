using System;
using System.Collections.Generic;

namespace Test6.Solution
{
    public class Generator<T>
    {
        T a;
        T b;

        public Generator(T a, T b)
        {
            this.a = a;
            this.b = b;
        }

        public IEnumerable<T> Generate(int n, Func<T, T, T> func)
        {
            T prev = a; 
            T current = b;

            while (n>0)
            {
                n--;
                yield return current;

                T tmp = current;
                current = func(current, prev);
                prev = tmp;
            }
        }

        
        public static double Func(double n, double n1)
        {
            return n + n1;
        }


        public static double Func2(double n, double n1)
        {
            return 6 * n - 8 * n1;
        }


        public static double Func3(double n, double n1)
        {
            return n + n1 / n;
        }
    }
}
