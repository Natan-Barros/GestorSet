using GS.Core.DomainObjects;

namespace GS.Core.Data
{
    public interface IRepository<T> : IDisposable where T : IAgregateRoot
    {
    }
}
