using System;
using System.Collections.Generic;
using System.Text;

namespace PreparationProj.Collection
{

    public class Car : IComparable
    {
        public int Year { get; set; }

        public string Name { get; set; }

        public Car(int year, string name)
        {
            this.Year = year;
            this.Name = name;
        }

        public int CompareTo(object obj)
        {
            Car car = (Car)obj;
            if (car == null)
                return 1;
            // sort by year ascending order
            //if (car != null)
            //    return this.Year.CompareTo(car.Year);

            // sort by name ascending order
            if (car != null)
                return this.Name.CompareTo(car.Name);
            return 0;
        }
    }
    class Understand_IComparable
    {
        public static void Main1(string[] args)
        {
            List<Car> cars = new List<Car>()
            {
                new Car(1993, "vinod"),
                new Car(2000, "BMW"),
                new Car(1864, "Toyota")
            };
            DisplayListItems(cars);
            Console.WriteLine("----------------");
            cars.Sort();
            DisplayListItems(cars);

        }

        private static void DisplayListItems(List<Car> values)
        {
            foreach (var car in values)
            {
                Console.WriteLine(car.Name + "  " + car.Year);
            }
        }
    }
}
