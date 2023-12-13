using Calculator.Enums;
using Calculator.Services;

namespace CalculatorTests;

public class CalculatorTests
{
    #region Addition
    [Fact]
    public void MustAdd1To2AndReturn3()
    {
        double num1 = 1;
        double num2 = 2;

        double result = CalculatorImplementation.MakeAddiction(num1, num2);

        Assert.Equal(3, result);
    }

    [Fact]
    public void MustPerformAddition5To10AndReturn15()
    {
        CalculatorType type = CalculatorType.MakeAddition;
        double x = 5;
        double y = 10;

        double result = CalculatorImplementation.PerformCalculations(type, x, y);

        Assert.Equal(15, result);
    }
    #endregion

    #region Subtraction
    [Fact]
    public void MustSubtract10From5AndReturnMinus5()
    {
        double num1 = 5;
        double num2 = 10;

        double result = CalculatorImplementation.MakeSubtract(num1, num2);

        Assert.Equal(-5, result);
    }

    [Fact]
    public void MustPerformSubtraction10From5AndReturn5()
    {
        CalculatorType type = CalculatorType.MakeSubtract;
        double x = 10;
        double y = 5;

        double result = CalculatorImplementation.PerformCalculations(type, x, y);

        Assert.Equal(5, result);
    }
    #endregion

    #region Multiplication
    [Fact]
    public void MustMultiply2By3AndReturn6()
    {
        double num1 = 2;
        double num2 = 3;

        double result = CalculatorImplementation.MakeMultiply(num1, num2);

        Assert.Equal(6, result);
    }

    [Fact]
    public void MustPerformMultiplication5By10AndReturn50()
    {
        CalculatorType type = CalculatorType.MakeMultiply;
        double x = 5;
        double y = 10;

        double result = CalculatorImplementation.PerformCalculations(type, x, y);

        Assert.Equal(50, result);
    }
    #endregion

    #region Division
    [Fact]
    public void MustDivide6By3AndReturn2()
    {
        double num1 = 6;
        double num2 = 3;

        double result = CalculatorImplementation.MakeDivide(num1, num2);

        Assert.Equal(2, result);
    }

    [Fact]
    public void MustPerformDivision10By2AndReturn5()
    {
        CalculatorType type = CalculatorType.MakeDivide;
        double x = 10;
        double y = 2;

        double result = CalculatorImplementation.PerformCalculations(type, x, y);

        Assert.Equal(5, result);
    }
    #endregion

    #region Power
    [Fact]
    public void MustCalculate2ToThePowerOf3AndReturn8()
    {
        double num1 = 2;
        double num2 = 3;

        double result = CalculatorImplementation.MakePow(num1, num2);

        Assert.Equal(8, result);
    }

    [Fact]
    public void MustPerformPower2ToThePowerOf3AndReturn8()
    {
        CalculatorType type = CalculatorType.MakePow;
        double x = 2;
        double y = 3;

        double result = CalculatorImplementation.PerformCalculations(type, x, y);

        Assert.Equal(8, result);
    }
    #endregion

    #region Sine
    [Fact]
    public void MustCalculateSineOf30DegreesAndReturn0_5()
    {
        double angle = 30;

        double result = CalculatorImplementation.MakeSin(angle);

        Assert.Equal(0.5, result, 2);
    }

    [Fact]
    public void MustPerformSineOf30DegreesAndReturn0_5()
    {
        CalculatorType type = CalculatorType.MakeSin;
        double x = 30;

        double result = CalculatorImplementation.PerformCalculations(type, x);

        Assert.Equal(0.5, result, 2);
    }
    #endregion

    #region Cosine
    [Fact]
    public void MustCalculateCosineOf60DegreesAndReturn0_5()
    {
        double angle = 60;

        double result = CalculatorImplementation.MakeCos(angle);

        Assert.Equal(0.5, result, 2);
    }

    [Fact]
    public void MustPerformCosineOf60DegreesAndReturn0_5()
    {
        CalculatorType type = CalculatorType.MakeCos;
        double x = 60;

        double result = CalculatorImplementation.PerformCalculations(type, x);

        Assert.Equal(0.5, result, 2);
    }
    #endregion

    #region Tangent
    [Fact]
    public void MustCalculateTangentOf45DegreesAndReturn1()
    {
        double angle = 45;

        double result = CalculatorImplementation.MakeTan(angle);

        Assert.Equal(1, result, 2);
    }

    [Fact]
    public void MustPerformTangentOf45DegreesAndReturn1()
    {
        CalculatorType type = CalculatorType.MakeTan;
        double x = 45;

        double result = CalculatorImplementation.PerformCalculations(type, x);

        Assert.Equal(1, result, 2);
    }
    #endregion

    #region Square Root
    [Fact]
    public void MustCalculateSquareRootOf25AndReturn5()
    {
        double num = 25;

        double result = CalculatorImplementation.MakeSquareRoot(num);

        Assert.Equal(5, result);
    }

    [Fact]
    public void MustPerformSquareRootOf25AndReturn5()
    {
        CalculatorType type = CalculatorType.MakeSquareRoot;
        double x = 25;

        double result = CalculatorImplementation.PerformCalculations(type, x);

        Assert.Equal(5, result);
    }
    #endregion
}