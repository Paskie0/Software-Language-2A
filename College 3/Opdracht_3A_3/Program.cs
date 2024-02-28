namespace Opdracht_3A_3
{
    class Program
    {
        static Stack<char> content = [];
        static Stack<char> redo = [];

        static void Main()
        {
            Console.WriteLine("Type something...");

            while (true)
            {
                var key = Console.ReadKey(true);

                switch (key.Key)
                {
                    case ConsoleKey.Backspace:
                        if (content.Count > 0)
                        {
                            redo.Push(content.Pop());
                        }
                        break;

                    case ConsoleKey.Enter:
                        break;

                    case ConsoleKey.Z:
                        if (key.Modifiers == ConsoleModifiers.Control)
                        {
                            if (content.Count > 0)
                            {
                                redo.Push(content.Pop());
                            }
                        }
                        break;

                    case ConsoleKey.Y:
                        if (key.Modifiers == ConsoleModifiers.Control)
                        {
                            if (redo.Count > 0)
                            {
                                content.Push(redo.Pop());
                            }
                        }
                        break;

                    default:
                        if (char.IsAscii(key.KeyChar))
                        {
                            content.Push(key.KeyChar);
                            redo.Clear();
                        }
                        break;
                }

                Console.Clear();

                foreach (char c in content.Reverse())
                {
                    Console.Write(c);
                }
            }
        }
    }

}



