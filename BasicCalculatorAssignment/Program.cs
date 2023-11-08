using System.Data;

namespace BasicCalculatorAssignment
{
    internal class Program
    {
        // The goal of this assignment is to learn how to create and use methods in our code
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Simple Calculator");
                Console.WriteLine("-----------------");
                Console.WriteLine("1. Add");
                Console.WriteLine("2. Subtract");
                Console.WriteLine("3. Multiply");
                Console.WriteLine("4. Divide");
                Console.WriteLine("5. Exit");

                Console.Write("Choose an operation: ");

                int UserChoice = Convert.ToInt32(Console.ReadLine());

                if (UserChoice == 5) {
                    break;
                }

                // Task 1. Read choice input and assing it to new int variable

                // Task 2. Check if user selected choice 5. If so then exit the loop

                
                // Task 3. Get the first number and assing it to new double variable
               
                // Task 4. Get the second number and assing it to new double variable

                // Task 5. Create double variable for default result value and assign it to be 0
               
                // Task 6. Handle choices using switch statement

                switch (UserChoice)
                {
                    case 1:
                        Add();
                        break;

                    case 2:
                        Subtract();
                        break;

                    case 3:
                        Multiply();
                        break;

                    case 4:
                        Divide();
                        break;

                    default:
                        Console.WriteLine("Invalid option");
                        break;
                }
                // Task 6.1 For each case create new function/method an call it inside the case
                //          - Case 1: Add 
                //          - Case 2: Subtract
                //          - Case 3: Multiply
                //          - Case 4: Divide, Note remeber to handle 0
                // Note: Think what the default choice should be
                // Note: Declare each case function/method outside Main method
                //       There is comment below where you can place your methods

                // Task 7. Print out the result
            }
        }

        // Declare your methods/functions here
        //I'm not sure I understood correctly what was wanted here, but here goes:
        static void Add()
        {
            Console.Write("Enter first number: ");
            double nro1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter second number: ");
            double nro2 = Convert.ToDouble(Console.ReadLine());

            double result = nro1 + nro2;
            Console.WriteLine(result);
        }

        static void Subtract()
        {
            Console.Write("Enter first number: ");
            double nro1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter second number: ");
            double nro2 = Convert.ToDouble(Console.ReadLine());

            double result = nro1 - nro2;
            Console.WriteLine(result);
        }

        static void Multiply()
        {
            Console.Write("Enter first number: ");
            double nro1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter second number: ");
            double nro2 = Convert.ToDouble(Console.ReadLine());

            double result = nro1 * nro2;
            Console.WriteLine(result);
        }

        static void Divide()
        {
            Console.Write("Enter first number: ");
            double nro1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter second number: ");
            double nro2 = Convert.ToDouble(Console.ReadLine());

            if (nro2 == 0)
            {
                Console.WriteLine("Can't divide by 0.");
            }
            else
            {
                double result = nro1 / nro2;
                Console.WriteLine(result);
            }
        }

    }
}