using Task3.Solution;

namespace Task3.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            StockInfo stockInfo = new StockInfo();
            stockInfo.Euro = 50;
            stockInfo.USD = 500;
            Stock stock = new Stock(stockInfo);
            Bank bank = new Bank("Belinvest", stock);
            Broker broker = new Broker("Broker", stock);
            stock.Notify();

        }
    }
}
