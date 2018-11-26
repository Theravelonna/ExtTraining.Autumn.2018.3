using System;
using System.Collections.Generic;

/*Первый способ решения задачи. Использован абстрактный класс с абстрактным методом подсчета
 * среднего значения (для обязательного переопределения стратегии подсчета в наследуемых классах) */

namespace No3.Solution.SecondVariant
{
    public class SecondCalculator
    {
        public static double CalculateAverage(List<double> values, AbstractCalculator average)
        {
            if (values == null)
            {
                throw new ArgumentNullException(nameof(values));
            }

            return average.FindAverage(values);
        }
    }
}
