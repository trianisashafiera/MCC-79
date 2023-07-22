using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseConnectivity.Views
{
    public class LocationView
    {
        public void GetAll(List<Location> locations)
        {
            foreach (Location location in locations)
            {
                Console.WriteLine("Id : " + location.Id);
                Console.WriteLine("Street Address : " + location.streetAddress);
                Console.WriteLine("Postal Code : " + location.postalCode);
                Console.WriteLine("City : " + location.city);
                Console.WriteLine("state Province : " + location.stateProvince);
                Console.WriteLine("Country Id : " + location.countryId);
                Console.WriteLine();
            }
        }
    }
}
