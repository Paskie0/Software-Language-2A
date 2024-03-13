namespace Opdracht_3B_2
{
    class Program
    {
        static void Main()
        {
            Bycicle bike1 = new()
            {
                lockType = Bycicle.Lock.ABUS,
                color = Bycicle.Color.Black,
                type = Bycicle.Type.Electric,
                frameHeight = 50,
                Range = 65,
                locked = false
            };

            Bycicle bike2 = new()
            {
                lockType = Bycicle.Lock.CRC,
                color = Bycicle.Color.Blue,
                type = Bycicle.Type.Standard,
                frameHeight = 61,
                locked = true
            };

            Bycicle bike3 = new()
            {
                lockType = Bycicle.Lock.AXA,
                color = Bycicle.Color.White,
                type = Bycicle.Type.Electric,
                frameHeight = 43,
                Range = 110,
                locked = false,
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

        public enum Type
        {
            Standard,
            Electric
        }

        public enum RangeType
        {
            mile,
            kilometer
        }

        public Lock lockType;

        public Color color;

        public Type type;

        public RangeType rangeType;

        public int frameHeight;

        private int range;

        public int Range
        {
            get { return range; }
            set
            {
                if (value > 200)
                {
                    range = 200;
                }
                else
                {
                    range = value;
                }

                if (rangeType == RangeType.mile)
                {
                    range = (int)(range * 1.609344);
                }
            }
        }

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
