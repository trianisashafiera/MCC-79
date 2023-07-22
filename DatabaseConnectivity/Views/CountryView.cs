using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseConnectivity.Models;
using DatabaseConnectivity.Controllers;


namespace DatabaseConnectivity.Views
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
}
