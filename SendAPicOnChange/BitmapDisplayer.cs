using System.Drawing;
using System.Windows.Forms;
using Domain;

namespace SendAPicOnChange
{
    internal class BitmapDisplayer : IPresenter<Bitmap>, IControlContentProvider
    {
        public string Tag { get; set; } = MainWindow.TagForBitmapPictureBox;
        public Control Control { get; set; }

        public void Present(Bitmap source)
        {
            if (Control == null) return;
            Control.BackgroundImage = source;
            Control.Invalidate();
        }
    }
}
