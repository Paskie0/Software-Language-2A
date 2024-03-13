namespace Opdracht_3B
{
    class Program
    {
        static void Main()
        {
            Bycicle bike1 = new()
            {
                locked = false,
                frameHeight = 50,
                lockType = Bycicle.Lock.ABUS,
                color = Bycicle.Color.Black
            };

            Bycicle bike2 = new()
            {
                locked = true,
                frameHeight = 61,
                lockType = Bycicle.Lock.CRC,
                color = Bycicle.Color.Blue
            };

            Bycicle bike3 = new()
            {
                locked = false,
                frameHeight = 43,
                lockType = Bycicle.Lock.AXA,
                color = Bycicle.Color.White
            };
        }
    }

    class Bycicle
    {
        public enum Lock
        {
            ABUS,
            AXA,
            CRC,
            Falkx
        }

        public enum Color
        {
            Black = 0x000000,
            White = 0xffffff,
            Grey = 0x212121,
            Blue = 0x4807ff,
            Red = 0xce1c1e
        }

        public Lock lockType;

        public Color color;

        public int frameHeight;

        public bool locked;

        public void LockBike()
        {
            if (locked == false)
            {
                locked = true;
            }
            else
            {
                Console.WriteLine("Bike is already locked");
            }
        }

        public void UnlockBike()
        {
            if (locked == true)
            {
                locked = false;
            }
            else
            {
                Console.WriteLine("Bike is already unlocked");
            }
        }
    }
}
