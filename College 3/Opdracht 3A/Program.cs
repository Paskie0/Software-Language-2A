namespace Opdracht_3A
{
    class Program
    {
        static string[] testData = ["Emma Mulder", "Sara De Groot", "Emma Bakker", "Milan Van Dijk", "Emma Smit", "Daan Meijer", "Julia Visser", "Noah Mulder", "Julia Smit", "Sara Van Dijk", "Levi De Groot", "Tess Visser", "Sem Smit", "Levi Visser", "Sara De Boer"];
        public static List<string> contacts = new(testData);
        static void Main()
        {
            GetContacts();
            EditContact();
        }
        static void GetContacts()
        {
            Console.WriteLine("Contacts:\n");
            for (int i = 0; i < contacts.Count; i++)
            {
                Console.WriteLine($"{contacts[i]} {i + 1}");
            }
        }

        static void EditContact()
        {
            Console.WriteLine("Enter the number of the contact you want to select");

            int input = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"You have selected {contacts[input - 1]}");
            Console.WriteLine("What would you like to do with this contact?");
            Console.WriteLine("1. Edit");
            Console.WriteLine("2. Delete");

            int selectedOption = Convert.ToInt32(Console.ReadLine());

            if (selectedOption == 1)
            {
                Console.WriteLine("Enter the new name for this contact");
                string newName = Console.ReadLine()!;
                contacts[input - 1] = newName;
                Console.WriteLine("Contact updated");
                Console.WriteLine("Press any key to show updated contact list");
                Console.ReadKey();
                Console.Clear();
                GetContacts();
            }

            else
            {
                contacts.RemoveAt(input - 1);
                Console.WriteLine("Contact deleted");
                Console.WriteLine("Press any key to show updated contact list");
                Console.ReadKey();
                Console.Clear();
                GetContacts();
            }
        }
    }
}