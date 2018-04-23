using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4.Solution
{
    public class Calculator
    {
        public double CalculateAverage(List<double> values, IStrategy strategy)
        {
            if (values == null)
            {
                throw new ArgumentNullException(nameof(values));
            }

            if (strategy == null)
            {
                throw new ArgumentNullException(nameof(strategy));
            }

            return strategy.Calculate(values);
        }

        public double CalculateAverage(List<double> values, Func<List<double>, double> strategy)
        {
            if (values == null)
            {
                throw new ArgumentNullException(nameof(values));
            }

            if (strategy == null)
            {
                throw new ArgumentNullException(nameof(strategy));
            }

            return strategy(values);
        }

    }
}
