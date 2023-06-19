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
            Console.WriteLine(" 8. LINQ Employees");
            Console.WriteLine(" 9. LINQ Department");
            Console.WriteLine(" 10. Logout");
            try
            {
                Console.WriteLine("Pilih Menu : ");
                int pilihan = Convert.ToInt32(Console.Readline());
                switch (pilihan)
                {
                    case 1 : 

                }
            }

        }
    }
}