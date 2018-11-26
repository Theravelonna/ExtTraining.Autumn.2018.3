using System;

namespace No2.Solution
{
    public class Broker
    {
        public string Name { get; set; }

        public Broker(string name, Stock stock)
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
                eventArgs.USD > 30
                    ? $"Broker {this.Name} sells dollars; Dollar rate: {eventArgs.USD}"
                    : $"Broker {this.Name} buys dollars; Dollar rate: {eventArgs.USD}");
        }
    }
}
