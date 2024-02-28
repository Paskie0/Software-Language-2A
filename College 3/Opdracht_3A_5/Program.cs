namespace Opdracht_3A_5
{
    class Program
    {
        static string[] discountCodes = new string[]
        {
            "P5CQV", "MVFHC", "P1WVX",
            "H15QA", "CKWX2", "B45SO",
            "1VRFH", "KSVQO", "WH83H",
            "AOZMT", "DSTCH", "VQ1H6",
            "C03GB", "1N9YM", "8W7F8"
        };

        static Dictionary<string, bool> couponCodes = [];

        static void Main()
        {
            for (int i = 0; i < discountCodes.Length; i++)
            {
                couponCodes.Add(discountCodes[i], false);
            }

            Console.WriteLine("Enter your coupon code:");

            validCoupon();

            Console.WriteLine("Wanna try another one?");

            validCoupon();
        }

        static void validCoupon()
        {
            string input = Console.ReadLine()!;

            if (couponCodes.ContainsKey(input) && couponCodes[input] == false)
            {
                couponCodes[input] = true;
                Console.WriteLine("Coupon code applied succesfully");
            }

            else
            {
                Console.WriteLine("Coupon has already been used");
            }
        }
    }
}
