﻿using DeviceManagementSystem.Data;
using DeviceManagementSystem.Interfaces;
using DeviceManagementSystem.Models;

namespace DeviceManagementSystem.Services
{
    public class ShowContentService : IShowContent
    {
        private IDevice _deviceService = new DeviceService();

        public void ShowMainMenu()
        {
            Console.Clear();

            Console.WriteLine($"Please select action ({DataContent.BasicData.EnterSelection}):");
            Console.WriteLine("1. Add new devices.");
            Console.WriteLine("2. List all devices.");
            Console.WriteLine("3. Search for a device by model.");
            Console.WriteLine("4. Delete a device by serial number.");
            Console.WriteLine("5. Type 'QUIT' to close process.");
            Console.WriteLine("6. Type 'EXIT' to exit process.");
        }

        public void PrintContent(string content)
        {
            Console.WriteLine(content);
        }

        public void PrintContent(string content, int id)
        {
            Console.WriteLine(content + id);
        }

        public void ShowAllDevices(List<Device> devices)
        {
            Console.Clear();
            PrintContent(DataContent.BasicData.ListOfDevices);

            devices
                .ForEach(d =>

                Console.WriteLine($"{DataContent.BasicData.Margin}\n" +
                $"Device: {d.DeviceId} - {d.Model} ({d.Manufacturer});\n " +
                $"Manufacture date: {d.ManufactureDate.ToString("yyyy-MM-dd")};\n " +
                $"Date the device was added to list: {d.Date.ToString("yyyy-MM-dd")}."));

            PrintContent(DataContent.BasicData.Margin);
            PrintContent(DataContent.BasicData.PressKeyToReturnToMainMenu);
            Console.ReadKey();
        }

        public void ShowDevice(Device device)
        {
            Console.Clear();
            PrintContent(DataContent.BasicData.ListOfDevices);

            Console.WriteLine($"{DataContent.BasicData.Margin}\n" +
            $"Device: {device.DeviceId} - {device.Model} ({device.Manufacturer});\n " +
            $"Manufacture date: {device.ManufactureDate.ToString("yyyy-MM-dd")};\n " +
            $"Date the device was added to list: {device.Date.ToString("yyyy-MM-dd")}.");

            PrintContent(DataContent.BasicData.Margin);
            PrintContent(DataContent.BasicData.PressKeyToReturnToMainMenu);
            Console.ReadKey();
        }
    }
}
