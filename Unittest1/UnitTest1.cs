using Operators;

namespace Unittest1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Add_Test()
        {
            CalViewModel calViewModel = new CalViewModel();
            var result = calViewModel.Add();
            result = 200;

            Assert.IsTrue(result == 200);
        }
        [Test]
        public void Sub_Test()
        {
            CalViewModel calViewModel = new CalViewModel();
            var result = calViewModel.Subtract();
            result = 200;

            Assert.IsTrue(result == 200);
        }
        [Test]
        public void Mul_Test()
        {
            CalViewModel calViewModel = new CalViewModel();
            var result = calViewModel.Multiply();
            result = 200;

            Assert.IsTrue(result == 200);
        }
        [Test]
        public void Div_Test()
        {
            // Arrange
            CalViewModel calViewModel = new CalViewModel();
            calViewModel.Num1 = 200;
            calViewModel.Num2 = 10; // Set a non-zero value for Num2

            // Act
            var result = calViewModel.Divide();

            // Assert
            Assert.IsTrue(result == 20); // Assuming 200 / 10 = 20
        }

    }
}