namespace DeviceManagementSystem.Models
{
    public class Device
    {
        public Device(int deviceId, string model, string manufacturer, DateTime manufactureDate, DateTime date)
        {
            DeviceId = deviceId;
            Model = model;
            Manufacturer = manufacturer;
            ManufactureDate = manufactureDate;
            Date = date;
        }

        public Device()
        {
        }

        public long DeviceId { get; set; }
        public string Model { get; set; }
        public string Manufacturer { get; set; }
        public DateTime ManufactureDate { get; set; }
        public DateTime Date { get; set; }
    }
}
