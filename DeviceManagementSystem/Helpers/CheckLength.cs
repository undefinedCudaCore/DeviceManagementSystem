using DeviceManagementSystem.Data;
using DeviceManagementSystem.Interfaces;
using DeviceManagementSystem.Redirects;
using DeviceManagementSystem.Services;

namespace DeviceManagementSystem.Helpers
{
    internal static class CheckLength
    {
        public static void InputLenthNotLongerOneHundred(string input)
        {
            IShowContent showContent = new ShowContentService();

            if (input.Length > 100)
            {
                showContent.PrintContent(DataContent.ErrorData.InputTooLong100);
                showContent.PrintContent(DataContent.ErrorData.RedirectToMainMenu);
                Thread.Sleep(1000);
                RedirectTo.MainMenu();
            }
        }
        public static void InputLenthNotLongerOneHundredFifty(string input)
        {
            IShowContent showContent = new ShowContentService();

            if (input.Length > 150)
            {
                showContent.PrintContent(DataContent.ErrorData.InputTooLong100);
                showContent.PrintContent(DataContent.ErrorData.RedirectToMainMenu);
                Thread.Sleep(1000);
                RedirectTo.MainMenu();
            }
        }
    }
}
