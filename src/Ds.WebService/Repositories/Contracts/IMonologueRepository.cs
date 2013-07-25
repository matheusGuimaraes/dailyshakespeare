using Ds.Model;

namespace Ds.WebService.Repositories.Contracts
{
    public interface IMonologueRepository
    {
        Monologue GetRandom();
    }
}