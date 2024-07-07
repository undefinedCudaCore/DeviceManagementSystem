﻿using DeviceManagementSystem.Data;
using DeviceManagementSystem.Interfaces;
using DeviceManagementSystem.Redirects;
using DeviceManagementSystem.Services;

namespace DeviceManagementSystem.Helpers
{
    internal static class CheckInputHelper
    {
        public static void CheckInput(out long newInput)
        {
            IShowContent showContent = new ShowContentService();
            string input = Console.ReadLine();

            if (String.IsNullOrEmpty(input))
            {
                showContent.PrintContent(DataContent.ErrorData.WrongInput);
                showContent.PrintContent(DataContent.ErrorData.RedirectToMainMenu);
                Thread.Sleep(3000);
                RedirectTo.MainMenu();
            }

            if (String.IsNullOrWhiteSpace(input))
            {
                showContent.PrintContent(DataContent.ErrorData.WrongInput);
                showContent.PrintContent(DataContent.ErrorData.RedirectToMainMenu);
                Thread.Sleep(3000);
                RedirectTo.MainMenu();
            }

            newInput = ConvertInputToLong(input);
        }

        public static void CheckInput(out string newInput)
        {
            IShowContent showContent = new ShowContentService();
            string input = Console.ReadLine();

            if (String.IsNullOrEmpty(input))
            {
                showContent.PrintContent(DataContent.ErrorData.WrongInput);
                showContent.PrintContent(DataContent.ErrorData.RedirectToMainMenu);
                Thread.Sleep(3000);
                RedirectTo.MainMenu();
            }

            if (String.IsNullOrWhiteSpace(input))
            {
                showContent.PrintContent(DataContent.ErrorData.WrongInput);
                showContent.PrintContent(DataContent.ErrorData.RedirectToMainMenu);
                Thread.Sleep(3000);
                RedirectTo.MainMenu();
            }

            newInput = input.Trim();
        }

        public static void CheckInput(out double newInput)
        {
            IShowContent showContent = new ShowContentService();
            string input = Console.ReadLine();

            if (String.IsNullOrEmpty(input))
            {
                showContent.PrintContent(DataContent.ErrorData.WrongInput);
                showContent.PrintContent(DataContent.ErrorData.RedirectToMainMenu);
                Thread.Sleep(3000);
                RedirectTo.MainMenu();
            }

            if (String.IsNullOrWhiteSpace(input))
            {
                showContent.PrintContent(DataContent.ErrorData.WrongInput);
                showContent.PrintContent(DataContent.ErrorData.RedirectToMainMenu);
                Thread.Sleep(3000);
                RedirectTo.MainMenu();
            }

            double.TryParse(input, out newInput);
        }

        public static void CheckInput(string input, out long newInput)
        {
            IShowContent showContent = new ShowContentService();

            if (String.IsNullOrEmpty(input))
            {
                showContent.PrintContent(DataContent.ErrorData.WrongInput);
                showContent.PrintContent(DataContent.ErrorData.RedirectToMainMenu);
                Thread.Sleep(3000);
                RedirectTo.MainMenu();
            }

            if (String.IsNullOrWhiteSpace(input))
            {
                showContent.PrintContent(DataContent.ErrorData.WrongInput);
                showContent.PrintContent(DataContent.ErrorData.RedirectToMainMenu);
                Thread.Sleep(3000);
                RedirectTo.MainMenu();
            }

            newInput = ConvertInputToLong(input);
        }

        private static long ConvertInputToLong(string input)
        {
            IShowContent showContent = new ShowContentService();
            bool succConvertedToInt = long.TryParse(input, out long convertedNumber);

            if (!succConvertedToInt)
            {
                showContent.PrintContent(DataContent.ErrorData.WrongInput);
                showContent.PrintContent(DataContent.ErrorData.RedirectToMainMenu);
                Thread.Sleep(3000);
                RedirectTo.MainMenu();
            }

            return convertedNumber;
        }

        public static int ConvertInputToInt(string input, out bool succConvertedToInt)
        {
            IShowContent showContent = new ShowContentService();
            succConvertedToInt = int.TryParse(input, out int convertedNumber);

            if (!succConvertedToInt)
            {
                showContent.PrintContent(DataContent.ErrorData.WrongInput);
                showContent.PrintContent(DataContent.ErrorData.RedirectToMainMenu);
                Thread.Sleep(3000);
                RedirectTo.MainMenu();
            }

            return convertedNumber;
        }
    }
}
