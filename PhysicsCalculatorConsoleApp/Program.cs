﻿// See https://aka.ms/new-console-template for more information
// algo
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
                
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Console.Write("Ingrese la masa (kg): ");
                        double mass = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Ingrese la aceleración (m/s^2): ");
                        double acceleration = Convert.ToDouble(Console.ReadLine());
                        double force = calculator.CalculateForce(mass, acceleration);
                        Console.WriteLine($"Fuerza: {force} N");
                        break;

                    case "2":
                        Console.Write("Ingrese la fuerza (N): ");
                        force = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Ingrese la distancia (m): ");
                        double distance = Convert.ToDouble(Console.ReadLine());
                        double work = calculator.CalculateWork(force, distance);
                        Console.WriteLine($"Trabajo: {work} J");
                        break;

                    case "3":
                        Console.Write("Ingrese la masa (kg): ");
                        mass = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Ingrese la velocidad (m/s): ");
                        double velocity = Convert.ToDouble(Console.ReadLine());
                        double kineticEnergy = calculator.CalculateKineticEnergy(mass, velocity);
                        Console.WriteLine($"Energía Cinética: {kineticEnergy} J");
                        break;

                    case "4":
                        continueCalculating = false;
                        break;

                    default:
                        Console.WriteLine("Opción no válida. Intente de nuevo.");
                        break;
                }

                if (continueCalculating)
                {
                    Console.WriteLine("¿Desea realizar otro cálculo? (s/n)");
                    string continueChoice = Console.ReadLine().ToLower();
                    if (continueChoice != "s")
                    {
                        continueCalculating = false;
                    }
                }
            }
        }
    }
}
