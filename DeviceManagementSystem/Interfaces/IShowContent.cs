namespace DeviceManagementSystem.Interfaces
{
    public interface IShowContent
    {
        public void ShowMainMenu();
        public void ShowAllDevices();
        public void PrintContent(string content, int id);
        public void PrintContent(string content);
    }
}
