using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public delegate void Purchase(object stockInfo);
    public class Stock 
    {
        public event Purchase currencyPurchase;
        private StockInfo stocksInfo;

        public Stock()
        {
            stocksInfo = new StockInfo();
        }

        public void Notify()
        {
            currencyPurchase(stocksInfo);
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
