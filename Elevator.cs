using System;

namespace Laba5
{
    class Elevator
    {
        public string Model;
        public int CurrentFloor;
        public int MaxFloor;

        public Elevator(string model, int maxFloor)
        {
            this.Model = model;
            this.MaxFloor = maxFloor;
            this.CurrentFloor = 1;
        }

        public void MoveUp(int floors)
        {
            int newFloor = this.CurrentFloor + floors;
            if (newFloor <= this.MaxFloor)
            {
                this.CurrentFloor = newFloor;
                Console.WriteLine($"Лифт поднялся на {floors} этаж(а). Текущий этаж: {this.CurrentFloor}");
            }
            else
            {
                this.CurrentFloor = this.MaxFloor;
                Console.WriteLine($"Нельзя подняться выше {this.MaxFloor} этажа. Лифт на {this.CurrentFloor} этаже.");
            }
        }

        public void Reset()
        {
            this.CurrentFloor = 1;
            Console.WriteLine($"Лифт сброшен на первый этаж");
        }
    }
}