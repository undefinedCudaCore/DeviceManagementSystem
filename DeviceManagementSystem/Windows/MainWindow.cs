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
                        deviceService.ExecuteAddNewDevice();
                        break;
                    case "2":
                        deviceService.ExecuteListOfAllDevices();
                        break;
                    case "3":
                        deviceService.ExecuteSearchForADeviceByModelName();
                        break;
                    case "4":
                        deviceService.DeleteADeviceBySerialNumber();
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
