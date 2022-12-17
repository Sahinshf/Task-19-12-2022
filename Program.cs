using System.Reflection.Emit;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Argentina 
            Country Argentina = new Country("Argentina");
            City BuenosAires = new City("BuenosAires", 15370000, Argentina);
            City Rosario = new City("Rosario ( Leo ) ", 1554000, Argentina);
            City Mendoza = new City("Mendoza", 1191000, Argentina);
            City Salta = new City("Salta", 708000, Argentina);

            //Czech Republic
            Country CzechRepublic = new Country("Czechia");
            City Prague = new City("Prague", 1275406, CzechRepublic);
            City Liberec = new City("Liberec", 100000, CzechRepublic);

            //Spain
            Country Spain = new Country("Spain");
            City Barcelona = new City("Barcelona", 1454000, Spain);
            City Valencia = new City("Valencia", 736000, Spain);
            City Sevilla = new City("Sevilla", 695000, Spain);

            //France
            Country France = new Country("France");
            City Paris = new City("Paris", 2138551, France);
            City Marseille = new City("Marseille", 794811, France);
            City Lyon = new City("Lyon", 472317, France);

            Range:

            Console.WriteLine("Enter Min Value of Range");
            bool minRange = int.TryParse(Console.ReadLine(), out int min);

            Console.WriteLine("Enter max Value of Range");
            bool maxRange = int.TryParse(Console.ReadLine(), out int max);

            if (minRange && maxRange)
            {
                Country.FindAllByPopulation(min, max);
            }
            else
            {
                Console.WriteLine("\n!! Enter valid Range !! ");
                goto Range;
            }


            //CzechRepublic.FindAllByPopulation(min, max);

        }
    }
}