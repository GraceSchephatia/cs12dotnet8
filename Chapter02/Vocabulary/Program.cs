using System;
using System.Linq;
using System.Collections.Generic;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //#error version

            //Console.WriteLine("Hello World!");
            WriteLine($"Computer named {Env.MachineName} says \"No.\"");

            #region Three variables that store the number 2 million.
            int decimalNotation = 2_000_000;
            int binaryNotation = 0b_0001_1110_1000_0100_1000_0000;
            int hexadecimalNotation = 0x_001E_8480;
            #endregion

            // Outputs the current line terminator.
            // By default, this is a carriage-return and line feed.
            Console.WriteLine();
            // Outputs the greeting and the current line terminator.
            Console.WriteLine("Hello Ahmed");
            // Outputs a formatted number and date and the current line terminator.
            Console.WriteLine(
            "Temperature on {0:D} is {1}°C.", DateTime.Today, 23.4);
        }
    }
}