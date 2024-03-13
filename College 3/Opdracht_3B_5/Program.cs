namespace Opdracht_3B_5
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(ConfigurationData.ApplicationName);
            Console.WriteLine(ConfigurationData.Version);
            Console.WriteLine(ConfigurationData.MaxUsers);
        }
    }

    public static class ConfigurationData
    {
        const string applicationName = "Google";
        public static string ApplicationName { get { return applicationName; } }
        const string version = "1.87.2";
        public static string Version { get { return version; } }
        const int maxUsers = 9999;
        public static int MaxUsers { get { return maxUsers; } }
    }
}