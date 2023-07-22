using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseConnectivity.Views
{
    public class JobView
    {
        public void GetAll(list<Job> jobs)
        {
            foreach (Job job in jobs)
            {
                Console.Writeline("Id : " + job.Id);
                Console.Writeline("Title : " + job.Title);
                Console.Writeline("Min Salary : " + job.minSalary);
                Console.Writeline("Max Salary : " + job.maxSalary);
                Console.Writeline();
            }

        }
    }
}
