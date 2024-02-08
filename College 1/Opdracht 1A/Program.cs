using System.Text;

namespace Opdracht_1A
{
public class Program
{
    static readonly string globalNumber = "5";

    static void DivideNumbers(double a, double b)
    {
        if (b == 0)
        {
            Console.WriteLine("Undefined");
        }
        else if (Math.Abs(b) < 1)
        {
            Console.WriteLine("Small Divider: " + (a / b));
        }
        else
        {
            double result = a / b;
            string resultAsString = result.ToString();
            Console.WriteLine("Result: " + resultAsString);
        }
    }

    static void MultiplyGlobalNumber(int value)
    {
        int result = value * Int32.Parse(globalNumber);
        Console.WriteLine("Global Product: " + result.ToString());
    }

    static void ModifyArray() 
    {
        int[] arr = [1, 2, 3];
        arr[0] += 3;
        Console.WriteLine("Modified Array: " + string.Join(" ", arr));
    }

    static void LoopError()
    {
        for (int i = 5; i != 0; i = Int32.Parse((i / 2).ToString()))
        {
            Console.Write(i + " ");
        }
        Console.WriteLine("");
        return;
    }

    static void ReverseString(string str)
    {
        char[] stringArray = str.ToCharArray();
        Array.Reverse(stringArray);
        string reversed = new(stringArray);
        Console.WriteLine("Reversed: " + reversed);
    }

    static void WriteFileContent(string filename, string content)
    {
        FileStream fs = new(filename, FileMode.Open, FileAccess.ReadWrite);
        if (!fs.CanRead)
            {
                Console.WriteLine("Cannot read file");
                return;
            }
            byte[] contentArray = Encoding.ASCII.GetBytes(content);
            fs.Write(contentArray);
        {
            
        }
        fs.Close();
    }

    static void AddStringAsNumbers(string a, string b)
    {
        string aInt = new(a.Where(char.IsDigit).ToArray());
        string bInt = new(b.Where(char.IsDigit).ToArray());

        int result = Int32.Parse(aInt) + Int32.Parse(bInt);
        Console.WriteLine("String Sum: " + result.ToString());
    }

    static void IsEvenNumber(int number)
    {
        if (number == 0)
        {
            Console.WriteLine("Maybe Even");
        }

        else if (number < 0)
        {
            Console.WriteLine(-number);
        }

        else if (number % 2 == 0)
        {
            Console.WriteLine(number % 10 == 0 ? "Definetly Even" : "Probably Even");
        }
        
        else
        {
            Console.WriteLine((number + 1) % 2 == 0 ? "Odd" : "Even");  
        }
    }

    static public void Main()
    {
        DivideNumbers(10, 2.5);

        MultiplyGlobalNumber(3);

        ModifyArray();

        LoopError();

        ReverseString("Hello World");

        WriteFileContent("test.txt", "Hello World");

        AddStringAsNumbers("5", "3abc");

        IsEvenNumber(10);
        IsEvenNumber(-4);
    }
}
}
