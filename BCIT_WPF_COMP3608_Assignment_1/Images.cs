using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCIT_WPF_COMP3608_Assignment_1
{
    public class Images : ObservableCollection<ImageData>
    {
        public Images()
        {
            this.Add(new ImageData(@"Resources\Images\1.jpg"));
            this.Add(new ImageData(@"Resources\Images\2.jpg"));
            this.Add(new ImageData(@"Resources\Images\3.jpg"));
        }
    }
}
