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
        static void NumberInput(ref double num1, ref double num2)
        {
            // local data

            Console.Clear();

            Space(25);

            Console.WriteLine("                 ╔═══════════════════════════════════════════╗");
            Console.WriteLine("                 ║  Input the 1 number and press ENTER       ║");
            Console.WriteLine("                 ╚═══════════════════════════════════════════╝");

            Space(11);

            Console.Write("Your input:");

            num1 = Convert.ToInt32(Read("int"));

            Console.Clear();

            Space(25);

            Console.WriteLine("                 ╔═══════════════════════════════════════════╗");
            Console.WriteLine("                 ║  Input the 2 number and press ENTER       ║");
            Console.WriteLine("                 ╚═══════════════════════════════════════════╝");

            Space(11);

            Console.Write("Your input:");

            num2 = Convert.ToDouble(Read("int"));
            Console.Clear();
        }
    }
}
