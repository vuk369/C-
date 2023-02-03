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
        static int Menu(int userIntInput)
        {
            // local data
            int selectSize = 7;
            string[] selectString = new string[selectSize];

            for (int count = 0; count < selectSize; count++)
            {
                selectString[count] = " ";
            }

            if (userIntInput < 0)
            {
                userIntInput = 6;
            }
            else if (userIntInput > selectSize - 1)
            {
                userIntInput = 0;
            }
            else
            {
                //
            }

            selectString[userIntInput] = "X";

            Space(25);

            Console.WriteLine("                ╔══════════════════════════════╗");
            Console.WriteLine("                ║  Use UpArrow, DownArrow and  ║");
            Console.WriteLine("                ║  Enter to navigate through   ║");
            Console.WriteLine("                ║  Menu                        ║");
            Console.WriteLine("                ╠══════════════════════════════╣");
            Console.WriteLine("                ║                              ║");
            Console.WriteLine("                ║  |" + selectString[0] + "| Addition                ║");
            Console.WriteLine("                ║  |" + selectString[1] + "| Subtraction             ║");
            Console.WriteLine("                ║  |" + selectString[2] + "| Multiplication          ║");
            Console.WriteLine("                ║  |" + selectString[3] + "| Division                ║");
            Console.WriteLine("                ║  |" + selectString[4] + "| Power                   ║");
            Console.WriteLine("                ║  |" + selectString[5] + "| Average                 ║");
            Console.WriteLine("                ║  |" + selectString[6] + "| Exit                    ║");
            Console.WriteLine("                ║                              ║");
            Console.WriteLine("                ╚══════════════════════════════╝");

            Space(5);

            return userIntInput;
        }
    }
}
