using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Colorful;
using Console = Colorful.Console;

namespace spwnCLI
{
    class std
    {
        public static string Username = "Default";
        public static void ChangeUsername()
        {
            Console.WriteLine(stdLinguist.ChangeUsername);
            Username = Console.ReadLine();
            
            Console.WriteLine("");
        }

        public static void Version()
        {
            Console.WriteLine("spwnCLI version: " + stdStrings.version);
            Console.WriteLine(stdStrings.copyright);
            Console.WriteLine("");
        }
        
        public static void Build(string fileName)
        {
            Process.Start("spwn", " -build " + fileName);
        }
    }

    class stdStrings
    {
        public static string version = "0.0.0.1";
        public static string copyright = "(c) 2021 spwn-community & litecave.";
        
    }

    class stdLinguist
    {
        public static string UserLang = "english";
        public static string ChangeUsername;
        public static string buildStart;
        public static string welcome;
        public static void Language()
        {
            if (UserLang == "english")
            {
                ChangeUsername = "Enter new username!";
                buildStart = "Building started!";
                welcome = "Welcome, " + std.Username + "!";
            }
            if (UserLang == "russian")
            {
                ChangeUsername = "Введи новый юзернейм!";
                buildStart = "Сборка началась!";
                welcome = "Добро пожаловать, " + std.Username + "!";
            }
            else
            {
                LangMenu.LangSelect();
            }
        }
        
    }
}
