using System;

namespace Task3.Solution
{
    public class Stock
    {
        public event EventHandler<MessageEventArgs> currencyPurchase;
        private StockInfo stocksInfo;

        public Stock(StockInfo stockInfo)
        {
            this.stocksInfo = stockInfo;
        }

        public void Notify()
        {
            currencyPurchase(this, new MessageEventArgs(stocksInfo));
        }

        public void Market()
        {
            Random rnd = new Random();
            stocksInfo.USD = rnd.Next(20, 40);
            stocksInfo.Euro = rnd.Next(30, 50);
            Notify();
        }
    }
}

