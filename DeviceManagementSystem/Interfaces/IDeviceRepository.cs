using DeviceManagementSystem.Models;

namespace DeviceManagementSystem.Interfaces
{
    public interface IDeviceRepository
    {
        internal List<Device> GetAllDevices();
        internal Device GetDeviceByModel(string deviceModel);
        internal void AddNewDevice(int serialNumber, string model, string manufacturer, DateTime manufacturerDate);
        public void DeleteDeviceBySerialNumber(int serialNumber);
        public Device GetDeviceBySerialNumber(int serialNumber);
    }
}
