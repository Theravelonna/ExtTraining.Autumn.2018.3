using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No6.Solution.Tests.HelpClasses
{
    public class GeneratorDouble
    {
        private double previousElement;
        private double nextElement;

        public GeneratorDouble(double firstElement, double secondElement)
        {
            previousElement = firstElement;
            nextElement = secondElement;
        }

        public double GenerateNumber(int count)
        {
            int tmp;
            if (count == 1)
            {
                return previousElement;
            }
            if (count == 2)
            {
                return nextElement;
            }
            else
            {
                tmp = previousElement;
                previousElement = nextElement;
                nextElement = 1.0 * (tmp + previousElement) / previousElement;
                return nextElement;
            }
        }
    }
}
