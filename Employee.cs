using System;

namespace Laba5
{
    class Employee
    {
        public int SkillLevel;
        public int Energy;

        public Employee(int skillLevel, int energy)
        {
            this.SkillLevel = skillLevel;
            this.Energy = energy;
        }

        public void Work()
        {
            Console.WriteLine($"Сотрудник (уровень навыка: {SkillLevel}, энергия: {Energy}) выполняет задачу");
            this.Energy -= 10;
        }
    }
}