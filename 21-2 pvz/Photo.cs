using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_2_pvz
{
    class Photo
    {

        public delegate void PhotoFilterDelegate();


        public void ApplyFilter(PhotoFilterDelegate photoFilter)

        {
            photoFilter();
        }
    }
}
