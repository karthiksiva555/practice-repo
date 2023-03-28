using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapterSevenHandsOn
{
    public class Program
    {
        static void Main(string[] args)
        {
            var prog = new Program();
            //prog.PrintCarDetailsUsingList();
            prog.PrintCarDetailsUsingCustomClass();
            Console.ReadKey();
        }

        public void PrintCarDetailsUsingCustomClass()
        {
            var car1 = new Car { Id = 1, Name = "Audi A4", Year = 2015 };
            var car2 = new Car { Id = 2, Name = "BMW 3 series", Year = 2016 };

            var cars = new Cars();
            cars.CarList = new Car[4];
            cars.Add(car1);
            cars.Add(car2);

            for (var i = 0; i < cars.CarList?.Length; i++)
                Console.WriteLine($"Car Details: Name:{cars.CarList[i].Name} and Year :{cars.CarList[i].Year}");

        }

        public void PrintCarDetailsUsingList()
        {
            var car1 = new Car { Id = 1, Name = "Audi A4", Year = 2015 };
            var car2 = new Car { Id = 2, Name = "BMW 3 series", Year = 2016 };

            var cars = new List<Car>();
            cars.Add(car1);
            cars.Add(car2);

            foreach (var car in cars)
                Console.WriteLine($"Car Details: Name:{car.Name} and Year :{car.Year}");
        }
    }
}
