using DeviceManagementSystem.Models;

namespace DeviceManagementSystem.Interfaces
{
    public interface IDevice
    {
        internal List<Device> GetAllDevices();
    }
}
