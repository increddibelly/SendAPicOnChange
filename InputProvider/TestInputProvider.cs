using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using Domain;

namespace InputProvider
{
    public class TestInputProvider : IInputProvider<Bitmap>
    {
        private Bitmap one;
        private Bitmap two;
        private int count;

        public void Initialize()
        {
            one = new Bitmap(GetResource("autobot small.png"));
            two = new Bitmap(GetResource("autobot small diff.png"));
        }

        public void Stop()
        {
            one?.Dispose();
            two?.Dispose();
        }

        public Task<Bitmap> Get()
        {
            return Task.FromResult(++count % 2 == 0 ? two : one);
        }

        public Stream GetResource(string name)
        {
            var namespaceName = "InputProvider";
            var resource = namespaceName + "." + name;
            var type = typeof(TestInputProvider);
            return type.Assembly.GetManifestResourceStream(resource);
        }
    }
}
