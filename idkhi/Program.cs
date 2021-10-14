using System;
using System.Threading;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using Colorful;
using Console = Colorful.Console;

namespace spwnCLI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start!");
            Thread.Sleep(5000);
            LangMenu.LangSelect();
        }
    }

    class CLI
    {
        public static void cli()
        {
            Console.Title = "spwnCLI";
            Console.Write("> ", Color.LightGray);
            string answer = Console.ReadLine();
        }
    }
}
