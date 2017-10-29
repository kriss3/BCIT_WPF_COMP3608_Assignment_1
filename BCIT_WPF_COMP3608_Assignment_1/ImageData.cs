using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCIT_WPF_COMP3608_Assignment_1
{
    public class ImageData : INotifyPropertyChanged
    {
        private string _sImageName = string.Empty;
        public ImageData(string sImageName)
        {
            ImageFactory.count++;
            _sImageName = sImageName;
        }

        public string ImageName {
            get
            {
                return _sImageName;
            }
            set
            {
                _sImageName = value;
                
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;
        protected void NotifyPropertyChanged(string sProp)
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(sProp));
            }
        }


    }
}
