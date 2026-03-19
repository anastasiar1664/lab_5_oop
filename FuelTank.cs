using System;

namespace Laba5
{
    class FuelTank
    {
        public string TankId;
        private double CurrentFuel;

        public FuelTank(string tankId)
        {
            this.TankId = tankId;
            this.CurrentFuel = 0;
        }

        public void Refuel(double amount)
        {
            if (amount > 0)
            {
                this.CurrentFuel += amount;
                Console.WriteLine($"Заправлено {amount} л. Текущий уровень: {this.CurrentFuel} л.");
            }
        }

        public void Consume(double amount)
        {
            if (amount <= this.CurrentFuel)
            {
                this.CurrentFuel -= amount;
                Console.WriteLine($"Израсходовано {amount} л. Текущий уровень: {this.CurrentFuel} л.");
            }
            else
            {
                Console.WriteLine($"Недостаточно топлива! Доступно: {this.CurrentFuel} л.");
            }
        }

        public void ShowLevel()
        {
            Console.WriteLine($"Бак {this.TankId}: {this.CurrentFuel} л. топлива");
        }
    }
}