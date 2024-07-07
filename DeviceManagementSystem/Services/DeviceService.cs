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

        public Device GetDeviceByModelName(string model)
        {
            try
            {
                var device = _deviceRepository.GetDeviceByModel(model);

                if (device == null)
                {
                    _showContent.PrintContent(DataContent.ErrorData.SomethingWrong);
                    _showContent.PrintContent(DataContent.ErrorData.RedirectToMainMenu);
                    Thread.Sleep(1000);
                    Redirects.RedirectTo.MainMenu();
                }

                if (device.Model == model)
                {
                    return device;
                }
                else
                {
                    return new Device()
                    {
                        DeviceId = 0,
                        Model = "Empty..",
                        Manufacturer = "Empty..",
                        ManufactureDate = DateTime.Now,
                    };
                }
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
    }
}
