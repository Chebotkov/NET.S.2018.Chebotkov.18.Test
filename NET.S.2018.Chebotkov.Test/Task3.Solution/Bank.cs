using System;

namespace Task3.Solution
{
    public class Bank
    {
        private Stock stock;

        public string Name { get; set; }

        public Bank(string name, Stock stock)
        {
            this.Name = name;
            this.stock = stock;
            stock.currencyPurchase += Stock_currencyPurchase;
        }

        private void Stock_currencyPurchase(object sender, MessageEventArgs e)
        {
            StockInfo sInfo = (StockInfo)e.Stock;

            if (sInfo.Euro > 40)
                Console.WriteLine("Банк {0} продает евро;  Курс евро: {1}", this.Name, sInfo.Euro);
            else
                Console.WriteLine("Банк {0} покупает евро;  Курс евро: {1}", this.Name, sInfo.Euro);
        }
    }
}