namespace Opdracht_1B
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's your first name?");
            string firstName = Console.ReadLine()!;
            Console.WriteLine("What about an infix?");
            string infix = Console.ReadLine()!;
            Console.WriteLine("And your last name?");
            string lastName = Console.ReadLine()!;
            Console.WriteLine("How about your date of birth?");
            string dateOfBirth = Console.ReadLine()!;
            Console.WriteLine("Now, for your adress, what's your street name?");
            string streetName = Console.ReadLine()!.ToUpper();
            Console.WriteLine("And your house number?");
            string houseNumber = Console.ReadLine()!;
            Console.WriteLine("Any additions to your house number?");
            string houseNumberAddition = Console.ReadLine()!;
            Console.WriteLine("Nearly there, what's your postal code? (e.g. 1234AB)");
            string postalCode = Console.ReadLine()!;
            Console.WriteLine("Almost done! What about your city?");
            string city = Console.ReadLine()!;
            Console.WriteLine("Finally, in what country do you reside?");
            string country = Console.ReadLine()!;

            Console.WriteLine("Thank you for your input! Here's your information:");
            Console.WriteLine($"Name: {lastName}, {firstName} {(string.IsNullOrWhiteSpace(infix) ? "" : "(" + infix + ")")}");
            Console.WriteLine($"Date of birth: {dateOfBirth}");
            Console.WriteLine($"Adress: {streetName} {houseNumber}{houseNumberAddition}, {(postalCode.Contains(' ') ? postalCode : postalCode.Insert(4, " "))} {city}");
            Console.WriteLine(string.IsNullOrWhiteSpace(country) ? "" : $"Country: {country}");
        }
    }

}