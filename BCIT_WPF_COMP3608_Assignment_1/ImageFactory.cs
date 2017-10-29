using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCIT_WPF_COMP3608_Assignment_1
{
    public class ImageFactory
    {
        public static int count = 0;

        private static Images _myImages = new Images();

        public Images MyImages
        {
            get
            {
                return _myImages;
            }
        }
    }
}
