using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMenecmentSystem
{
    sealed class LibraryMember:Person
    {
        

       
        public DateTime MembershipDate { get; set; }
      
        public override string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
