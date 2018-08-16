using System.Threading.Tasks;

namespace Domain
{
    public interface IInputProvider<T> where T : class
    {
        void Initialize();
        void Stop();
        Task<T> Get();
    }
}