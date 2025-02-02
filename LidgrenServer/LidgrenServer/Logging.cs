﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LidgrenServer
{
    public class Logging
    {
        public static void Info(String message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("[{0}] [INFO] {1}",Date(),message);
            Console.ResetColor();
        }

        public static void Warn(String message)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("[{0}] [WARN] {1}", Date(), message);
            Console.ResetColor();
        }

        public static void Error(String message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("[{0}] [ERROR] {1}", Date(), message);
            Console.ResetColor();
        }

        public static void Debug(String message)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("[{0}] [DEBUG] {1}", Date(), message);
            Console.ResetColor();
        }
        public static string Date()
        {
            return DateTime.Now.ToString();
        }

    }
}
