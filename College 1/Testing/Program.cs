namespace Opdracht_1C
{
    class Program
    {
        static void Main(string[] args)
        {
            int Floors = 9;
            int Lifts = 4;
            int Persons = Lifts;

            int[] PersonFloor = new int[Persons];
            int[] PersonLift = new int[Persons];
            int[] availableLifts = new int[Lifts];

            Random random = new(); // initialize random since Random() can't be called on it's own

            random.Shuffle(availableLifts); // shuffle the available lifts

            for (int i = 0; i < Persons; i++)
            {
                availableLifts[i] = i; // assign values to each position in the array
                PersonFloor[i] = new Random().Next(0, Floors); // assign a random floor to each person
                PersonLift[i] = availableLifts[i]; // assign a unique lift to each person
            }

            for (int i = 0; i < Floors; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < Lifts; j++)
                {
                    bool personInLift = false;

                    for (int u = 0; u < Persons; u++)
                    {
                        if (i == PersonFloor[u] && j == PersonLift[u]) // checks if lift is already in use
                        {
                            personInLift = true;
                            break;
                        }
                    }
                    Console.ForegroundColor = personInLift ? ConsoleColor.DarkBlue : Console.ForegroundColor;
                    Console.Write(personInLift ? "|U|" : "|_|");
                    Console.ResetColor();
                }
            }
        }
    }
}
