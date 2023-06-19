using DatabaseConnectivity.Models;
using DatabaseConnectivity.Views;

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