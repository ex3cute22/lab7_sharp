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

        public void ClassCar(String classAuto)
        {
            classAuto = "B";
            Console.WriteLine(classAuto);
        }

        public void ClassCarRef(ref String classAuto)
        {
            classAuto = "B";
            Console.WriteLine(classAuto);
        }

        public void ClassCarOut(out String classAuto)
        {
            classAuto = "B";
            Console.WriteLine(classAuto);
        }
        public void addTag()
        {
            marka += " (purchased)";
        }
        public static Car operator +(Car a, Car b)
        {
            return new Car {marka = a.marka + "-" + b.marka, year = (a.year + b.year)/2, price = a.price + b.price };
        }
        public static Car operator ++(Car a)
        {
            return new Car { marka = a.marka, year = a.year + 1, price = a.price + 100000 };
        }
    }
}
