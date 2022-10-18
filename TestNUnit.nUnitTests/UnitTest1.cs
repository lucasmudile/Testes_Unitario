using NUnit.Framework;

namespace TestNUnit.nUnitTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public void Somar()
        {
           // Assert.Pass();
            Assert.AreEqual(12, Calculator.Calculadora.Somar(10, 2));
        }
    }
}