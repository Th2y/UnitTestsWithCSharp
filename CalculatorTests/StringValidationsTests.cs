using Calculator.Services;

namespace CalculatorTests;

public class StringValidationsTests
{
    private StringValidations _stringValidations;

    public StringValidationsTests()
    {
        _stringValidations = new();
    }

    [Fact]
    public void MustContain5CharactersInHelloAndReturn5()
    {
        string text = "Hello";

        int result = _stringValidations.CountCharacters(text);

        Assert.Equal(5, result);
    }
}