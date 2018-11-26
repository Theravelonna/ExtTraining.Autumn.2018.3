using No6.Solution.Tests.HelpClasses;
using NUnit.Framework;

namespace No6.Solution.Tests
{
    [TestFixture]
    public class CustomEnumerableTests
    {
        [Test]
        public void Generator_ForSequence1()
        {
            int[] expected = {1, 1, 2, 3, 5, 8, 13, 21, 34, 55};

            GeneratorInt generator = new GeneratorInt(1, 1);
            int[] result = GeneratorSequence<int>.Generate(10, generator.GenerateNumber);

            CollectionAssert.AreEqual(expected, result);
        }

        [Test]
        public void Generator_ForSequence2()
        {
            int[] expected = { 1, 2, 4, 8, 16, 32, 64, 128, 256, 512 };

            GeneratorIntOther generator = new GeneratorIntOther(1, 2);
            int[] result = GeneratorSequence<int>.Generate(10, generator.GenerateNumber);

            CollectionAssert.AreEqual(expected, result);
        }

        [Test]
        public void Generator_ForSequence3()
        {
            double[] expected = { 1, 2, 2.5, 3.3, 4.05757575757576, 4.87086926018965, 5.70389834408211, 6.55785277425587, 7.42763417076325, 8.31053343902137 };

            GeneratorDouble generator = new GeneratorDouble(1, 2);
            double[] result = GeneratorSequence<double>.Generate(10, generator.GenerateNumber);

            CollectionAssert.AreEqual(expected, result);
        }
    }
}
