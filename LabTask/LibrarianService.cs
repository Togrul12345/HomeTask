using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMenecmentSystem
{
    internal class LibrarianService : Librarian, ILibrarianService
    {
        public void CreateLibrarian(Librarian librarian)
        {
           
            
           
            Array.Resize(ref librarians, librarians.Length + 1);
            librarians[librarians.Length-1] = librarian;

        }

        public void DeleteLibrarian(Librarian librarian, bool IsSoftDelete)
        {
            if (IsSoftDelete)
            {
                for(int i = 0; i < librarians.Length; i++)
                {
                    if (librarian._Id == librarians[i]._Id)
                    {
                        Console.WriteLine($"{librarians[i].Name} silindi");
                        librarians[i] = null;
                        break;
                    }
                }
                Console.WriteLine("librarian tapilmadi");
            }
           
           
        }

      

        public Librarian GetLibrarianById(int id)
        {
           for( int i = 0; i < librarians.Length; i++)
            {
                if (librarians[i]._Id == id)
                {
                    return librarians[i];
                }
            }
            return default;
        }

        public Librarian[] GetAllLibrarians()
        {
            return librarians;
        }

        
    }
}
