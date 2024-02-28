namespace Opdracht_3A
{
    class Program
    {
        static string[] containers =
        [
            "QVDM8009762", "CJIG1905934", "FGCM4664607", "CFLG6697633",
            "EQOD4660076", "PGLD2285677", "IISX5619237", "QMNU0970619",
            "SXKB8127565", "WBGZ9043382", "BVLZ9518548", "ZNSF2844985",
            "MRMV5005868", "PSWG7783254", "MYXT5104082", "GATM3160561",
            "XTXY3685126", "JFGQ5602926", "ICKQ5740110", "LLEN8095860",
            "DJQQ9473760", "MLUL9881099", "ZVZT6648738", "ZCFF1692285",
            "KDQD6427718"
        ];

        static List<Stack<string>> stacks = [];

        static void Main()
        {
            int stackCount = 10;
            int maxStack = 5;
            int currentStack = 0;

            CreateStacks(stackCount);
            DistributeContainers(currentStack, maxStack, stackCount);
            Start(stackCount);
        }

        static void CreateStacks(int stackCount)
        {
            for (int i = 0; i < stackCount; i++)
            {
                stacks.Add(new());
            }
        }

        static void DistributeContainers(int currentStack, int maxStack, int stackCount)
        {
            Random rnd = new();

            // While loop initially returns false until stacks...Push() fills up the stack, at which point we move on to the next stack
            foreach (string container in containers)
            {
                while (stacks[currentStack].Count == maxStack)
                {
                    currentStack++;
                }

                stacks[rnd.Next(currentStack, stackCount)].Push(container); // Randomly distributes the containers between the stacks
            }
        }

        static void PrintContainers(int stackCount)
        {
            for (int i = 0; i < stackCount; i++)
            {
                Console.WriteLine($"Stack {i + 1}:");

                foreach (string container in stacks[i])
                {
                    Console.WriteLine(container);
                }

                Console.WriteLine();
            }

            Start(stackCount);
        }

        static void AddContainer(int stackCount)
        {
            Console.WriteLine("What is the number of the container you'd like to add?");

            string containerNumber = Console.ReadLine()!;

            int emptiestStack = 0;

            for (int i = 1; i < stacks.Count; i++) // i = 1 because otherwise the first comparison would be against itself
            {
                if (stacks[i].Count < stacks[emptiestStack].Count) // if any stack is smaller than our inital stack, set the value to that smaller stack
                {
                    emptiestStack = i;
                }
            }

            stacks[emptiestStack].Push(containerNumber);

            Start(stackCount);
        }

        static void GetContainer(int stackCount)
        {
            Console.WriteLine("Enter the number of the container you'd like to retrieve");

            string containerNumber = Console.ReadLine()!;

            int correctContainer = 0;

            for (int i = 0; i < stackCount; i++)
            {
                if (stacks[i].Contains(containerNumber) == true)
                {
                    correctContainer = i + 1;
                }
            }

            Console.WriteLine(correctContainer);
        }

        static void Start(int stackCount)
        {
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1: Add Container");
            Console.WriteLine("2: Get Container");
            Console.WriteLine("3: Show Containers");

            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    AddContainer(stackCount);
                    break;

                case 2:
                    GetContainer(stackCount);
                    break;

                case 3:
                    PrintContainers(stackCount);
                    break;

                default:
                    break;
            }
        }
    }
}
