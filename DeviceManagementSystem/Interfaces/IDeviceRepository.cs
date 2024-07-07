using DeviceManagementSystem.Models;

namespace DeviceManagementSystem.Interfaces
{
    public interface IDeviceRepository
    {
        internal List<Device> GetAllDevices();
        internal Device GetDeviceByModel(string deviceModel);
        internal void AddNewDevice(int serialNumber, string model, string manufacturer, DateTime manufacturerDate);
        internal void DeleteDeviceById(long deviceId);
    }
}
