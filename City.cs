using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class City
    {
        public string NameOfCity;
        public int PopulationOfCity;
        

        public City(string nameofcity, int population, Country country)
        {
            NameOfCity = nameofcity;
            PopulationOfCity = population;
            country.TotalPopulationOfCountry = country.TotalPopulationOfCountry + population;
            Array.Resize(ref country.citiesOfCountry, country.citiesOfCountry.Length + 1);
            country.citiesOfCountry[country.citiesOfCountry.Length - 1] = this;
        }

        public override string ToString()
        {
            return "\nCity: " + NameOfCity + "\nPopulation: " + PopulationOfCity;
        }

        //public static void FindAllByPopulation(int min, int max)
        //{

        //    foreach (City city in citiesOfCountry)
        //    {
        //        Console.WriteLine(NameOfCity);
        //    }

        //    //int k = 0;
        //    //foreach (City city in citiesOfCountry)
        //    //{
        //    //    Console.WriteLine("This city settles in " + Country.NameOfCountry + " and Population of Country: " + Country.TotalPopulationOfCountry);

        //    //    if (PopulationOfCity >= min && PopulationOfCity <= max)
        //    //    {
        //    //        k++;
        //    //        Console.WriteLine("City: " + NameOfCity + " Population: " + PopulationOfCity);
        //    //    }
        //    //}
        //    //if (k == 0)
        //    //{
        //    //    Console.WriteLine("No city found in this range");
        //    //}
        //}

    }
}
