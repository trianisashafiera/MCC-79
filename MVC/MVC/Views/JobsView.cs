using DatabaseConnectivity.Models;

namespace DatabaseConnectivity.Views
{

    public class jobsView
    {
        public void GetAll(list<Job> jobs)
        {
            foreach(Jobs job in jobs)
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
