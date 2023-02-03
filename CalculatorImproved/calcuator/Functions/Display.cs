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
        static void Display(double resultDouble)
        {
            Console.Clear();

            Space(25);

            Console.WriteLine("                 ╔═══════════════════════════════════════════╗");
            Console.WriteLine("                 ║  Finished                                 ║");
            Console.WriteLine("                 ║  Your result is " + resultDouble + "");
            Console.WriteLine("                 ║  Press any KEY to continue                ║");
            Console.WriteLine("                 ╚═══════════════════════════════════════════╝");

            Space(10);

            Console.ReadKey();

            resultDouble = 0;
        }
    }
}
