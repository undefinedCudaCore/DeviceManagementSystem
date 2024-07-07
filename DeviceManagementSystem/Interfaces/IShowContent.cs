using DeviceManagementSystem.Models;

namespace DeviceManagementSystem.Interfaces
{
    public interface IShowContent
    {
        public void ShowMainMenu();
        public void ShowAllDevices(List<Device> devices);
        public void ShowDevice(Device device);
        public void PrintContent(string content, int id);
        public void PrintContent(string content);
    }
}
