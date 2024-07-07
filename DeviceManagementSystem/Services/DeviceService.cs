using DeviceManagementSystem.Data;
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

        public Device GetDeviceByModelName(string model)
        {
            try
            {
                var device = _deviceRepository.GetDeviceByModel(model);

                if (device == null)
                {
                    showContent.PrintContent(DataContent.ErrorData.SomethingWrong);
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
    }
}
