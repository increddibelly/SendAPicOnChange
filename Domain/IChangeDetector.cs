namespace Domain
{
    public interface IChangeDetector<in T>
    {
        bool HasChanged(T input);
        int Tolerance { get; set; }
        int Accuracy { get; set; }
    }
}