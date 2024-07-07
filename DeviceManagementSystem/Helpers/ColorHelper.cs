namespace DeviceManagementSystem.Helpers
{
    internal static class ColorHelper
    {
        public static void PressEnter()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("To Continue Press Enter");
            Console.ResetColor();
            Console.ReadLine();
        }
        public static void GreenColorTextEnter(string text)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(text);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("To Continue Press Enter");
            Console.ResetColor();
            Console.ReadLine();
        }
        public static void RedColorTextEnter(string text)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(text);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("To Continue Press Enter");
            Console.ResetColor();
            Console.ReadLine();
        }
        public static void BlueColorText(string text)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(text);
            Console.ResetColor();
        }
        public static void GreenColorText(string text)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(text);
            Console.ResetColor();
        }
    }
}
