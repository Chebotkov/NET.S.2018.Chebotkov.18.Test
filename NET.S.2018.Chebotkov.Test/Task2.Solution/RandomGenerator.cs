using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.Solution
{
    public class RandomGenerator : Generator
    {
        private IRandom random;

        public RandomGenerator(IRandom random)
        {
            if (random == null)
            {
                throw new ArgumentNullException("{0} is null.", nameof(random));
            }

            this.random = random;
        }

        public override string FileExtension => ".txt";

        public override string WorkingDirectory => "Files with random chars";

        protected override byte[] GenerateFileContent(int contentLength)
        {
            return random.Random(contentLength);
        }
    }
}
