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
        static double Addition(ref double num, ref double num2)
        {
            // local data
            double resultDouble = num + num2;

            return resultDouble;
        }

        static double Subtraktion(ref double num, ref double num2)
        {
            // local data
            double resultDouble = num - num2;

            return resultDouble;
        }

        static double Multiplikation(ref double num, ref double num2)
        {
            // local data
            double resultDouble = num * num2;

            return resultDouble;
        }

        static double Division(ref double num, ref double num2)
        {
            // local data
            double resultDouble = 0;

            if (num2 != 0)
            {
                resultDouble = num / num2;
            }
            else
            {
                resultDouble = 0;
            }

            return resultDouble;
        }

        static double Power(ref double num1, ref double num2)
        {
            // local data
            double resultDouble = 0;

            resultDouble = num1;

            if (num2 == 0) // if num2 is 0
            {
                resultDouble = 1;
            }
            else if (num2 > 0) // if num2 is positive
            {
                for (int i = 0; i < num2 - 1; i++) // num2
                {
                    resultDouble = resultDouble * num1; // num1
                }
            }
            else if (num2 < 0) // if num2 is negative
            {
                num2 = num2 * -1; // multiplying num2 into positive number

                for (int i = 0; i < num2 - 1; i++) // num2
                {
                    resultDouble = resultDouble * num1; // num1
                }

                resultDouble = 1 / resultDouble; // dividing 1 with resultDouble to make it into float
            }
            else
            {
                //
            }

            return resultDouble;
        }

        static double Average(ref double num1, ref double num2)
        {
            // local data
            double resultDouble = 0;

            resultDouble = num1 + num2;
            resultDouble = resultDouble / 2;

            return resultDouble;
        }
    }
}
