/// <summary>
/// Name: Krzysztof Szczurowski
/// Course: BCIT - COM3608
/// Repo:https://github.com/kriss3/BCIT_WPF_COMP3608_Assignment_1.git
/// </summary>
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
