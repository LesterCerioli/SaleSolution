using System.Threading.Tasks;
using SaleSolution.SharedKernel.Interfaces;
using SaleSolution.SharedKernel;

namespace SaleSolution.UnitTests
{
    public class NoOpDomainEventDispatcher : IDomainEventDispatcher
    {
        public Task Dispatch(BaseDomainEvent domainEvent)
        {
            return Task.CompletedTask;
        }
    }
}
