using System;
using System.Collections.Generic;
using System.Linq;

namespace Task1
{
    public class Country
    {
        public string Name { get; set; }

        public Country(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }
    }

    public class City
    {
        public string Name { get; set; }
        public Country Country { get; set; }

        public City(string name, Country country)
        {
            Name = name;
            Country = country;
        }

        public override string ToString()
        {
            return $"{Name}, {Country}";
        }
    }

    public class Region
    {
        public string Name { get; set; }
        public List<City> Cities { get; set; }

        public Region(string name)
        {
            Name = name;
            Cities = new List<City>();
        }

        public void AddCity(City city)
        {
            Cities.Add(city);
        }

        public List<City> SearchByCityName(string cityName)
        {
            return Cities.Where(city => city.Name.Contains(cityName, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        public List<City> SearchByCountryName(string countryName)
        {
            return Cities.Where(city => city.Country.Name.Contains(countryName, StringComparison.OrdinalIgnoreCase)).ToList();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Country ukraine = new Country("Ukraine");
            Country usa = new Country("USA");

            Region myRegion = new Region("Central Region");

            myRegion.AddCity(new City("Kyiv", ukraine));
            myRegion.AddCity(new City("Lviv", ukraine));
            myRegion.AddCity(new City("New York", usa));
            myRegion.AddCity(new City("Los Angeles", usa));
            myRegion.AddCity(new City("Kharkiv", ukraine));

            Console.WriteLine("Search for a city by name or country.");
            Console.WriteLine("1. Search by city name");
            Console.WriteLine("2. Search by country name");
            Console.WriteLine("Select an option: ");
            string option = Console.ReadLine();

            if (option == "1")
            {
                Console.Write("Enter a city name: ");
                string cityName = Console.ReadLine();
                var results = myRegion.SearchByCityName(cityName);

                if (results.Count > 0)
                {
                    Console.WriteLine("Found cities:");
                    foreach (var city in results)
                    {
                        Console.WriteLine(city);
                    }
                }
                else
                {
                    Console.WriteLine("City not found.");
                }
            }
            else if (option == "2")
            {
                Console.Write("Enter the country name: ");
                string countryName = Console.ReadLine();
                var results = myRegion.SearchByCountryName(countryName);

                if (results.Count > 0)
                {
                    Console.WriteLine("Cities found:");
                    foreach (var city in results)
                    {
                        Console.WriteLine(city);
                    }
                }
                else
                {
                    Console.WriteLine("City not found in this country.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }
        }
    }
}