using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseConnectivity.Models;
using DatabaseConnectivity.Views;

namespace DatabaseConnectivity.Controllers
{
    public class CountryController
    {
        private Country _country = new Country();
        private CountryView _countryView = new CountryView();

        public void Menu()
        {
            bool isFinish = true;
            do
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
                    Console.Write("Pilih : ");
                    string? pilih = Console.ReadLine();
                    switch (pilih)
                    {
                        case "1":
                            Console.Clear();
                            Create();
                            break;
                        case "2":
                            Console.Clear();
                            GetAll();
                            break;
                        case "3":
                            GetById();
                            break;
                        case "4":
                            Update();
                            break;
                        case "5":
                            Delete();
                            break;
                        case "6":
                            isFinish = false;
                            break;
                        default:
                            Console.WriteLine("Invalid Input");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            } while (isFinish);
        }
        public void Create()
        {
            Console.Write("Masukkan nama country :");
            string name = Console.ReadLine();
            int isInsertSuccessful = _country.Insert(name);
            if (isInsertSuccessful > 0)
            {
                Console.WriteLine("Data added successfully");
            }
            else
            {
                Console.WriteLine("Data failed to add");
            }

            Console.ReadKey();
        }
        public void GetAll()
        {
            Console.Write("Show All Country : ");
            _countryView.All(_country.GetAll());
            Console.ReadKey();
            Console.Clear();
        }
        public void GetById()
        {
            Console.Write("Get Country By ID : ");
            int id = int.Parse(Console.ReadLine());

            var country = _country.GetByID(id);

            if (country == null)
            {
                _countryView.NotFound();
            }
            else
            {
                _countryView.GetById(region);
            }

            Console.ReadKey();
            Console.Clear();
        }
        public void Update()
        {
            Console.Write("Masukkan ID Region: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Masukkan Nama Region: ");
            string newName = Console.ReadLine();

            int updateResult = _country.Update(id, newName);
            if (updateResult > 0)
            {
                Console.WriteLine("Data updated successfully");
            }
            else
            {
                Console.WriteLine("Failed to update data");
            }

            Console.ReadKey();
        }
        public void Delete()
        {
            Console.Write("Masukkan ID region yang mau dihapus: ");
            int id = int.Parse(Console.ReadLine());

            int deleteResult = _country.Delete(id);
            if (deleteResult > 0)
            {
                Console.WriteLine("Data deleted successfully");
            }
            else
            {
                Console.WriteLine("Failed to delete data");
            }

            Console.ReadKey();
        }
    }
}
