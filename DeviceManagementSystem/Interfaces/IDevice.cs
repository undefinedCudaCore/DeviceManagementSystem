using DeviceManagementSystem.Models;

namespace DeviceManagementSystem.Interfaces
{
    public interface IDevice
    {
        internal List<Device> GetAllDevices();
        public Device GetDeviceByModelName(string model);
        public void AddNewDevice(int serialNumber, string model, string manufacturer, DateTime manufacturerDate);
        public void RemoveDevice(int serialNumber);
    }
}
