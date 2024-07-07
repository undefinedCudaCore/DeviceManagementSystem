namespace DeviceManagementSystem.Data
{
    internal static class DataContent
    {
        internal static class BasicData
        {
            internal static readonly string EnterSelection = "Type your selection and press ENTER:";
            internal static readonly string EnterDeviceSerialNumber = "Type device serial number (numbers only) and press ENTER:";
            internal static readonly string EnterDeviceModel = "Type device model and press ENTER:";
            internal static readonly string EnterDeviceManufacturer = "Type device manufacturer and press ENTER:";
            internal static readonly string EnterDeviceManufactureDate = "Type device manufacture date and press ENTER:";
            internal static readonly string EnterDeviceId = "Type device ID and press ENTER:";
            internal static readonly string PressKeyToReturnToMainMenu = "Press any key to return to the main menu.";
            internal static readonly string ListOfDevices = "You will find bellow list of all devices in database:";
            internal static readonly string Margin = "---------------------------------------------------------";
            internal static readonly string DeviceSuccAdded = "The device was successfully added to the list.";
            internal static readonly string ManufactureDateSample = "Enter the date as in the example: 2022-12-31";
            internal static readonly string SuccDeletedDevice = "Device Removed Successfully";

            public static string RemoveDevice = "Remove device!";
        }
        internal static class ErrorData
        {
            internal static readonly string WrongInput = "Wrong user input.";
            internal static readonly string RedirectToMainMenu = "Redirecting to the main menu.";
            internal static readonly string DeviceAlredyExists = "You can't create a new device, device already exists.";
            internal static readonly string InputTooLong11 = "You can't create a new record, input have more than 11 symbols.";
            internal static readonly string InputTooLong100 = "You can't create a new record, input have more than 100 symbols.";
            internal static readonly string InputTooLong150 = "You can't create a new record, input have more than 150 symbols.";
            internal static readonly string DeviceNotFound = "Device Not Found";
            internal static readonly string SomethingWrong = "Something went wrong when the program tried to add the device..";
            internal static readonly string WrongSerialNo = "The entered device serial number does not correspond to the serial number in the database.";
        }

        internal static class ExeptionData
        {
            internal static readonly string GetAllDevicesException = "Get All Devices:";
            internal static readonly string GetDeviceByModelException = "Get Device By Id:";
            internal static readonly string GetDeviceBySerialNumberException = "Get Device By serial number:";
            internal static readonly string AddNewDeviceException = "Add New Device:";
            internal static readonly string DeleteDeviceBySerialNrException = "Delete Device By Serial No.:";
        }
    }
}
