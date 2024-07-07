using DeviceManagementSystem.Data;
using DeviceManagementSystem.Database;
using DeviceManagementSystem.Helpers;
using DeviceManagementSystem.Interfaces;
using DeviceManagementSystem.Models;

namespace DeviceManagementSystem.Repositories
{
    internal class DeviceRepository : IDeviceRepository
    {
        public List<Device> GetAllDevices()
        {
            try
            {
                using (DeviceContext db = new DeviceContext())
                {
                    db.Database.EnsureCreated();
                    return db.Devices.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Exception in: ${DataContent.ExeptionData.GetAllDevicesException} {ex.Message}");
            }
        }

        public List<Device> GetDeviceByModel(string deviceModel)
        {
            try
            {
                using (DeviceContext db = new DeviceContext())
                {
                    db.Database.EnsureCreated();
                    return db.Devices.Where(d => d.Model == deviceModel).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Exception in: ${DataContent.ExeptionData.GetDeviceByModelException} {ex.Message}");
            }
        }

        public Device GetDeviceBySerialNumber(int serialNumber)
        {
            try
            {
                using (DeviceContext db = new DeviceContext())
                {
                    db.Database.EnsureCreated();
                    return db.Devices.FirstOrDefault(d => d.UniqueSerialNumber == serialNumber);
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Exception in: ${DataContent.ExeptionData.GetDeviceBySerialNumberException} {ex.Message}");
            }
        }

        public void AddNewDevice(int serialNumber, string model, string manufacturer, DateTime manufacturerDate)
        {
            try
            {
                using (DeviceContext db = new DeviceContext())
                {
                    db.Database.EnsureCreated();
                    var newDevice = new Device
                    {
                        Model = model,
                        Manufacturer = manufacturer,
                        ManufactureDate = manufacturerDate,
                        Date = DateTime.Now,
                        UniqueSerialNumber = serialNumber,
                    };
                    db.Devices.Add(newDevice);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Exception in: ${DataContent.ExeptionData.AddNewDeviceException} {ex.Message}");
            }
        }

        public void DeleteDeviceBySerialNumber(int serialNumber)
        {
            try
            {
                using (DeviceContext db = new DeviceContext())
                {
                    db.Database.EnsureCreated();
                    var deviceToDelete = db.Devices.FirstOrDefault(d => d.UniqueSerialNumber == serialNumber);
                    if (deviceToDelete != null)
                    {
                        db.Devices.Remove(deviceToDelete);
                        db.SaveChanges();
                    }
                    else
                    {
                        ColorHelper.RedColorTextEnter(DataContent.ErrorData.DeviceNotFound);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Exception in: ${DataContent.ExeptionData.DeleteDeviceBySerialNrException} {ex.Message}");
            }
        }
    }
}
