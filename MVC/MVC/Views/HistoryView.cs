using DatabaseConnectivity.Models;

namespace DatabaseConnectivity.Views
{

    public class HistoryView
    {
        public void GetAll(List<History> histories )
        {
            foreach (History history in histories)
            {
                Console.WriteLine( "Start Date : " + history.startDate );
                Console.WriteLine("Employee Id : " + history.employeeId);
                Console.WriteLine("End Date : " + history.endDate);
                Console.WriteLine("Department Id : " + history.departmentId);
                Console.WriteLine("Job Id : " + history.jobId);
                Console.WriteLine();
            }
        }
    }
}