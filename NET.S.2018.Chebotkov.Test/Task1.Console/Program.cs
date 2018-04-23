using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.Solution;

namespace Task1.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            PasswordCheckerService passwordCheckerService = new PasswordCheckerService();
            var a = passwordCheckerService.VerifyPassword("sadsda");
            System.Console.WriteLine(a);
            var b = passwordCheckerService.VerifyPassword("sadsadd21ds");
            System.Console.WriteLine(b);


            var c = passwordCheckerService.VerifyPassword("sadsda");
            System.Console.WriteLine(c);
            var d = passwordCheckerService.VerifyPassword("sadsadd21ds");
            System.Console.WriteLine(d);

        }
    }
}
