using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Country
    {
        public string NameOfCountry;
        public int TotalPopulationOfCountry;
        public static Country[] countryArray = new Country[0];
        public City[] citiesOfCountry;

        public Country(string country)
        {
            NameOfCountry = country;
            TotalPopulationOfCountry = 0;

            Array.Resize(ref countryArray, countryArray.Length + 1);
            countryArray[countryArray.Length - 1] = this;

            citiesOfCountry = new City[0];
        }

        public static void FindAllByPopulation(int min, int max)
        {


            foreach (Country country in countryArray)
            {

                bool cityInRange = false;
                Console.WriteLine("\n==> Country: " + country.NameOfCountry + " || Population: " + country.TotalPopulationOfCountry);


               
                if (! country.FindByPopulation(country, min, max, cityInRange) )
                {
                    Console.WriteLine("No cities found in this range");
                }

            }
        }
        public bool FindByPopulation(Country country, int min, int max , bool Range )
        {
            foreach (City city in country.citiesOfCountry)
            {

                if (city.PopulationOfCity >= min && city.PopulationOfCity <= max)
                {
                    Range = true;
                    Console.WriteLine(city);
                }
            }
            return Range;
        }
    }
}
