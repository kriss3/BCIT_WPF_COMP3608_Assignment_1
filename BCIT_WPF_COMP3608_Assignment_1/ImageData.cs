using System.ComponentModel;

namespace BCIT_WPF_COMP3608_Assignment_1
{
    /// <summary>
    /// Class providing access to event notication on changes to the observable collection;
    /// </summary>
    public class ImageData : INotifyPropertyChanged
    {
        private string _sImageName = string.Empty;
        public ImageData(string sImageName)
        {
            ImageFactory.count++;
            _sImageName = sImageName;
        }

        public string ImageName
        {
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
