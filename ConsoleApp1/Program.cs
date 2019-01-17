﻿using System;

namespace kalkulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var keepAlive = true;

            while (keepAlive)
            {
                try
                {
                    //lagra val av strängsort
                    int operation = 0;
                    //Lagra val Av operation
                    double result = 0;

                    //fråga användare om första nummret
                    Console.WriteLine("Mata in det första talet :");
                    string stringFirstNumber = Console.ReadLine();
                    double firstNumber = Convert.ToDouble(stringFirstNumber);

                    //fråga användare om andra nummret
                    Console.WriteLine("Mata in det andra talet :");
                    string stringSecondNumber = Console.ReadLine();
                    double secondNumber = Convert.ToDouble(stringSecondNumber);

                    //fråger om val av operation


                    Console.WriteLine("skriv in funktionen + (addision), - (substraction), * (multiplikation), / (division), ^ (exposant) Eller % (rest) :");
                    string stringOperation = Console.ReadLine();


                    // konvertera string string val till integral
                    if (stringOperation == "+" || stringOperation == "addition")
                    {
                        operation = 1;
                    }
                    else if (stringOperation == "-" || stringOperation == "substraction")
                    {
                        operation = 2;
                    }
                    else if (stringOperation == "*" || stringOperation == "multiplication")
                    {
                        operation = 3;
                    }
                    else if (stringOperation == "/" || stringOperation == "division")
                    {
                        operation = 4;
                    }
                    else if (stringOperation == "^" || stringOperation == "exposant")
                    {
                        operation = 5;
                    }
                    else if (stringOperation == "%" || stringOperation == "reste")
                    {
                        operation = 6;
                    }

                    //Gör åtgärd av operand på inmatad data
                    switch (operation)
                    {
                        case 1:
                            result = firstNumber + secondNumber;
                            break;

                        case 2:
                            result = firstNumber - secondNumber;
                            break;

                        case 3:
                            result = firstNumber * secondNumber;
                            break;
                    }

                    Console.WriteLine("\nresultat av " + firstNumber + " " + stringOperation + " " + secondNumber + " = " + result + ".");
                    Console.WriteLine("vill du göra en ny uträkning ? Ja tryck enter. avsluta tryck x");
                    string avsluta = Console.ReadLine();
                    if (avsluta == "x")
                    {
                        keepAlive = false;

                    }
                    else if (avsluta == "a")
                    {

                    }

                }
                catch
                {
                    Console.WriteLine("Felaktig inmatat värde");

                    Console.ReadKey();
                    Console.Clear();

                }
            }// while loop end
        }// main ends


    }// class ends
}// namespace ends 