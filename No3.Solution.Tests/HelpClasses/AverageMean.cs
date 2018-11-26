using No3.Solution.FirstVariant;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No3.Solution.Tests.HelpClasses
{
    public class AverageMean : IAverageCalculator
    {
        public double FindAverage(List<double> values)
        {
            return values.Sum() / values.Count;
        }
    }
}
