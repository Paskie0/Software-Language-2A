namespace Opdracht_3B_4
{
    class Program
    {
        static void Main()
        {
            Person person1 = new();
            Person person2 = new();

            Console.WriteLine(Person.InstanceCount());
        }
    }

    public class Person
    {
        private static int instanceCounter = 0;

        public Person()
        {
            instanceCounter++;
        }

        public static int InstanceCount()
        {
            return instanceCounter;
        }
    }
}