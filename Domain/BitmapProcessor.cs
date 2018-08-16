using System.Drawing;
using System.Threading.Tasks;

namespace Domain
{
    public class BitmapProcessor : IProcessor<Bitmap>
    {
        private readonly IChangeDetector<Bitmap> _changeDetector;
        private readonly IInputProvider<Bitmap> _inputProvider;

        public BitmapProcessor(
            IChangeDetector<Bitmap> changeDetector, 
            IInputProvider<Bitmap> inputProvider)
        {
            _changeDetector = changeDetector;
            _inputProvider = inputProvider;
        }

        public async Task<Bitmap> CheckInput()
        {
            var input = await _inputProvider.Get();

            var hasChanged = _changeDetector.HasChanged(input);
            if (hasChanged) 
                return input;

            return null;
        }

        public void SetTolerance(int tolerance)
        {
            _changeDetector.Tolerance = tolerance;
        }

        public void SetAccuracy(int accuracy)
        {
            _changeDetector.Accuracy = accuracy;
        }
    }
}
