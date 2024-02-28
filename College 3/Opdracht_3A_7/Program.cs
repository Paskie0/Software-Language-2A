namespace Opdracht_3A_7
{
    class Program
    {
        static string[] music =
        [
            "Lady Gaga - Shallow",
            "Drake - Memories",
            "Shawn Mendes - Blinding Lights",
            "Maroon 5 - Memories",
            "Adele - Shallow",
            "Lady Gaga - Yellow",
            "The Weeknd - Leave the Door Open",
            "Imagine Dragons - Positions",
            "Adele - Positions",
            "The Weeknd - Someone Like You",
            "Adele - Positions",
            "Coldplay - Memories",
            "Dua Lipa - Good 4 U",
            "Billie Eilish - Blinding Lights",
            "Drake - Leave the Door Open"
        ];

        public static List<string> playlist = new(music);
        static void Main()
        {
            Console.WriteLine("Your playlist:");

            for (int i = 0; i < playlist.Count; i++)
            {
                Console.WriteLine($"{i + 1} {playlist[i]}");
            }

            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1: Add Song");
            Console.WriteLine("2: Move Song");
            Console.WriteLine("3: Remove Song");

            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Console.WriteLine("What is the name of the artist?");

                    string artist = Console.ReadLine()!;

                    Console.WriteLine("And what's the song called?");

                    string songName = Console.ReadLine()!;

                    string song = $"{artist} - {songName}";

                    playlist.Add(song);

                    Console.WriteLine("Song added!");

                    break;

                case 2:
                    Console.WriteLine("Select the song you'd like to move:");

                    int songToMove = Convert.ToInt32(Console.ReadLine()) - 1;

                    Console.WriteLine($"You selected {playlist[songToMove]}");
                    Console.WriteLine("Where would you like to move this song to?");

                    int position = Convert.ToInt32(Console.ReadLine()) - 1;

                    string tempSong = playlist[songToMove];
                    playlist.RemoveAt(songToMove);
                    playlist.Insert(position, tempSong);

                    break;

                case 3:
                    Console.WriteLine("Select the song you'd like to remove");

                    int songToDelete = Convert.ToInt32(Console.ReadLine()) - 1;

                    playlist.RemoveAt(songToDelete);

                    break;

                default:
                    break;
            }

            for (int i = 0; i < playlist.Count; i++)
            {
                Console.WriteLine($"{i + 1} {playlist[i]}");
            }
        }
    }
}
