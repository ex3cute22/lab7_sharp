using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Shop
    {
        Car slot = new Car();
        String classCar;
        private static int count = 0;
        public void init()
        {
            slot.init();
            classCar = " ";
            count++;
        }
        public void init(Car _slot, String _classCar)
        {
            slot = _slot;
            classCar = _classCar;
            count++;
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
        public static void RemoveItem()
        {
            count--;
        }
        public static int InfoCount()
        {
            return count;
        }

    }
}
