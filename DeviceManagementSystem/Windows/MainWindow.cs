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

                        showContent.PrintContent(DataContent.BasicData.EnterDeviceSerialNumber);
                        CheckInputHelper.CheckInput(out int serialNumber);
                        CheckLength.InputLenthNotLongerEleven(serialNumber.ToString());

                        showContent.PrintContent(DataContent.BasicData.EnterDeviceModel);
                        CheckInputHelper.CheckInput(out string model);
                        CheckLength.InputLenthNotLongerOneHundred(model);

                        showContent.PrintContent(DataContent.BasicData.EnterDeviceManufacturer);
                        CheckInputHelper.CheckInput(out string manufacturer);
                        CheckLength.InputLenthNotLongerOneHundredFifty(manufacturer);

                        showContent.PrintContent(DataContent.BasicData.EnterDeviceManufactureDate);
                        showContent.PrintContent(DataContent.BasicData.ManufactureDateSample);
                        CheckInputHelper.CheckInput(out string manufactureDate);

                        var parsedManufactureDateDate = DateTime.Parse(manufactureDate);

                        deviceService.AddNewDevice(serialNumber, model, manufacturer, parsedManufactureDateDate);

                        break;
                    case "2":
                        showContent.ShowAllDevices(deviceService.GetAllDevices());
                        break;
                    case "3":
                        Console.Clear();

                        showContent.PrintContent(DataContent.BasicData.EnterDeviceModel);
                        showContent.PrintContent(DataContent.BasicData.Margin);
                        CheckInputHelper.CheckInput(out string input);

                        showContent.ShowDevice(deviceService.GetDeviceByModelName(input.ToUpper()));
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
