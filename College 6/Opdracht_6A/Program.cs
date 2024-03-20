namespace Opdracht_6A
{
    class Program
    {
        static void Main()
        {
            // try
            // {
            //     Console.Write("Voer de noemer in: ");
            //     int a = int.Parse(Console.ReadLine()!);
            //     Console.Write("Voer de deler in: ");
            //     int b = int.Parse(Console.ReadLine()!);
            //     Console.WriteLine($"{a} / {b} = {a / b}");
            // }
            // catch (DivideByZeroException)
            // {
            //     Console.WriteLine("Door 0 delen is onmogelijk, probeer het opnieuw.");
            //     Main();
            // }
            // catch (FormatException)
            // {
            //     Console.WriteLine("U heeft geen getal ingevoerd, probeer het opnieuw.");
            //     Main();
            // }
            Console.Write("Voer de noemer in: ");
            bool parseA = int.TryParse(Console.ReadLine(), out int a);
            Console.Write("Voer de deler in: ");
            bool parseB = int.TryParse(Console.ReadLine(), out int b);

            if (!parseA || !parseB)
            {
                Console.WriteLine("U heeft geen getal ingevoerd, probeer het opnieuw.");
                Main();
            }

            else if (b == 0)
            {
                Console.WriteLine("Door 0 delen is onmogelijk, probeer het opnieuw.");
                Main();
            }
            else
            {
                Console.WriteLine($"{a} / {b} = {a / b}");
            }
        }
    }
}
