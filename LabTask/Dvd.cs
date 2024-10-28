using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMenecmentSystem
{
    internal class Dvd : LibraryItem
    {
        public override string Title { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override DateTime? PublicationYear { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override void DisplayInfo()
        {
            throw new NotImplementedException();
        }
    }
}
