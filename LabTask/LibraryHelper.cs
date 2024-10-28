using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMenecmentSystem
{
    public static class LibraryHelper
    {
      

        public static void CalculateAge(this LibraryItem item)
        {
            int age = DateTime.Now.Year - item.PublicationYear.Value.Year;
            Console.WriteLine($"age is {age}");
        }
      public static void  ToTitleCase(this LibraryItem item)
        {
            item.Title = "Correct Name";
        }

    }
}
