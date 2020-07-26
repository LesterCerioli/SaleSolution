using System.Threading.Tasks;
using SaleSolution.SharedKernel;

namespace SaleSolution.SharedKernel.Interfaces
{
    public interface IHandle<in T> where T : BaseDomainEvent
    {
        Task Handle(T domainEvent);
    }
}