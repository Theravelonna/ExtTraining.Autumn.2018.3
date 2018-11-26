using System;

namespace No2.Solution
{
    public class Bank
    {
        public string Name { get; set; }

        public Bank(string name, Stock stock)
        {
            this.Name = name;
            stock.StockEvent += Message;
        }

        public void Unregister(Stock stock)
        {
            stock.StockEvent -= Message;
        }

        private void Message(object sender, StockEventArgs eventArgs)
        {
            Console.WriteLine(
                eventArgs.Euro > 40
                    ? $"Bank {this.Name} sells euros; Euro rate:{eventArgs.Euro}"
                    : $"Bank {this.Name} is buying euros; Euro rate: {eventArgs.Euro}");
        }
    }
}
