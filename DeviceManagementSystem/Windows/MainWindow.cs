using DeviceManagementSystem.Data;
using DeviceManagementSystem.Helpers;
using DeviceManagementSystem.Interfaces;
using DeviceManagementSystem.Services;

namespace DeviceManagementSystem.Windows
{
    internal static class MainWindow
    {
        internal static void OutsetProgram()
        {
            bool cycle = true;

            while (cycle)
            {
                IShowContent showContent = new ShowContentService();
                IDevice deviceService = new DeviceService();

                showContent.ShowMainMenu();

                string option = Console.ReadLine().ToLower();

                switch (option)
                {
                    case "1":
                        Console.Clear();



                        break;
                    case "2":
                        showContent.ShowAllDevices(deviceService.GetAllDevices());
                        break;
                    case "3":
                        Console.Clear();

                        showContent.PrintContent(DataContent.BasicData.EnterDeviceModel);
                        showContent.PrintContent(DataContent.BasicData.Margin);
                        CheckInputHelper.CheckInput(out string input);

                        showContent.ShowDevice(deviceService.GetDeviceByModelName(input));
                        break;
                    case "4":
                        Console.WriteLine("Delete a device by serial number");
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
