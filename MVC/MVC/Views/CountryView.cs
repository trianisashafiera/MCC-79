using DatabaseConnectivity.Models;

namespace DatabaseConnectivity.View
{
    public class CountryView
    {
        public void GetAll(List<Country> countries)
        {
            foreach (Country country in countries)
            {
                GetAll(country);
            }
        }
        public void GetById(Country country)
        {
            Console.WriteLine("Id : " + country.Id);
            Console.WriteLine("Name : " + country.Name);
            Console.WriteLine("Region Id : " + country.regionId);
            Console.WriteLine();
        }
        public void NotFound()
        {
            Console.WriteLine("Data Not Found");
        }
    }