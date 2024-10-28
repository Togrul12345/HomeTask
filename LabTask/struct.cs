using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMenecmentSystem
{
    struct LibraryLocation
    {
        public int _aisle;

        public int _shelf;

        public LibraryLocation(int aisle,int shelf)
        {
            this._aisle = aisle;
            this._shelf = shelf;
        }
    }
}
