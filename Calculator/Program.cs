using Calculator.Services;
using Calculator.Enums;

while (true)
{
    Console.WriteLine();
    Console.WriteLine("--------------------------------------");

    Console.WriteLine("Please, choose the operation you want");
    Console.WriteLine("1. Addition");
    Console.WriteLine("2. Subtraction");
    Console.WriteLine("3. Multiplication");
    Console.WriteLine("4. Division");
    Console.WriteLine("5. Power");
    Console.WriteLine("6. Sine");
    Console.WriteLine("7. Cosine");
    Console.WriteLine("8. Tangent");
    Console.WriteLine("9. Square Root");
    Console.WriteLine("0. Exit");

    if (int.TryParse(Console.ReadLine(), out int choise))
    {
        if (choise == 0)
        {
            break;
        }
        else if (Enum.IsDefined(typeof(CalculatorType), choise - 1))
        {
            double num1 = 0;
            double num2 = 0;

            CalculatorType operationType = (CalculatorType)(choise - 1);

            Console.WriteLine("--------------------------------------");

            Console.WriteLine("Please, insert a number.");
            while (!double.TryParse(Console.ReadLine(), out num1))
            {
                Console.WriteLine("This is not a number. Please, insert a number.");
            }

            Console.WriteLine("--------------------------------------");

            if (operationType.RequiresSecondNumber())
            {
                Console.WriteLine("Please, insert another number.");
                while (!double.TryParse(Console.ReadLine(), out num2))
                {
                    Console.WriteLine("This is not a number. Please, insert a number.");
                }

                Console.WriteLine("--------------------------------------");
            }

            CalculatorImplementation.PerformCalculations(operationType, num1, num2);
        }
        else
        {
            Console.WriteLine("Invalid option. Try again.");
        }
    }
    else
    {
        Console.WriteLine("Invalid option. Try again.");
    }
}
