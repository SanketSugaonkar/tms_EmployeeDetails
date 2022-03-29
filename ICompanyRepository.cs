using WebApplication1.Entites;

namespace WebApplication1.Contracts
{
    public interface ICompanyRepository
    {
        public Task<IEnumerable<Company>> GetCompanies();
    }
}
