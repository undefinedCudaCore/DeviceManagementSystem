namespace DeviceManagementSystem.Models
{
    internal class Device
    {
        internal int DeviceId { get; set; }
        public string Model { get; set; }
        public string Manufacturer { get; set; }
        public DateTime ManufacturDate { get; set; }
        public DateTime Date { get; set; }
    }
}
