using Domain;

namespace ChangeDetector
{
    public class ChangeDetector<T> : IChangeDetector<T> where T : class
    {
        private T _last;

        private readonly IControllableComparer<T> _comparer;

        public ChangeDetector(
            IControllableComparer<T> tcomparer)
        {
            _comparer = tcomparer;
        }

        public bool HasChanged(T input)
        {
            if (input == null) return false;
            var result = _comparer.Compare(_last, input) != 0;

            _last = input;
            return result;
        }
        
        public int Tolerance
        {
            get => _comparer.Tolerance;
            set => _comparer.Tolerance = value;
        }

        public int Accuracy
        {
            get => _comparer.Accuracy;
            set => _comparer.Accuracy = value;
        }
    }
}
