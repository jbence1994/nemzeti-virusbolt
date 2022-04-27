using System.Threading.Tasks;

namespace NemzetiVirusbolt.Api.Core
{
    public interface IUnitOfWork
    {
        Task CompleteAsync();
    }
}
