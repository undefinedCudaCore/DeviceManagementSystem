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
                        try
                        {
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

                            deviceService.AddNewDevice(serialNumber, model.ToUpper(), manufacturer, parsedManufactureDateDate);
                        }
                        catch (FormatException)
                        {
                            showContent.PrintContent(DataContent.ErrorData.SomethingWrong);
                            showContent.PrintContent(DataContent.BasicData.ManufactureDateSample);
                            showContent.PrintContent(DataContent.ErrorData.RedirectToMainMenu);
                            Thread.Sleep(3000);
                            Redirects.RedirectTo.MainMenu();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("aaanbv");
                        }

                        break;
                    case "2":
                        showContent.ShowAllDevices(deviceService.GetAllDevices());
                        break;
                    case "3":
                        Console.Clear();

                        showContent.PrintContent(DataContent.BasicData.EnterDeviceModel);
                        showContent.PrintContent(DataContent.BasicData.Margin);
                        CheckInputHelper.CheckInput(out string input);

                        showContent.ShowAllDevices(deviceService.GetDeviceByModelName(input.ToUpper()));
                        break;
                    case "4":
                        Console.Clear();

                        showContent.PrintContent(DataContent.BasicData.RemoveDevice);
                        showContent.PrintContent(DataContent.BasicData.EnterDeviceSerialNumber);
                        showContent.PrintContent(DataContent.BasicData.Margin);

                        CheckInputHelper.CheckInput(out int serialNumberToRemove);
                        CheckLength.InputLenthNotLongerEleven(serialNumberToRemove.ToString());

                        deviceService.RemoveDevice(serialNumberToRemove);
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
