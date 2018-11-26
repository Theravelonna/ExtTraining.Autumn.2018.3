using System.Collections.Generic;
using No3.Solution.FirstVariant;
using No3.Solution.SecondVariant;
using No3.Solution.Tests.HelpClasses;
using NUnit.Framework;

namespace No3.Solution.Tests
{
    [TestFixture]
    public class TestCalculator
    {
        private readonly List<double> values = new List<double> { 10, 5, 7, 15, 13, 12, 8, 7, 4, 2, 9 };

        [Test]
        public void Test_AverageByMeanInterface()
        {
            double expected = 8.3636363;

            double actual = FirstCalculator.CalculateAverage(values, new AverageMean());

            Assert.AreEqual(expected, actual, 0.000001);
        }

        [Test]
        public void Test_AverageByMedianInterface()
        {
            double expected = 8.0;

            double actual = FirstCalculator.CalculateAverage(values, new AverageMedian());

            Assert.AreEqual(expected, actual, 0.000001);
        }

        [Test]
        public void Test_AverageByMeanAbstractClass()
        {
            double expected = 8.3636363;

            double actual = SecondCalculator.CalculateAverage(values, new AverageMeanForAbstractClass());

            Assert.AreEqual(expected, actual, 0.000001);
        }

        [Test]
        public void Test_AverageByMedianAbstractClass()
        {
            double expected = 8.0;

            double actual = SecondCalculator.CalculateAverage(values, new AverageMedianForAbstractClass());

            Assert.AreEqual(expected, actual, 0.000001);
        }
    }
}