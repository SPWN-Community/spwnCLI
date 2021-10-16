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
        public static void Main(string[] args)
        {
            start();
        }
        public static void start()
        {
            recli:
            Console.WriteLine("Start!");
            Thread.Sleep(5000);
            LangMenu.LangSelect();
            Console.Clear();
        }
    }

    class CLI
    {
        public static void cli()
        {
            Console.Title = "spwnCLI";
            Console.Write("> ", Color.LightGray);
            string answer = Console.ReadLine();
            Console.Write("Your answer was: ");
            Console.WriteLine(answer, Color.Red);
            if (answer == "restart")
            {
                Program.start();
            }
            Thread.Sleep(5000);
        }
    }
}
