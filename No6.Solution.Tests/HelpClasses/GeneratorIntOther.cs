using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No6.Solution.Tests
{
    public class GeneratorIntOther
    {
        private int previousElement;
        private int nextElement;

        public GeneratorIntOther(int firstElement, int secondElement)
        {
            previousElement = firstElement;
            nextElement = secondElement;
        }

        public int GenerateNumber(int count)
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
                nextElement = 6 * previousElement - 8 * tmp;
                return nextElement;
            }
        }
    }
}
