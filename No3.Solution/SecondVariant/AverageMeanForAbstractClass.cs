using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No3.Solution.SecondVariant
{
    public class AverageMeanForAbstractClass : AbstractCalculator
    {
        public override double FindAverage(List<double> values)
        {
            return values.Sum() / values.Count;
        }
    }
}
