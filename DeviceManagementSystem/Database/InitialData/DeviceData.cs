using DeviceManagementSystem.Models;

namespace DeviceManagementSystem.Database.InitialData
{
    internal static class DeviceData

    {
        public static Device[] DataSeed => new Device[] {
            new Device
            {
                DeviceId = 1,
                Model = "Nothing Phone (2)",
                Manufacturer = "Nothing Technology Limited",
                ManufactureDate = new DateTime(2023, 6, 10),
                Date = DateTime.Now,
            },
            new Device
            {
                DeviceId = 2,
                Model = "Oneplus 10 Pro",
                Manufacturer = "OnePlus Technology Co., Ltd.",
                ManufactureDate = new DateTime(2022, 5, 14),
                Date = DateTime.Now,
            },
            new Device
            {
                DeviceId = 3,
                Model = "Apple iPhone 15",
                Manufacturer = "Apple Inc.",
                ManufactureDate = new DateTime(2024, 1, 15),
                Date = DateTime.Now,
            },
            new Device
            {
                DeviceId = 4,
                Model = "Samsung Galaxy S24 Ultra",
                Manufacturer = "Samsung Electronics Co., Ltd.",
                ManufactureDate = new DateTime(2024, 10, 26),
                Date = DateTime.Now,
            },
        };
    }
}
