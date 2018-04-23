using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.Solution
{
    public class Randomizer : IRandom
    {
        byte[] IRandom.Random(int size)
        {

            var random = new Random();

            const string input = "abcdefghijklmnopqrstuvwxyz0123456789";

            var chars = Enumerable.Range(0, size).Select(x => input[random.Next(0, input.Length)]);

            var bytes = Encoding.Unicode.GetBytes(chars.ToArray());

            return bytes;
        }
    }
}
