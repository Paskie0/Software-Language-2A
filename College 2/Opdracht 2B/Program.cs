namespace Opdracht_2B
{
    class Program
    {
        static void Main()
        {
            FizzBuzz();
            Console.WriteLine();
            FibonacciItterative(0, 1, 0, 15);
            Console.WriteLine();
            Console.WriteLine(FibonacciRecursive(15));
        }
        static void FizzBuzz()
        {
            for (int i = 1; i <= 315; i++)
            {
                string s = "";

                if (i % 3 == 0)
                    s += "Fizz";
                if (i % 5 == 0)
                    s += "Buzz";
                if (i % 7 == 0)
                    s += "Bang";
                if (i % 9 == 0)
                    s += "Boom";

                Console.WriteLine($"{i} {s}");
            }
        }
        static void FibonacciItterative(int a, int b, int c, int n)
        {
            for (int i = 0; i < n; i++)
            {
                c = a + b;
                a = b;
                b = c;
                Console.WriteLine(c);
            }
        }
        static public int FibonacciRecursive(int n)
        {
            if (n <= 1)
                return n;

            return FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);
        }
    }
}