namespace Opdracht_3B_3
{
    class Program
    {
        static void Main()
        {
            Calculator.Add(10.5, 10);
            Calculator.Sub(100, 10);
        }
    }

    public static class Calculator
    {
        public static void Add(double a, double b)
        {
            Console.WriteLine(a * b);
        }

        public static void Sub(double a, double b)
        {
            Console.WriteLine(a - b);
        }
    }
}