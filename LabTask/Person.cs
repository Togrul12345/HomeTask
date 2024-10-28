
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMenecmentSystem
{
    abstract class Person
    {
        public static int _count=-1;
       public  int _Id;
        public abstract string Name { get; set; }
        protected Person()
        {
            _count++;
            _Id = _count;
        }

    }
}
