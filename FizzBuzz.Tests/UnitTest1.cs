namespace FizzBuzz.Tests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        Assert.Pass();
    }
    
    [Test]
    public void FizzBuzzTest()
    {
        int x = 20;
        string expected = "1, 2, 3 Fizz, 4, 5 Buzz, 6 Fizz, 7, 8, 9 Fizz, 10 Buzz, 11, 12 Fizz, 13, 14, 15 FizzBuzz, 16, 17, 18 Fizz, 19, 20 Buzz";
        string result = FizzBuzz(x);
        Assert.AreEqual(expected, result);
    }
}