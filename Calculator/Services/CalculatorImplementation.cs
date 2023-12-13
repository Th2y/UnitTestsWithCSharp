using Calculator.Enums;

namespace Calculator.Services
{
    public class CalculatorImplementation
    {
        public static double PerformCalculations(CalculatorType type, double x, double y = 0)
        {
            switch (type)
            {
                case CalculatorType.MakeAddition:
                    return MakeAddiction(x, y);
                case CalculatorType.MakeSubtract:
                    return MakeSubtract(x, y);
                case CalculatorType.MakeMultiply:
                    return MakeMultiply(x, y);
                case CalculatorType.MakeDivide:
                    return MakeDivide(x, y);
                case CalculatorType.MakePow:
                    return MakePow(x, y);
                case CalculatorType.MakeSin:
                    return MakeSin(x);
                case CalculatorType.MakeCos:
                    return MakeCos(x);
                case CalculatorType.MakeTan:
                    return MakeTan(x);
                case CalculatorType.MakeSquareRoot:
                    return MakeSquareRoot(x);
                default:
                    Console.WriteLine("Invalid calculator type.");
                    return 0;
            }
        }

        public static double MakeAddiction(double x, double y)
        {
            double result = x + y;
            Console.WriteLine($"{x} + {y} = {result}");
            return result;
        }

        public static double MakeSubtract(double x, double y)
        {
            double result = x - y;
            Console.WriteLine($"{x} - {y} = {result}");
            return result;
        }

        public static double MakeMultiply(double x, double y)
        {
            double result = x * y;
            Console.WriteLine($"{x} * {y} = {result}");
            return result;
        }

        public static double MakeDivide(double x, double y)
        {
            double result = x / y;
            Console.WriteLine($"{x} / {y} = {result}");
            return result;
        }

        public static double MakePow(double x, double y)
        {
            double result = Math.Pow(x, y);
            Console.WriteLine($"{x}^{y} = {result}");
            return result;
        }

        private static double MakeRadian(double angle)
        {
            return angle * Math.PI / 180;
        }

        public static double MakeSin(double angle)
        {
            double result = Math.Sin(MakeRadian(angle));
            Console.WriteLine($"The sine of {angle} = {result}");
            return result;
        }

        public static double MakeCos(double angle)
        {
            double result = Math.Cos(MakeRadian(angle));
            Console.WriteLine($"The cos of {angle} = {result}");
            return result;
        }

        public static double MakeTan(double angle)
        {
            double result = Math.Tan(MakeRadian(angle));
            Console.WriteLine($"The tan of {angle} = {result}");
            return result;
        }

        public static double MakeSquareRoot(double x)
        {
            double result = Math.Sqrt(x);
            Console.WriteLine($"The square root of {x} = {result}");
            return result;
        }
    }
}