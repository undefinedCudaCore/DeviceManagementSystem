namespace DeviceManagementSystem.Data
{
    internal static class DataContent
    {
        internal static class TypeInData
        {
            internal static readonly string EnterSelection = "Type your selection and press ENTER:";
            internal static readonly string EnterDeviceModel = "Type device model and press ENTER:";
            internal static readonly string EnterDeviceId = "Type device ID and press ENTER:";
        }
        internal static class ErrorData
        {
            internal static readonly string WrongInput = "Wrong user input.";
            internal static readonly string RedirectToMainMenu = "Redirecting to the main menu.";
            internal static readonly string PressKeyToReturnToMainMenu = "Press any key to return to the main menu.";
            internal static readonly string DeviceAlredyExists = "You can't create a new device, device already exists.";
            internal static readonly string InputTooLong100 = "You can't create a new record, input have more than 100 symbols.";
            internal static readonly string InputTooLong150 = "You can't create a new record, input have more than 150 symbols.";
            internal static readonly string DeviceNotFound = "Device Not Found";
        }

        internal static class ExeptionData
        {
            internal static readonly string GetAllDevicesException = "Get All Devices:";
            internal static readonly string GetDeviceByModelException = "Get Device By Id:";
            internal static readonly string AddNewDeviceException = "Add New Device:";
            internal static readonly string DeleteDeviceByIdException = "Delete Device By Id:";
        }
    }
}
