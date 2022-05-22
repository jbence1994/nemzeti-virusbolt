using System.Threading.Tasks;

namespace NemzetiVirusbolt.Core
{
    public interface IUnitOfWork
    {
        Task CompleteAsync();
    }
}
