using DeviceManagementSystem.Models;

namespace DeviceManagementSystem.Interfaces
{
    public interface IDeviceRepository
    {
        internal List<Device> GetAllDevices();
        internal Device GetDeviceModel(string deviceModel);
        internal void AddNewDevice(long deviceId, string model, string manufacturer, DateTime manufacturerDate);
        internal void DeleteDeviceById(long deviceId);
    }
}
