//algo 
using System;

namespace PhysicsCalculationsLibrary
{
    public class PhysicsCalculator
    {
        public double CalculateForce(double mass, double acceleration)
        {
            return mass * acceleration;
        }
         public double CalculateWork(double force, double distance)
        {
            return force * distance;
        }
        public double CalculateKineticEnergy(double mass, double velocity)
        {
            return 0.5 * mass * velocity * velocity;
        }

    }
}


