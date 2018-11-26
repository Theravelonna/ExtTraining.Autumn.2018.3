using System;

namespace No2.Solution
{
    public class StockEventArgs : EventArgs
    {
        private Random random = new Random();
        public StockEventArgs()
        {
            USD = random.Next(0, 100);
            Euro = random.Next(0, 200);
        }

        public int USD { get; private set; }
        public int Euro { get; private set; }
    }
}
