namespace Domain
{
    public interface IPresenter<in T> where T : class
    {
        void Present(T source);
    }
}
