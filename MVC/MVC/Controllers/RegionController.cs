using DatabaseConnectivity.Models;
using DatabaseConnectivity.Views;

namespace DatabaseConnectivity.Controllers
{
    public class RegionController
    {
        private Region _region = new Region();
        private RegionView _regionView = new RegionView();

        public void Menu()
        {
            bool isFinish = true;
            do
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
                    Console.Write("Select Menu : ");
                    int pilih = int.Parse(Console.ReadLine());
                    switch (pilih)
                    {
                        case 1:
                            Console.Clear();
                            Create();
                            break;
                        case 2:
                            Console.Clear();
                            GetAll();
                            break;
                        case 3:
                            Console.Clear()
                            GetById();
                            break;
                        case 4:
                            Console.Clear();
                            Update();
                            break;
                        case 5:
                            Console.Clear();
                            Delete();
                            break;
                        case 6:
                            isFinish = false;
                            break;
                        default:
                            Console.WriteLine("Invalid Input");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            } while (isFinish);
        }
        public void Create()
        {
            Console Write("Create Region");
            string name = Console.ReadLine();
            int isInsertSuccessful = _region.Insert(name);
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
            Console Write("Show All Region");
            _regionView.All(_region.GetAll());
            Console.ReadKey();
            Console.Clear();
        }
        public void GetById()
        {
            Console.Write("Get Region By ID : ");
            int id = int.Parse(Console.ReadLine());

            var region = _region.GetByID(id);

            if (region == null)
            {
                _regionView.NotFound();
            }
            else
            {
                _regionView.GetById(region);
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

            int updateResult = _region.Update(id, newName);
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

            int deleteResult = _region.Delete(id);
            if (deleteResult > 0)
            {
                Console.WriteLine("Data berhasil dihapus");
            }
            else
            {
                Console.WriteLine("Data gagal dihapus");
            }

            Console.ReadKey();
        }
    }
}
