namespace Opdracht_3A_2
{
    class Program
    {
        static readonly string[,] testData = new string[15, 2]
        {
            {"Abstractie", "Het proces van het weglaten van minder essentiële informatie zodat alleen de meest essentiële kenmerken overblijven."},
            {"Algoritme", "Een stapsgewijze procedure voor het uitvoeren van een taak of het berekenen van een waarde."},
            {"Array", "Een geordende verzameling elementen, typisch van hetzelfde type."},
            {"Class", "Een blauwdruk voor een object in objectgeoriënteerd programmeren."},
            {"Encapsulatie", "Een objectgeoriënteerd programmeerprincipe waarbij de interne staat van een object verborgen wordt."},
            {"Erfenis", "Het vermogen van een nieuwe klasse om de eigenschappen en methoden van een andere klasse over te nemen."},
            {"Framework", "Een set van codebibliotheken en tools die helpen bij het ontwikkelen van software."},
            {"Interface", "Een contract in OOP dat definieert welke methodes een klasse moet implementeren."},
            {"Iteratie", "Het herhaaldelijk uitvoeren van een set instructies totdat een bepaalde voorwaarde is voldaan."},
            {"Namespace", "Een container die wordt gebruikt om sets van andere benoemde entiteiten onder een unieke naam te groeperen."},
            {"Polymorfisme", "Het vermogen van verschillende klassen om te reageren op dezelfde boodschap op verschillende manieren."},
            {"Recursie", "Een techniek in programmeren waar een functie zichzelf oproept."},
            {"Serialize", "Het proces van omzetten van een object naar een formaat dat kan worden opgeslagen of overgedragen."},
            {"Syntax", "De set regels die definiëren hoe instructies in een programmeertaal zijn opgebouwd."},
            {"Variable", "Een opslaglocatie met een geassocieerde naam en een waarde die kan veranderen tijdens de uitvoering van een programma."}
        };

        static void Main()
        {
            Dictionary<string, string> encyclopedia = [];

            for (int i = 0; i < testData.GetLength(0); i++)
            {
                encyclopedia.Add(testData[i, 0], testData[i, 1]);
            }

            Console.WriteLine("Enter a term to look up in the encyclopedia");
            string input = Console.ReadLine()!;
            if (encyclopedia.ContainsKey(input))
            {
                Console.WriteLine(encyclopedia[input]);
            }
            else
            {
                Console.WriteLine("Term not found");
            }
        }
    }
}
