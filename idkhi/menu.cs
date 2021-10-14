using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Colorful;
using Console = Colorful.Console;

namespace spwnCLI
{
    class LangMenu
    {
        public static void LangSelect()
        {
            Console.Clear();
            Console.Title = "spwnCMP - Language Select";
            LangMenu2.LangMenu();
            stdLinguist.Language();
            CLI.cli();
        }
    }
    class LangMenu2
    {
        public static void LangMenu()
        {
            Console.Clear();
            Langs("1", "Russian");
            Langs("1", "English");
            string option = Console.ReadLine();
            if (option == "1")
            {
                stdLinguist.UserLang = "russian";
            }
            else if (option == "2")
            {
                stdLinguist.UserLang = "english";
            }
            else
            {
                Console.Write("ERROR! ", Color.Red);
                Console.WriteLine("Choose a valid variant!");
                LangMenu();
            }
        }
        
        static void Langs(string optionNumber, string LangName)
        {
            Console.Write("[");
            Console.Write(optionNumber, Color.Gray);
            Console.WriteLine("] " + LangName);
        }
    }
}
