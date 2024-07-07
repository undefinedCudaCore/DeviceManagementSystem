using DeviceManagementSystem.Data;
using DeviceManagementSystem.Interfaces;

namespace DeviceManagementSystem.Services
{
    public class ShowContentService : IShowContent
    {
        public void ShowMainMenu()
        {
            Console.Clear();

            Console.WriteLine($"Please select action ({DataContent.ErrorData.EnterSelection}):");
            Console.WriteLine("1. Add new devices.");
            Console.WriteLine("2. List all devices.");
            Console.WriteLine("3. Search for a device by model.");
            Console.WriteLine("4. Delete a device by serial number.");
            Console.WriteLine("5. Type 'QUIT' to close process.");
            Console.WriteLine("6. Type 'EXIT' to exit process.");
        }
    }
}
