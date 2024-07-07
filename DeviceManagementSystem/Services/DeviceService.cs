using DeviceManagementSystem.Data;
using DeviceManagementSystem.Helpers;
using DeviceManagementSystem.Interfaces;
using DeviceManagementSystem.Models;
using DeviceManagementSystem.Repositories;


namespace DeviceManagementSystem.Services
{
    internal class DeviceService : IDevice
    {
        public DeviceService()
        {
        }

        private IDeviceRepository _deviceRepository = new DeviceRepository();
        private IShowContent showContent = new ShowContentService();

        public List<Device> GetAllDevices()
        {
            try
            {
                return _deviceRepository.GetAllDevices();
            }
            catch (Exception ex)
            {
                throw new Exception($"Exception in: ${DataContent.ExeptionData.GetAllDevicesException} {ex.Message}");
            }
        }

        public List<Device> GetDeviceByModelName(string model)
        {
            try
            {
                var foundedDeviceList = new List<Device>();
                var devices = _deviceRepository.GetDeviceByModel(model);

                if (devices == null)
                {
                    showContent.PrintContent(DataContent.ErrorData.SomethingWrong);
                    showContent.PrintContent(DataContent.ErrorData.RedirectToMainMenu);
                    Thread.Sleep(1000);
                    Redirects.RedirectTo.MainMenu();
                }

                foreach (var device in devices)
                {

                    if (device.Model == model)
                    {
                        foundedDeviceList.Add(device);
                    }
                    else
                    {
                        foundedDeviceList.Add(new Device()
                        {
                            DeviceId = 0,
                            Model = "Empty..",
                            Manufacturer = "Empty..",
                            ManufactureDate = DateTime.Now,
                        });
                    }
                }
                return foundedDeviceList;
            }
            catch (Exception ex)
            {
                throw new Exception($"Exception in: Get Student By Id: {ex.Message}");
            }
        }

        public void AddNewDevice(int serialNumber, string model, string manufacturer, DateTime manufacturerDate)
        {
            try
            {
                var deviceListBeforeAddition = _deviceRepository.GetAllDevices();

                _deviceRepository.AddNewDevice(serialNumber, model, manufacturer, manufacturerDate);

                var deviceListAfterAddition = _deviceRepository.GetAllDevices();

                if (deviceListAfterAddition.Any() && deviceListBeforeAddition.Count < deviceListAfterAddition.Count)
                {
                    ColorHelper.GreenColorTextEnter(DataContent.BasicData.DeviceSuccAdded);
                }
                else
                {
                    showContent.PrintContent(DataContent.ErrorData.SomethingWrong);
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Exception in: {DataContent.ExeptionData.AddNewDeviceException} {ex.Message}");
            }
        }

        private bool CheckBySerialNumberDoesDeviceExists(int serialNumber)
        {
            try
            {
                var device = _deviceRepository.GetDeviceBySerialNumber(serialNumber);
                if (device == null)
                {
                    return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception($"Exception in: {DataContent.ExeptionData.GetDeviceBySerialNumberException} {ex.Message}");
            }
        }

        public void RemoveDevice(int serialNumber)
        {
            try
            {
                if (!CheckBySerialNumberDoesDeviceExists(serialNumber))
                {
                    ColorHelper.RedColorTextEnter(DataContent.ErrorData.WrongSerialNo);
                    return;
                }

                _deviceRepository.DeleteDeviceBySerialNumber(serialNumber);

                if (!CheckBySerialNumberDoesDeviceExists(serialNumber))
                {
                    ColorHelper.GreenColorTextEnter(DataContent.BasicData.SuccDeletedDevice);
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Exception in: {DataContent.ExeptionData.DeleteDeviceBySerialNrException} {ex.Message}");
            }
        }

        public void ExecuteAddNewDevice()
        {
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

                AddNewDevice(serialNumber, model.ToUpper(), manufacturer, parsedManufactureDateDate);
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
        }

        public void ExecuteListOfAllDevices()
        {
            showContent.ShowAllDevices(GetAllDevices());
        }

        public void ExecuteSearchForADeviceByModelName()
        {
            Console.Clear();

            showContent.PrintContent(DataContent.BasicData.EnterDeviceModel);
            showContent.PrintContent(DataContent.BasicData.Margin);
            CheckInputHelper.CheckInput(out string input);

            showContent.ShowAllDevices(GetDeviceByModelName(input.ToUpper()));
        }

        public void DeleteADeviceBySerialNumber()
        {
            Console.Clear();

            showContent.PrintContent(DataContent.BasicData.RemoveDevice);
            showContent.PrintContent(DataContent.BasicData.EnterDeviceSerialNumber);
            showContent.PrintContent(DataContent.BasicData.Margin);

            CheckInputHelper.CheckInput(out int serialNumberToRemove);
            CheckLength.InputLenthNotLongerEleven(serialNumberToRemove.ToString());

            RemoveDevice(serialNumberToRemove);
        }
    }
}
