using CalculatorEngine;
namespace CalculatorUnitTests;

public class CalculatorUnitTests {
    [SetUp]
    public void Setup()
    {
        var results = new CalculatorResults();
    }
    
    [Test]
    public void Add_TwoFloatingPointValues_ReturnsSum() {
        //preq-UNIT-TEST-2
        
        //Arrange
        var results = new CalculatorResults();
        const double a = 5.5;
        const double b = -3.15;
        const double expected = 2.35;
        
        //Act
        results = CalculatorEngine.CalculatorEngine.Add(a, b);
        
        //Assert
        Assert.That(results.Result, Is.EqualTo(expected));
    }
}