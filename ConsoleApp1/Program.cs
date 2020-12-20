using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Car[] cars = new Car[5];
            for (int i = 0; i < cars.Length; i++)
            {
                cars[i] = new Car();
                cars[i].init("Лада 210" + (i+3), Convert.ToInt32(200.ToString() + (i + 3)), 100000 * (i+1));
            }
            

            //Различие между присваиванием объектов класса и структуры
            cars[0] = cars[1];
            cars[1].marka = "БМВ";


            for (int i = 0; i < cars.Length; i++)
            {
                cars[i].display();
            }

            cars[3].Year = 3000;
            cars[2].Year = 1900;

            for (int i = 0; i < cars.Length; i++)
            {
                cars[i].display();
            }
            String ClaSS = "A";
            cars[2].ClassCar(ClaSS);
            Console.WriteLine(ClaSS);

            String CLASS = "A";
            cars[3].ClassCarRef(ref CLASS);
            Console.WriteLine(CLASS);

            String CLASSOUT;
            cars[4].ClassCarOut(out CLASSOUT);
            Console.WriteLine(CLASSOUT);

            cars[4].addTag();
            /* cars[0] = cars[1];
             Car toyota = new Car();
             toyota.init("toyota", 2000, 100000);
             toyota.display();
             toyota.read();
             toyota.display();

             Shop diler = new Shop();
             diler.init(toyota, "Sport-Car");
             diler.display();
             diler.read();
             diler.display();*/
        }
    }
}
