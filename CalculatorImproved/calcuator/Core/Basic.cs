//Name: Calculator
//Autor: Ognjen Letic
//Datei: .cs
//Datum: 24.1.2023
//Klasse: AI122
//Beschreibung: main
//Änderungen:

using System;

namespace Calculator
{
    partial class main
    {
        static string Read(string intOrString)
        {
            // local data
            string userInput = "";
            bool isNum = true;
            bool loop = true;

            if (intOrString == "string")
            {
                userInput = Console.ReadLine();
            }
            else if (intOrString == "int")
            {
                while (loop == true)
                {
                    userInput = Console.ReadLine();

                    if (isNum = IsDigitsOnly(userInput))
                    {
                        return userInput;
                    }
                    else
                    {
                        Space(25);

                        Console.WriteLine("                 ╔═══════════════════════════════════════════╗");
                        Console.WriteLine("                 ║  There was an ERROR please try again      ║");
                        Console.WriteLine("                 ╚═══════════════════════════════════════════╝");

                        Space(11);

                        Console.Write("Your input:");
                    }
                }
            }
            else
            {
                //
            }

            return userInput;
        }

        static bool IsDigitsOnly(string intOrString)
        {
            // Local data
            int counter = 0;

            foreach (char c in intOrString)
            {
                counter = counter + 1;

                if (c < '0' || c > '9')
                {
                    return false;
                }
                else if (counter > 9)
                {
                    return false;
                }
                else
                {
                    //
                }
            }

            if (intOrString == "")
            {
                return false;
            }

            return true;
        }

        static void Space(int value)
        {
            for (int space = 0; space < value; space++)
            {
                Console.WriteLine("");
            }
        }

        static void Error()
        {
            Console.Clear();

            Space(25);

            Console.WriteLine("                 ╔═══════════════════════════════════════════╗");
            Console.WriteLine("                 ║    ERORR please press ENTER to RETURN     ║");
            Console.WriteLine("                 ╚═══════════════════════════════════════════╝");

            Space(10);

            Console.ReadKey();
            Console.Clear();
        }
    }
}
