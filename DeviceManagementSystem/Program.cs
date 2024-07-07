using DeviceManagementSystem.Database;
using DeviceManagementSystem.Services;
using DeviceManagementSystem.Services.Interfaces;

namespace DeviceManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var db = new DeviceContext())
            {
                db.Database.EnsureCreated();

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
}
