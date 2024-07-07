using DeviceManagementSystem.Models;

namespace DeviceManagementSystem.Interfaces
{
    public interface IDevice
    {
        internal List<Device> GetAllDevices();
        public List<Device> GetDeviceByModelName(string model);
        public void AddNewDevice(int serialNumber, string model, string manufacturer, DateTime manufacturerDate);
        public void RemoveDevice(int serialNumber);
        public void ExecuteAddNewDevice();
        public void ExecuteListOfAllDevices();
        public void ExecuteSearchForADeviceByModelName();
        public void DeleteADeviceBySerialNumber();
    }
}
