namespace No4.Solution.Console
{
    using System;
    using No4.Solution.RandomFileGenerators;

    class Program
    {
        static void Main(string[] args)
        {
            RandomFileGenerateManager manager = new RandomFileGenerateManager(new RandomBytesFileGenerator());
            manager.GenerateFiles(1, 7);

            RandomFileGenerateManager secondManager = new RandomFileGenerateManager(new RandomCharsFileGenerator());
            secondManager.GenerateFiles(1, 8);

            Console.ReadKey();
        }
    }
}
