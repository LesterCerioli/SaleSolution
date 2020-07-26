using System.Threading.Tasks;
using SaleSolution.SharedKernel;

namespace SaleSolution.SharedKernel.Interfaces
{
    public interface IDomainEventDispatcher
    {
        Task Dispatch(BaseDomainEvent domainEvent);
    }
}