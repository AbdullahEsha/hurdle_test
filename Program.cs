using System.Transactions;

namespace HurdleTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Sales sales = new Sales();
            sales.Add(new Batch("2024x00001", "CompSci Books"));
            sales.Add(new Transaction("1", "Deep Learning in Python", 67.90m));
            sales.Add(new Transaction("2", "C# in Action", 54.10m));
            sales.Add(new Transaction("3", "Design Patterns", 129.75m));

            sales.Add(new Batch("2024x00002", "Fantasy Books"));
            sales.Add(new Transaction("00-0001", "Compilers", 134.60m));
            sales.Add(new Transaction("10-0003", "Hunger Games 1-3", 45.00m));
            sales.Add(new Transaction("15-0020", "Learning Blender", 56.90m));

            // empty batch
            sales.Add(new Batch("2024x00003", "Empty Batch"));

            // single order batch
            sales.Add(new Batch("2024x00004", "Single Order Batch"));
            sales.Add(new Transaction("00-0002", "The Hobbit", 12.50m));

            sales.PrintOrders();
        }
    }
}
