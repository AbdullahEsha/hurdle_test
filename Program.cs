using System.Transactions;

namespace HurdleTask
{
    class Program
    {
        // Output:
        // Sales:
        // Batch sale: #2024x00001, CompSci Books
        // #1, Deep Learning in Python, $67.90
        // #2, C# in Action, $54.10
        // #3, Design Patterns, $129.75
        // Total: $251.75
        // Batch sale: #2024x00002, Fantasy Books
        // Empty order.
        // #00-0001, Compilers, $134.60
        // #10-0003, Hunger Games 1-3, $45.00
        // #15-0020, Learning Blender, $56.90
        // Sales total: $488.25
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

            sales.PrintOrders();
        }
    }
}
