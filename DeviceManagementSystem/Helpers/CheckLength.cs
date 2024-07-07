using DeviceManagementSystem.Data;
using DeviceManagementSystem.Interfaces;
using DeviceManagementSystem.Redirects;
using DeviceManagementSystem.Services;

namespace DeviceManagementSystem.Helpers
{
    internal static class CheckLength
    {
        public static void InputLenthNotLongerEleven(string input)
        {
            IShowContent showContent = new ShowContentService();

            if (input.Length > 7)
            {
                showContent.PrintContent(DataContent.ErrorData.InputTooLong11);
                showContent.PrintContent(DataContent.ErrorData.RedirectToMainMenu);
                Thread.Sleep(3000);
                RedirectTo.MainMenu();
            }
        }

        public static void InputLenthNotLongerOneHundred(string input)
        {
            IShowContent showContent = new ShowContentService();

            if (input.Length > 100)
            {
                showContent.PrintContent(DataContent.ErrorData.InputTooLong100);
                showContent.PrintContent(DataContent.ErrorData.RedirectToMainMenu);
                Thread.Sleep(3000);
                RedirectTo.MainMenu();
            }
        }

        public static void InputLenthNotLongerOneHundredFifty(string input)
        {
            IShowContent showContent = new ShowContentService();

            if (input.Length > 150)
            {
                showContent.PrintContent(DataContent.ErrorData.InputTooLong150);
                showContent.PrintContent(DataContent.ErrorData.RedirectToMainMenu);
                Thread.Sleep(3000);
                RedirectTo.MainMenu();
            }
        }
    }
}
