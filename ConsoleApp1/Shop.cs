using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Shop
    {
        Car slot = new Car();
        String classCar;
        public void init()
        {
            slot.init();
            classCar = " ";
        }
        public void init(Car _slot, String _classCar)
        {
            slot = _slot;
            classCar = _classCar;
        }
        public void display()
        {
            Console.WriteLine($"Класс автомобиля: {classCar}");
            slot.display();
        }
        public void read()
        {
            Console.WriteLine("Укажите класс автомобиля: ");
            classCar = Console.ReadLine();
            slot.read();
        }
    }
}
