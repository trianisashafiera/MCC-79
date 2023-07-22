using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseConnectivity.Views
{
    public class EmployeeView
    {
        public void GetAll(list<Employee> employees)
        {
            foreach (Employee employee in employees)
            {
                Console.WriteLine("Id : " + employee.Id);
                Console.WriteLine("Name : " + employee.firstName + " " + employee.lastName);
                Console.WriteLine("Email : " + employee.email);
                Console.WriteLine("Password : " + employee.password);
                Console.WriteLine("Phone Number : " + employee.phoneNumber);
                Console.WriteLine("Hire Date : " + employee.hireDate);
                Console.WriteLine("Salary : " + employee.salary);
                Console.WriteLine("Commision Pct : " + employee.commisionPct);
                Console.WriteLine("Manager Id : " + employee.managerId);
                Console.WriteLine("Job Id : " + employee.jobId);
                Console.WriteLine("Department Id : " + employee.departmentId);
            }
        }
    }
}
