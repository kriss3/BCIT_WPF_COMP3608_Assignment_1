using System.Collections.ObjectModel;

namespace BCIT_WPF_COMP3608_Assignment_1
{
    /// <summary>
    /// Resource class; provides access to local images;
    /// [Question: in real life, would this be the place to add call into DataLayer
    /// or call to the service returning data requested?]
    /// </summary>
    public class Images : ObservableCollection<ImageData>
    {
        public Images()
        {
            this.Add(new ImageData(@"Resources\Images\1.jpg"));
            this.Add(new ImageData(@"Resources\Images\2.jpg"));
            this.Add(new ImageData(@"Resources\Images\3.jpg"));
            this.Add(new ImageData(@"Resources\Images\4.jpg"));
            this.Add(new ImageData(@"Resources\Images\5.jpg"));
        }
    }
}
