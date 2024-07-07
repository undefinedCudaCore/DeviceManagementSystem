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
        private IShowContent _showContent = new ShowContentService();

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
                    _showContent.PrintContent(DataContent.ErrorData.SomethingWrong);
                    _showContent.PrintContent(DataContent.ErrorData.RedirectToMainMenu);
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
                    _showContent.PrintContent(DataContent.ErrorData.SomethingWrong);
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
    }
}
