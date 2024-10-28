using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMenecmentSystem
{
    public class LibraryCatalog
    {
        public string[] arr = { "Cinayət və cəza", "Qürur və qərəz", "Yad", "Anna Karenina" };
        public string this[int Id]
        {
            get { return arr[Id]; }
            set
            {
                if (Id < 1 && Id > arr.Length)
                {
                    throw new CustomBookException("Daxil edilən Id-ə sahib kitabın catalog-da yer almadığı mesajı verməlidir.");
                }
                arr[Id] = value;
            }
            
        }
    }
}

