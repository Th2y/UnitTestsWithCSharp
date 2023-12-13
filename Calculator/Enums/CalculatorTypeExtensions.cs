namespace Calculator.Enums
{
    public static class CalculatorTypeExtensions
    {
        public static bool RequiresSecondNumber(this CalculatorType type)
        {
            return 
                type == CalculatorType.MakeAddition ||
                type == CalculatorType.MakeSubtract ||
                type == CalculatorType.MakeMultiply ||
                type == CalculatorType.MakeDivide ||
                type == CalculatorType.MakePow;
        }
    }
}