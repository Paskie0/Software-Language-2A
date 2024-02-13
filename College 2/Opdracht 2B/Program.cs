namespace Opdracht_2B
{
    class Program
    {
        static void Main()
        {
            Fibonacci(10);
            FizzBuzz();
        }
        static void FizzBuzz()
        {
            for (int i = 1; i <= 99; i++)
            {
                switch (i)
                {
                    case var _ when i % 3 == 0 && i % 5 == 0:
                        Console.WriteLine("FizzBuzz");
                        break;
                    case var _ when i % 3 == 0:
                        Console.WriteLine("Fizz");
                        break;
                    case var _ when i % 5 == 0:
                        Console.WriteLine("Buzz");
                        break;
                    case var _ when i % 7 == 0:
                        Console.WriteLine("Bang");
                        break;
                    default:
                        Console.WriteLine(i);
                        break;
                }
            }
        }
        static int Fibonacci(int n)
        {
            if (n <= 1)
                return n;

            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }
}