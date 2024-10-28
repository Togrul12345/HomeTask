using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMenecmentSystem
{
    internal class Book : LibraryItem
        
    {
       
        public string LibraryLocation { get; set; }
        public string Janre { get; set; }
        public override string Title { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override DateTime? PublicationYear { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override void DisplayInfo()
        {
            throw new NotImplementedException();
        }
    }
}
