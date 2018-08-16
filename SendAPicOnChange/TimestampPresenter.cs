using System;
using System.Drawing;
using System.Windows.Forms;
using Domain;

namespace SendAPicOnChange
{
    public class TimestampPresenter : IPresenter<Bitmap>, IControlContentProvider
    {
        public string Tag { get; set; } = MainWindow.TagForTimestamp;

        public void Present(Bitmap source)
        {
            if (Control == null) return;
            Control.Text = DateTime.Now.ToLongTimeString();
        }

        public Control Control { get; set; }
    }
}
