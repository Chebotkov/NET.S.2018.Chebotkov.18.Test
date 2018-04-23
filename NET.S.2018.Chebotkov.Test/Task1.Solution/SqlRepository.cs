namespace Task1.Solution
{
    public class SqlRepository : IRepository
    {
        public void Create(string password)
        {
            System.Console.WriteLine("Written to sql.");
        }
    }
}