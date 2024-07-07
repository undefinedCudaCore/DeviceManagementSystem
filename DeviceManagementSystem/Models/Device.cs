namespace DeviceManagementSystem.Models
{
    internal class Device
    {
        public Device(int deviceId, string model, string manufacturer, DateTime manufacturDate, DateTime date)
        {
            DeviceId = deviceId;
            Model = model;
            Manufacturer = manufacturer;
            ManufacturDate = manufacturDate;
            Date = date;
        }

        public Device()
        {
        }

        public long DeviceId { get; set; }
        public string Model { get; set; }
        public string Manufacturer { get; set; }
        public DateTime ManufacturDate { get; set; }
        public DateTime Date { get; set; }
    }
}
