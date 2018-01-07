using System;
using System.Collections.Generic;

namespace PlayGround
{
    class Program
    {
        static void Main(string[] args)
        {
            var c = new Controller();
            c.Start();

        //List<Country> countries = new List<Country>
        //{
        //    new Country(){ name = "Denmark"},
        //    new Country(){ name = "Sweden"},
        //    new Country(){ name = "Norway"},
        //    new Country(){ name = "Japan"},
        //    new Country(){ name = "Germany"},
        //    new Country(){ name = "France"}
        //};

        //countries.ForEach(item => Console.WriteLine(" test {0} ", item.name));

        //List<Manufactor> manufactors = new List<Manufactor>
        //{
        //    new Manufactor(){name = "Mazda", Country = { name = "Japan" } },
        //    new Manufactor(){name = "Suzuki", Country = { name = "Japan" } },
        //    new Manufactor(){name = "BMW", Country = { name = "Germany" } }
        //};

        //manufactors.ForEach(item => Console.WriteLine(" test {0} {1} ", item.name, item.Country.name));

        //List<Car> cars = new List<Car>
        //{
        //    new Car(){name = "626", Manufactor = { name = "Mazda" } },
        //    new Car(){name = "Baleno", Manufactor = { name = "Suzuki" } },
        //    new Car(){name = "323", Manufactor = { name = "BMW" } }
        //};

        //cars.ForEach(item => Console.WriteLine(" test {0} {1} ", item.name, item.Manufactor.name));
    }
        public class Controller
    {
            public CountryCollection Countries { get; set; } = new CountryCollection();
            public ManufactorCollection Manufactors { get; set; } = new ManufactorCollection();
            public CarCollection Cars { get; set; } = new CarCollection();

            public void Start()
            {

            }
        }

        public class CarCollection:List<Car>
        {

        }

        public class Car
        {
            public string name;
            private Manufactor _manufactor = null;
            public Manufactor Manufactor { get
                {
                    if (_manufactor == null) _manufactor = new Manufactor();
                    return _manufactor;
                }
            }
        }

        public class ManufactorCollection : List<Manufactor>
        {

        }

        public class Manufactor
        {
            public string name;
            private Country _country = null;
            public Country Country
            {
                get
                {
                    if (_country == null) _country = new Country();
                    return _country;
                }
            }
        }

        public class CountryCollection : List<Country>
        {
            //public string Add (string name)
            //{
            //return (name);
            //}
        }

        public class Country
        {
            public string name;

        }
    }
}
