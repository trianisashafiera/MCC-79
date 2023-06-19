using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseConnectivity
{
    class MainMenu
    {
        public Region region = new Region();
        public Country country = new Country();
        public Location location = new Location();
        public Employee employee = new Employee();
        public Department department = new Department();
        public Job job = new Job();
        public History history = new History();

        public void Menu()
        {
            Console.Clear();
            this.CrudMenu();
        }

        void CrudMenu()
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
            Console.WriteLine(" 8. LINQ Employees");
            Console.WriteLine(" 9. LINQ Department");
            Console.WriteLine(" 10. Logout");
            Console.Write(" Pilih menu: ");
            try
            {
                var LINQ = new LINQ();
                int inputMenu = Convert.ToInt32(Console.ReadLine());
                switch (inputMenu)
                {
                    case 1:
                        this.CrudRegion();
                        break;
                    case 2:
                        this.CrudCountry();
                        break;
                    case 3:
                        Console.Clear();
                        this.PrintLocations();
                        Console.ReadKey();
                        this.CrudMenu();
                        break;
                    case 4:
                        Console.Clear();
                        this.PrintDepartments();
                        Console.ReadKey();
                        this.CrudMenu();
                        break;
                    case 5:
                        Console.Clear();
                        this.PrintEmployees();
                        Console.ReadKey();
                        this.CrudMenu();
                        break;
                    case 6:
                        Console.Clear();
                        this.PrintHistories();
                        Console.ReadKey();
                        this.CrudMenu();
                        break;
                    case 7:
                        Console.Clear();
                        this.PrintJobs();
                        Console.ReadKey();
                        this.CrudMenu();
                        break;
                    case 8:
                        Console.Clear();
                        Console.Write("Masukkan limit: ");
                        try
                        {
                            int limit = Convert.ToInt32(Console.ReadLine());
                            LINQ.GetEmployees(limit);
                            Console.ReadKey();
                            this.CrudMenu();
                            break;
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Silakan masukkan pilihan anda");
                            Console.ReadKey();
                            this.CrudMenu();
                        }

                        break;
                    case 9:
                        Console.Clear();
                        LINQ.GetDepartments();
                        Console.ReadKey();
                        this.CrudMenu();
                        break;
                    case 10:
                        Console.Clear();
                        Console.WriteLine("Anda telah logout");
                        Console.ReadKey();
                        this.CrudMenu();
                        break;
                    default:
                        Console.WriteLine("Invalid Input");
                        Console.ReadKey();
                        this.CrudMenu();
                        break;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Silakan masukkan pilihan anda");
                Console.ReadKey();
                this.CrudMenu();
            }
        }


        public void CrudRegion()
        {
            Console.Clear();
            Console.WriteLine("Region");
            Console.WriteLine(" 1. Create Region");
            Console.WriteLine(" 2. Show All Region");
            Console.WriteLine(" 3. Region By Id");
            Console.WriteLine(" 4. Update Region");
            Console.WriteLine(" 5. Delete Region");
            Console.WriteLine(" 6. Back");
            Console.Write(" Pilih menu: ");
            try
            {
                int inputMenu = Convert.ToInt32(Console.ReadLine());
                switch (inputMenu)
                {
                    case 1:
                        break;
                    case 2:
                        this.ShowRegions();
                        break;
                    case 3:
                        this.ShowRegionById();
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        this.CrudMenu();
                        break;
                    default:
                        Console.WriteLine("Invalid Input");
                        Console.ReadKey();
                        this.CrudRegion();
                        break;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Silakan masukkan pilihan anda");
                Console.ReadKey();
                this.CrudRegion();
            }
        }


        public void CrudCountry()
        {
            Console.Clear();
            Console.WriteLine("Country");
            Console.WriteLine(" 1. Create Country");
            Console.WriteLine(" 2. Show All Country");
            Console.WriteLine(" 3. Show Country By Id ");
            Console.WriteLine(" 4. Update Country");
            Console.WriteLine(" 5. Delete Country");
            Console.WriteLine(" 6. Back");
            Console.Write(" Pilih menu: ");
            try
            {
                int inputMenu = Convert.ToInt32(Console.ReadLine());
                switch (inputMenu)
                {
                    case 1:
                        break;
                    case 2:
                        this.ShowCoutries();
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        this.CrudMenu();
                        break;
                    default:
                        Console.WriteLine("Invalid Input");
                        Console.ReadKey();
                        this.CrudCountry();
                        break;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Silakan masukkan pilihan anda");
                Console.ReadKey();
                this.CrudCountry();
            }
        }


        public void ShowRegions()
        {
            region.GetAllRegions().ForEach(e => { Console.WriteLine($"id = {e.id}, name = {e.name}"); });
        }


        public void PrintRegionById(int id)
        {
            region.GetRegionById(id).ForEach(e => { Console.WriteLine($"id = {e.id}, name = {e.name}"); });
        }

        public void ShowRegionById()
        {
            Console.Clear();
            Console.WriteLine("Region By Id");
            Console.Write(" Masukkan id: ");
            try
            {
                int id = Convert.ToInt32(Console.ReadLine());
                this.PrintRegionById(id);
                Console.ReadKey();
                this.CrudRegion();
            }
            catch (Exception)
            {
                Console.WriteLine("Silakan masukkan pilihan anda");
                Console.ReadKey();
                this.CrudRegion();
            }
        }


        public void ShowCoutries()
        {
            country.GetAllCountries().ForEach(e =>
            {
                Console.WriteLine($"id = {e.id}");
                Console.WriteLine($"name = {e.name}");
                Console.WriteLine($"region id = {e.regionId}");
                Console.WriteLine();
            });
        }


        public void PrintCountryById(string id)
        {
            country.GetCountryById(id).ForEach(e =>
            {
                Console.WriteLine($"id = {e.id}");
                Console.WriteLine($"name = {e.name}");
                Console.WriteLine($"region id = {e.regionId}");
                Console.WriteLine();
            });
        }


        public void ShowCountryById()
        {
            Console.Clear();
            Console.WriteLine("Country By Id");
            Console.Write(" id: ");
            try
            {
                string id = Console.ReadLine();
                this.PrintCountryById(id);
                Console.ReadKey();
                this.CrudCountry();
            }
            catch (Exception)
            {
                Console.WriteLine("Silakan masukkan pilihan anda");
                Console.ReadKey();
                this.CrudCountry();
            }
        }


        public void PrintLocations()
        {
            location.GetAllLocations().ForEach(e =>
            {
                Console.WriteLine(
                    $"id = {e.id}, street address = {e.streetAddress}, postal code = {e.postalCode}, city = {e.city}, state province = {e.stateProvince}, country id = {e.countryId}");
            });
        }


        public void PrintDepartments()
        {
            department.GetAllDepartments().ForEach(e =>
            {
                Console.WriteLine(
                    $"id = {e.id}, name = {e.name}, location id = {e.locationId}, manager id = {e.managerId}, ");
            });
        }


        public void PrintEmployees()
        {
            employee.GetAllEmployees().ForEach(e =>
            {
                Console.WriteLine(
                    $"id = {e.id}, name = {e.firstName} {e.lastName}, email = {e.email}, phone number = {e.phoneNumber}, hire date = {e.hireDate}, salary = {e.salary}");
            });
        }


        public void PrintHistories()
        {
            history.GetAllHistories().ForEach(e =>
            {
                Console.WriteLine(
                    $"start date = {e.startDate}, end date = {e.endDate}, employee id = {e.employeeId}, department id = {e.departmentId}, job id = {e.jobId}");
            });
        }


        public void PrintJobs()
        {
            job.GetAllJobs().ForEach(e =>
            {
                Console.WriteLine(
                    $"id = {e.id}, title = {e.title}, min salary = {e.minSalary}, max salary = {e.maxSalary}");
            });
        }
    }
}