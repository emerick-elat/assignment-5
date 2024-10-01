﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Threads_2
{
    internal class CharThread
    {
        private string Content {  get; set; }

        public CharThread(string content)
        {
            Content = content;
        }

        public void PrintContent(ConsoleColor color)
        {
            Console.ForegroundColor = color;
            foreach (char c in Content)
            {
                Console.Write(c);
                Thread.Sleep(300);
            }

            Console.ResetColor();
            Console.WriteLine();
        }
    }
}
