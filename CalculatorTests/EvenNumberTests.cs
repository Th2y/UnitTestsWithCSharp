using Calculator.Services;

namespace CalculatorTests;
public class EvenNumberTests
{
    private EvenNumber _evenNumber;

    public EvenNumberTests()
    {
        _evenNumber = new();
    }

    [Fact]
    public void MustCheckIf50ItsEvenAndReturnTrue()
    {
        int number = 50;

        bool result = _evenNumber.ItsAEvenNumber(number);

        Assert.True(result);
    }

    [Theory]
    [InlineData(2)]
    [InlineData(4)]
    [InlineData(6)]
    [InlineData(8)]
    [InlineData(10)]
    public void MustCheckIfTheNumbersItsEvenAndReturnTrue(int number)
    {
        bool result = _evenNumber.ItsAEvenNumber(number);

        Assert.True(result);
    }

    [Theory]
    [InlineData(new int[] { 2, 4 })]
    [InlineData(new int[] { 6, 8, 10 })]
    public void MustCheckIfTheListNumbersItsEvenAndReturnTrue(int[] numbers)
    {
        Assert.All(numbers, num => Assert.True(_evenNumber.ItsAEvenNumber(num)));
    }
}