using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseConnectivity.Controllers
{
    public class LocationController
    {
        private Location _location = new Location();
        private LocationView _locationView = new LocationView();

        public void GetAll()
        {
            _locationView.All(_location.GetAll());
            Console.ReadKey();
            Console.Clear();
        }
    }
}
