using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    static class UtilityMethods
    {
        public static string ReadTextInput(string message)
        {
            string returnValue;

            Console.WriteLine(message);
            returnValue = Console.ReadLine();

            return returnValue; 
        }

        public static void ReadTextInput(string message, ref string returnValue)
        {
            Console.WriteLine(message);
            returnValue = Console.ReadLine(); 
        }

        public static int ReadNumericInput(string message)
        {
            int returnValue;

            Console.WriteLine(message);
            returnValue = Convert.ToInt32(Console.ReadLine());

            return returnValue; 
        }

        public static void ReadNumericInput(string message, ref int returnValue)
        {
            Console.WriteLine(message);
            returnValue = Convert.ToInt32(Console.ReadLine());
        }

        public static void PressAnyKeyToContinue()
        {
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey(); 
        }
    }
}
