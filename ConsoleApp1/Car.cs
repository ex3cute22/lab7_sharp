using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    struct Car
    {
        public String marka;
        int year;
        int price;
        public int Year
        {
            set
            {
                if (value < 1885 || value > DateTime.Now.Year)
                {
                    Console.WriteLine("Год должен быть не меньше 1885 и не больше текущего!");
                    year = 0;
                }
                else
                {
                    year = value;
                }
            }
            get
            {
                return year; 
            }
        }
        public void init()
        {
            marka = "";
            year = 0;
            price = 0;
        }
        public void init(String _marka, int _year, int _price)
        {
            marka = _marka;
            year = _year;
            price = _price;
        }
        public void display()
        {
            Console.WriteLine($"Марка : {marka}  Год: {year}г.  Цена: {price}");
        }
        public void read()
        {
            Console.WriteLine("Марка: ");
            marka = Console.ReadLine();
            Console.WriteLine("Год: ");
            year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Цена: ");
            price = Convert.ToInt32(Console.ReadLine());
        }
    }
}
