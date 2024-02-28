﻿namespace Opdracht_3A_4
{
    class Program
    {
        static string[] orders =
            [
            "3x Frietje, 2x Frikandel, 1x Cola",
            "1x Frietje Speciaal, 2x Kroket, 1x Water, 3x Kaassoufflé",
            "2x Frietje, 1x Frikandel Speciaal, 2x Bier",
            "4x Kaassoufflé, 2x Cola",
            "2x Frietje Oorlog, 1x Frikandel, 1x Milkshake",
            "3x Kroket, 2x Frikandel, 1x Cola, 1x Frietje",
            "1x Frietje, 3x Bitterballen, 2x Limoen",
            "2x Frietje Speciaal, 1x Frikandel, 2x Kroket",
            "4x Frikandel, 1x Frietje Groot",
            "3x Frietje, 2x Kaassoufflé, 1x Milkshake Vanille",
            "2x Kroket, 1x Frikandel Speciaal, 2x Water",
            "1x Frietje Oorlog, 2x Cola, 3x Frikandel",
            "2x Frietje, 1x Bier, 3x Bitterballen",
            "1x Frietje Groot, 2x Frikandel Speciaal, 1x Cola",
            "3x Kroket, 2x Frietje Speciaal, 1x Water"
            ];

        static List<string> ordersList = new(orders);

        static void Main()
        {
            for (int i = 0; i < ordersList.Count; i++)
            {
                Console.WriteLine($"Bestel Nr. {i + 1}\n{ordersList[i]}\n");
            }
        }
    }
}
