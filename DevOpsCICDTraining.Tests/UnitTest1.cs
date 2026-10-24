using Xunit;

namespace DevOpsCICDTraining.Tests;

public class UnitTest1
{
    [Fact]
    public void Add_TwoNumbers_ReturnsTheirSum()
    {
        // Arrange
        Calculator calculator = new Calculator();

        // Act
        int result = calculator.Add(10, 20);

        // Assert
        Assert.Equal(30, result);
    }
}