namespace LibraryMenecmentSystem
{
    internal class Program
    {
        static void Main(string[] args)

        {
            LibrarianService librarianService = new LibrarianService();

            while (true)
            {

                Librarian librarian = new Librarian();
                Console.WriteLine("Create Librarian");
                Console.WriteLine("Add Name");
                librarian.Name = Console.ReadLine();
                Console.WriteLine("Add date time");
                librarian.HireDate = Convert.ToDateTime(Console.ReadLine());


                librarianService.CreateLibrarian(librarian);
                Console.WriteLine("do you want to continue? Yes/No");
                string option = Console.ReadLine();
                if (option == "yes")
                {
                    continue;
                }
                else
                {
                    break;
                }
            }
            while (true)
            {
                Console.WriteLine("Get librarian by id");
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine(librarianService.GetLibrarianById(id).Name);  
                break;
            }
            while (true)
            {

                Console.WriteLine("Delete librarian");
                Console.WriteLine("Enter librarian id");
                int id = int.Parse(Console.ReadLine());


                Console.WriteLine("IzsoftDelete?");
                bool option = Convert.ToBoolean(Console.ReadLine());
                librarianService.DeleteLibrarian(librarianService.GetLibrarianById(id), option);
                break;
            }
            while (true)
            {
                librarianService.GetAllLibrarians();
                break;

            }
            LibraryCatalog libraryCatalog = new LibraryCatalog();
            Console.WriteLine(libraryCatalog[2]); 



        }
    }
}
