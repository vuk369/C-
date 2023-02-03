//Name: Calculator
//Autor: Ognjen Letic
//Datei: main.cs
//Datum: 24.1.2023
//Klasse: AI122
//Beschreibung: main
//Änderungen:
//
//Box for the user interface
//╔════════════════════╗ ╠ ╣
//║                    ║
//╚════════════════════╝

using System;

namespace Calculator
{
    partial class main
    {
        static void Main(string[] args)
        {
            // Central data

            // Local data
            int userIntInput = 0;
            double num1 = 0;
            double num2 = 0;
            double resultDouble = 0;
            bool menuLoop = true;
            ConsoleKeyInfo userKeyInput;

            SplashScreen();

            // Menu loop
            while (menuLoop == true)
            {
                userIntInput = Menu(userIntInput);
                userKeyInput = Console.ReadKey();

                // Menu options
                if (userKeyInput.Key == ConsoleKey.UpArrow) // move up in menu
                {
                    userIntInput = userIntInput - 1;
                }
                else if (userKeyInput.Key == ConsoleKey.DownArrow) // move down in menu
                {
                    userIntInput = userIntInput + 1;
                }
                else if (userKeyInput.Key == ConsoleKey.Enter) // confirm in menu
                {
                    if (userIntInput == 0) // Addition
                    {
                        NumberInput(ref num1, ref num2);
                        resultDouble = Addition(ref num1, ref num2);
                        Display(resultDouble);
                    }
                    else if (userIntInput == 1) // Subtraktion
                    {
                        NumberInput(ref num1, ref num2);
                        resultDouble = Subtraktion(ref num1, ref num2);
                        Display(resultDouble);
                    }
                    else if (userIntInput == 2)  // Multiplikation
                    {
                        NumberInput(ref num1, ref num2);
                        resultDouble = Multiplikation(ref num1, ref num2);
                        Display(resultDouble);
                    }
                    else if (userIntInput == 3) // Division
                    {
                        NumberInput(ref num1, ref num2);
                        resultDouble = Division(ref num1, ref num2);
                        Display(resultDouble);
                    }
                    else if (userIntInput == 4) // Power
                    {
                        NumberInput(ref num1, ref num2);
                        resultDouble = Power(ref num1, ref num2);
                        Display(resultDouble);
                    }
                    else if (userIntInput == 5) // Average
                    {
                        NumberInput(ref num1, ref num2);
                        resultDouble = Average(ref num1, ref num2);
                        Display(resultDouble);
                    }
                    else if (userIntInput == 6) // Exit
                    {
                        menuLoop = false;
                    }
                    else // Error
                    {
                        Error();
                    }

                }
                else // Error
                {
                    //
                }

                Console.Clear();
            }
        }        
    }
}