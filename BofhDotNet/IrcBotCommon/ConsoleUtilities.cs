using System;

namespace BofhDotNet.IrcBotCommon
{
    // Utilities for working with operating system console interface.
    public static class ConsoleUtilities
    {
        public static void WriteError(string message, params string[] args)
        {
            UseTextColor(ConsoleColor.Red, () => Console.Error.WriteLine(message, args));
        }

        public static void WriteWarning(string message, params string[] args)
        {
            UseTextColor(ConsoleColor.Yellow, () => Console.Error.WriteLine(message, args));
        }

        public static void UseTextColor(ConsoleColor colour, Action action)
        {
            var prevForegroundColor = Console.ForegroundColor;
            Console.ForegroundColor = colour;
            action();
            Console.ForegroundColor = prevForegroundColor;
        }

        public static void Test()
        {
            Console.Error.WriteLine("This is a dumb test");
        }
    }
}
