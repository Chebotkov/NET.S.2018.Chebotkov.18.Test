using System;

namespace Task3.Solution
{
    public class Broker
    {
        private Stock stock;

        public string Name { get; set; }

        public Broker(string name, Stock stock)
        {
            this.Name = name;
            this.stock = stock;
            stock.currencyPurchase += Stock_currencyPurchase;
        }

        public void StopTrade()
        {
            stock.currencyPurchase -= Stock_currencyPurchase;
            stock = null;
        }


        private void Stock_currencyPurchase(object sender, MessageEventArgs e)
        {
            StockInfo sInfo = (StockInfo)e.Stock;
            if (sInfo.USD > 30)
                Console.WriteLine("Брокер {0} продает доллары;  Курс доллара: {1}", this.Name, sInfo.USD);
            else
                Console.WriteLine("Брокер {0} покупает доллары;  Курс доллара: {1}", this.Name, sInfo.USD);
        }
    }
}