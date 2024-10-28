using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMenecmentSystem
{
    public abstract class LibraryItem
    {
        public abstract string Title { get; set; }
        public abstract  DateTime? PublicationYear { get; set; }
        public abstract void DisplayInfo();
    }
}
