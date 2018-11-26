using System;

namespace No6
{
    public static class GeneratorSequence<T>
    {
        public static T[] Generate(int countElements, Func<int, T> strategy)
        {
            ValidationData(countElements, strategy);

            return GenerateSequence(countElements, strategy);
        }

        private static T[] GenerateSequence(int countElements, Func<int, T> strategy)
        {
            int i = 0;
            T[] resultArray = new T[countElements];

            while (i < countElements)
            {
                resultArray[i++] = strategy(i);
            }

            return resultArray;
        }

        private static void ValidationData(int countElements, Func<int, T> strategy)
        {
            if (strategy == null)
            {
                throw new ArgumentNullException($"{nameof(strategy)} can't be null!");
            }

            if (countElements < 0)
            {
                throw new ArgumentNullException($"{nameof(countElements)} can't less than null!");
            }

        }
    }
}
