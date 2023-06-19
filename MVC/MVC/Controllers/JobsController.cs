using DatabaseConnectivity.Models;
using DatabaseConnectivity.Views;

namespace DatabaseConnectivity.Controllers
{
    public class JobsController
    {
        private Jobs _jobs = new Jobs();
        private JobView _jobsView = new JobsView();

        public void GetAll()
        {
            _jobsView.All(_jobs.GetAll());
            Console.ReadKey();
            Console.Clear();
        }
    }
}