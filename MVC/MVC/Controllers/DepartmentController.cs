using DatabaseConnectivity.Models;
using DatabaseConnectivity.Views;

namespace DatabaseConnectivity.Controllers
{
    public class DepartmentController
    {
        private Department _department = new Department();
        private DepartmentView _departmentView = new DepartmentView();

        public void GetAll()
        {
            _departmentView.All(_department.GetAll());
            Console.ReadKey();
            Console.Clear();
        }
    }
}