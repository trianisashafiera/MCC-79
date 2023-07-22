using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseConnectivity.Controllers
{
    public class JobController
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
