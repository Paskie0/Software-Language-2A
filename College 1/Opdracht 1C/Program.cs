namespace Opdracht_1C
{
    class Program
    {
        static void Main(string[] args)
        {
            int Floors = 9;
            int Lifts = 4;
            int Users = Lifts;

            int[] PersonFloor = new int[Users];
            int[] PersonLift = new int[Users];
            int[] availableLifts = new int[Lifts];
            int[] floorDistance = new int[Lifts];

            AssignUsers(availableLifts, PersonFloor, PersonLift, floorDistance, Floors, Users); // randomize the lifts and floors

            DrawLifts(Floors, Lifts, Users, PersonFloor, PersonLift); // draw the lifts

            int nearestFloor = Array.IndexOf(floorDistance, floorDistance.Min()); // find the nearest lift
            Console.WriteLine($"\nThe nearest lift to you is lift {nearestFloor + 1}, it is {floorDistance.Min()} floors away");
        }

        static void AssignUsers(int[] availableLifts, int[] PersonFloor, int[] PersonLift, int[] floorDistance, int Floors, int Users)
        {
            for (int i = 0; i < Users; i++)
            {
                availableLifts[i] = i; // assign values to each position in the array
                PersonFloor[i] = new Random().Next(0, Floors); // assign a random floor to each person
                PersonLift[i] = availableLifts[i]; // assign a unique lift to each person
                floorDistance[i] = (PersonFloor[i] + 1 - Floors) * -1; // calculate the distance to the nearest lift and turn it into a positive number
            }
        }

        static void DrawLifts(int Floors, int Lifts, int Users, int[] PersonFloor, int[] PersonLift)
        {
            for (int i = 0; i < Floors; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < Lifts; j++)
                {
                    bool personInLift = false;

                    for (int u = 0; u < Users; u++)
                    {
                        if (i == PersonFloor[u] && j == PersonLift[u]) // checks if lift is already in use
                        {
                            personInLift = true;
                            break;
                        }
                    }
                    Console.ForegroundColor = personInLift ? ConsoleColor.DarkBlue : Console.ForegroundColor;
                    Console.Write(personInLift ? "|P|" : "|_|");
                    Console.ResetColor();
                }
            }
        }
    }
}
