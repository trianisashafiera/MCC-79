using DatabaseConnection.Models;

namespace DatabaseConnectivity.Views
{
    public class RegionView
    {
        public void GetAll(List<Region> regions)
        {
            foreach (Region region in regions)
            {
                GetById(Region);
            }
        }
        public void GetById(Region region)
        {
            Console.WriteLine("Id : " + region.Id);
            Console.WriteLine("Name : " + region.Name);
            Console.WriteLine();
        }
        public void NotFound()
        {
            Console.WriteLine("Data Not Found");
        }
    }
}