using System;

namespace Laba5
{
    class Product
    {
        public string Name;
        public decimal Price;
        public bool IsInStock;

        public Product()
        {
            Name = "Неизвестный товар";
            Price = 0;
            IsInStock = false;
        }

        public Product(string name, decimal price, bool isInStock)
        {
            this.Name = name;
            this.Price = price;
            this.IsInStock = isInStock;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Товар: {Name}");
            Console.WriteLine($"Цена: {Price:C}");
            Console.WriteLine($"На складе: {(IsInStock ? "Да" : "Нет")}");
            Console.WriteLine();
        }
    }
}