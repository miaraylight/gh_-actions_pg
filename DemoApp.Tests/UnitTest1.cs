using NUnit.Framework;
using DemoApp;

namespace DemoApp.Tests;

public class CalculatorTests
{
    private Calculator _calculator;

    [SetUp]
    public void Setup()
    {
        _calculator = new Calculator();
    }

    [Test]
    public void Add_ShouldReturnCorrectSum()
    {
        var result = _calculator.Add(2, 2);
        Assert.That(result, Is.EqualTo(4));
    }

    [Test]
    public void Divide_ShouldReturnCorrectQuotient()
    {
        var result = _calculator.Divide(4, 2);
        Assert.That(result, Is.EqualTo(2));
    }

    [Test]
    public void Failing_Test()
    {
        Assert.That(1, Is.EqualTo(2));
    }
}