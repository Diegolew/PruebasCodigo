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

        [Test]
        public void TestCalculateWork()
        {
            // Arrange
            PhysicsCalculator calculator = new PhysicsCalculator();
            double force = 50.0;
            double distance = 10.0;

            // Act
            double result = calculator.CalculateWork(force, distance);

            // Assert
            Assert.AreEqual(500.0, result);
        }

        [Test]
        public void TestCalculateKineticEnergy()
        {
            // Arrange
            PhysicsCalculator calculator = new PhysicsCalculator();
            double mass = 10.0;
            double velocity = 5.0;

            // Act
            double result = calculator.CalculateKineticEnergy(mass, velocity);

            // Assert
            Assert.AreEqual(125.0, result);
        }

    }
}
