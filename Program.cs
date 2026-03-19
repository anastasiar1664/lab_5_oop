using System;

namespace Laba5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Лабораторная работа №5");
            Console.WriteLine("=====================");
            
            // Задание 1
            Console.WriteLine("\n=== Задание 1: Товар ===");
            Product product1 = new Product();
            product1.ShowInfo();
            
            Product product2 = new Product("Ноутбук", 45000.50m, true);
            product2.ShowInfo();

            // Задание 2
            Console.WriteLine("\n=== Задание 2: Топливный бак ===");
            FuelTank tank = new FuelTank("TNK-001");
            tank.Refuel(50);
            tank.Consume(20);
            tank.ShowLevel();

            // Задание 3
            Console.WriteLine("\n=== Задание 3: Лифт ===");
            Elevator elevator = new Elevator("OTIS Gen2", 15);
            elevator.MoveUp(10);
            elevator.Reset();

            // Задание 4
            Console.WriteLine("\n=== Задание 4: Лототрон ===");
            LotteryBall lottery1 = new LotteryBall();
            LotteryBall lottery2 = new LotteryBall(100);
            
            Console.WriteLine("Лототрон 1 (до 60):");
            for (int i = 0; i < 3; i++)
            {
                Console.Write($"{lottery1.Draw()} ");
            }
            
            Console.WriteLine("\nЛототрон 2 (до 100):");
            for (int i = 0; i < 3; i++)
            {
                Console.Write($"{lottery2.Draw()} ");
            }
            
            // Задание 5
            Console.WriteLine("\n\n=== Задание 5: Сотрудники ===");
            Employee intern = new Employee(3, 100);
            Employee specialist = new Employee(7, 80);
            Employee manager = new Employee(9, 60);
            
            intern.Work();
            specialist.Work();
            manager.Work();
            
            Console.WriteLine("\nНажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}