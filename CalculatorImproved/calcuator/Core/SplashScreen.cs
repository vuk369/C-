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
        static void SplashScreen()
        {
            Space(25);

            Console.WriteLine("                 ╔═══════════════════════════════════════════╗");
            Console.WriteLine("                 ║  Welcome to the Improved Calculator       ║");
            Console.WriteLine("                 ║                                           ║");
            Console.WriteLine("                 ║  Project: Improved Calculator             ║");
            Console.WriteLine("                 ║  Made by: Ognjen Letic                    ║");
            Console.WriteLine("                 ║  Date:    9.1.2023                        ║");
            Console.WriteLine("                 ║                                           ║");
            Console.WriteLine("                 ║  Please press any Key to continue         ║");
            Console.WriteLine("                 ╚═══════════════════════════════════════════╝");
            Console.WriteLine("");

            Space(8);

            Console.ReadKey();

            Console.Clear();
        }
    }
}
