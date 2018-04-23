using System;

namespace Task3.Solution
{
    public class MessageEventArgs : EventArgs
    {
        public MessageEventArgs(StockInfo stock)
        {
            Stock = stock;
        }

        public StockInfo Stock { get; private set; }
    }
}
