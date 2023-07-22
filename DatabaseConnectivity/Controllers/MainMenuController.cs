using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseConnectivity.Controllers
{
    public class MainMenuController
    {
        public void MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Menu");
            Console.WriteLine(" 1. Region");
            Console.WriteLine(" 2. Country");
            Console.WriteLine(" 3. Location");
            Console.WriteLine(" 4. Deparment");
            Console.WriteLine(" 5. Employee");
            Console.WriteLine(" 6. History");
            Console.WriteLine(" 7. Job");
/*            Console.WriteLine(" 8. LINQ Employees");
            Console.WriteLine(" 9. LINQ Department");*/
            Console.WriteLine(" 10. Logout");
            try
            {
                Console.WriteLine("Pilih Menu : ");
                int pilihan = Convert.ToInt32(Console.Readline());
                switch (pilihan)
                {
                    case 1:
                        Console.Clear();
                        new RegionController.Menu();
                        break;
                    case 2:
                        Console.Clear();
                        new CountryController.Menu();
                        break;
                    case 3:
                        Console.Clear();
                        new LocationController.Menu();
                        break;
                    case 4:
                        Console.Clear();
                        new DepartmentController.Menu();
                        break;
                    case 5:
                        Console.Clear();
                        new EmployeeController.Menu();
                        break;
                    case 6:
                        Console.Clear();
                        new HistoryController.Menu();
                        break;
                    case 7:
                        Console.Clear();
                        new JobController.Menu();
                        break;
   /*                 case 8:
                        Console.Clear();
                        new LINQController.Menu();
                        break;
                    case 9:
                        Console.Clear();
                        new LINQ.getDepartments();*/
                        break;
                    default:
                        Console.WriteLine("Invalid Input");
                        break;
                }
                Console.ReadKey();
                MainMenu();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
