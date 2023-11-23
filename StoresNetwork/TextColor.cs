using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoresNetwork
{
    internal static class TextColor
    {
        static void Write(ConsoleColor color, string text)
        {
            Console.ForegroundColor = color;
            Console.Write(text);
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static void GreenText(string text)
        {
            Write(ConsoleColor.Green, text);
        }
        public static void YellowText(string text)
        {
            Write(ConsoleColor.Yellow, text);
        }
        public static void BlueText(string text)
        {
            Write(ConsoleColor.Blue, text);
        }
    }
}
