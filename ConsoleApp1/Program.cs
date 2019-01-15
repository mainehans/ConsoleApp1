using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                //use for the string operation choice
                int operation = 0;
                //stock the result of the operation
                double result = 0;

                //Ask user first number
                Console.WriteLine("Mata in det första talet :");
                string stringFirstNumber = Console.ReadLine();
                double firstNumber = Convert.ToDouble(stringFirstNumber);

                //Ask user second number
                Console.WriteLine("Mata in det andra talet :");
                string stringSecondNumber = Console.ReadLine();
                double secondNumber = Convert.ToDouble(stringSecondNumber);

                //Ask user operation to use





                Console.WriteLine("Enter the operation + (addition), - (substraction), * (multiplication), / (division), ^ (exposant) or % (reste) :");
                string stringOperation = Console.ReadLine();


                // Convert string choice to integral
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

                //Do someting depending on the operation choose
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

                Console.WriteLine("\nResult of " + firstNumber + " " + stringOperation + " " + secondNumber + " = " + result + ".");
                Console.ReadKey();
            }
        }
    }
}