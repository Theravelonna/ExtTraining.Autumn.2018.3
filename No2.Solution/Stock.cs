using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No2.Solution
{
    public class Stock
    {
        public event EventHandler<StockEventArgs> StockEvent = delegate { };

        public void NewEvent()
        {
            OnStartTimer(new StockEventArgs());
        }

        protected virtual void OnStartTimer(StockEventArgs e)
        {
            StockEvent?.Invoke(this, e);
        }
    }
}
