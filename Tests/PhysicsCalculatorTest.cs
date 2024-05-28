using NUnit.Framework;
using PhysicsCalculationsLibrary;

namespace Tests
{
    public class PhysicsCalculatorTest
    {
        [Test]
        public void TestCalculateForce()
        {
            // Arrange
            PhysicsCalculator calculator = new PhysicsCalculator();
            double mass = 10.0;
            double acceleration = 5.0;

            // Act
            double result = calculator.CalculateForce(mass, acceleration);

            // Assert
            Assert.AreEqual(50.0, result);
        }

        // Agrega más pruebas para otras funciones aquí...
    }
}
