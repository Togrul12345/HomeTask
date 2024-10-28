using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMenecmentSystem
{
    internal class Librarian:Person
    {
        public Librarian[] librarians=new Librarian[0];
        public override string Name { get ; set ; }

        public DateTime HireDate { get; set; }
    }
}
