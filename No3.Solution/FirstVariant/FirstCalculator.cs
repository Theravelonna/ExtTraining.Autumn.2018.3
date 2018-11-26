using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Первый способ решения задачи. Использован интерфейс для передачи стратегии подсчета 
 * среднего значения (классы с подсчетом в тестовом проекте)*/

namespace No3.Solution.FirstVariant
{
    public static class FirstCalculator
    {
        public static double CalculateAverage(List<double> values, IAverageCalculator average)
        {
            if (values == null)
            {
                throw new ArgumentNullException(nameof(values));
            }

            return average.FindAverage(values);
        }
    }
}
