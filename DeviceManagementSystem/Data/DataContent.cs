namespace DeviceManagementSystem.Data
{
    internal static class DataContent
    {
        internal static class ErrorData
        {
            internal static readonly string WrongInput = "Wrong user input.";
            internal static readonly string RedirectToMainMenu = "Redirecting to the main menu.";
            internal static readonly string PressKeyToReturnToMainMenu = "Press any key to return to the main menu.";
            internal static readonly string EnterSelection = "Type your selection and press ENTER:";
            internal static readonly string EnterDepartmentId = "Type department ID and press ENTER:";
            internal static readonly string EnterDeviceId = "Type device ID and press ENTER:";
            internal static readonly string DeviceAlredyExists = "You can't create a new device, device already exists.";
            internal static readonly string InputTooLong = "You can't create a new record, input have more than 50 symbols.";
        }
    }
}
