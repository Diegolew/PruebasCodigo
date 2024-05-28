// See https://aka.ms/new-console-template for more information
using System;
using PhysicsCalculationsLibrary;

namespace PhysicsCalculatorConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            PhysicsCalculator calculator = new PhysicsCalculator();
            bool continueCalculating = true;

            while (continueCalculating)
            {
                Console.WriteLine("Seleccione la operación a realizar:");
                Console.WriteLine("1. Calcular Fuerza (F = m * a)");
                Console.WriteLine("2. Calcular Trabajo (W = F * d)");
                Console.WriteLine("3. Calcular Energía Cinética (E = 0.5 * m * v^2)");
                Console.WriteLine("4. Salir");
            }
        }
    }
}
