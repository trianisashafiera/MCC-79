using DatabaseConnectivity.Models;
using DatabaseConnectivity.Views;

namespace DatabaseConnectivity.Controllers
{
    public class EmployeeController
    {
        private Employee _employee = new Employee();
        private EmployeeView _employeeView = new EmployeeView();

        public void GetAll()
        {
            _employeeView.All(_employee.GetAll());
            Console.ReadKey();
            Console.Clear();
        }
    }
}