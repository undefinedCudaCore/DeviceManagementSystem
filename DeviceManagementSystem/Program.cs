using DeviceManagementSystem.Interfaces;
using DeviceManagementSystem.Services;

namespace DeviceManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool cycle = true;

            while (cycle)
            {
                IShowContent showContent = new ShowContentService();
                showContent.ShowMainMenu();

                string option = Console.ReadLine().ToLower();

                switch (option)
                {
                    case "1":

                        break;
                    case "2":

                        break;
                    case "3":

                        break;
                    case "4":

                        break;
                    case "quit":
                        Environment.Exit(0);
                        break;
                    case "exit":
                        Environment.Exit(0);
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
