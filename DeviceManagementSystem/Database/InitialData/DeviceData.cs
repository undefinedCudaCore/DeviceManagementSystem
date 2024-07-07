using DeviceManagementSystem.Models;

namespace DeviceManagementSystem.Database.InitialData
{
    internal static class DeviceData

    {
        public static Device[] DataSeed => new Device[] {
            new Device
            {
                DeviceId = 1,
                Model = "PHONE (2)",
                Manufacturer = "Nothing",
                ManufactureDate = new DateTime(2023, 6, 10),
                Date = DateTime.Now,
            },
            new Device
            {
                DeviceId = 2,
                Model = "10 PRO",
                Manufacturer = "OnePlus",
                ManufactureDate = new DateTime(2022, 5, 14),
                Date = DateTime.Now,
            },
            new Device
            {
                DeviceId = 3,
                Model = "IPHONE 15",
                Manufacturer = "Apple",
                ManufactureDate = new DateTime(2024, 1, 15),
                Date = DateTime.Now,
            },
            new Device
            {
                DeviceId = 4,
                Model = "GALAXY S24 ULTRA",
                Manufacturer = "Samsung",
                ManufactureDate = new DateTime(2024, 10, 26),
                Date = DateTime.Now,
            },
        };
    }
}
