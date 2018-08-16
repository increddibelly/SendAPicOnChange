using System.Windows.Forms;

namespace SendAPicOnChange
{
    public interface IControlContentProvider
    {
        string Tag { get; set; }

        Control Control { get; set; }
    }
}
