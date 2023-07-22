using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DatabaseConnectivity.Views
{
    public class DepartmentView
    {
        public void GetAll(List<Department> departments)
        {
            foreach (Department department in departments)
            {
                Console.WriteLine("id : " + department.Id);
                Console.WriteLine("Department Name : " + department.Name);
                Console.WriteLine("Location Id : " + department.locationId);
                Console.WriteLine("Manager Id : " + department.managerId);
                Console.WriteLine();
            }
        }
    }
}
