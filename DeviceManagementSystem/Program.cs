using DeviceManagementSystem.Database;

namespace DeviceManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var db = new DeviceContext())
            {
                db.Database.EnsureCreated();
            }
        }
    }
}
