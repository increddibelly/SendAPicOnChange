using System.Collections.Generic;

namespace Domain
{
    public interface IControllableComparer<in T> : IComparer<T>
    {
        int Tolerance { get; set; }
        int Accuracy { get; set; }
    }
}
