using JCMS.Repository.Repositories.Interfaces;

namespace JCMS.Repository.Repositories.Repository
{
    public class AccountRepository : RepositoryBase, IAccountRepository
    {
        public AccountRepository(IConnectionFactory connectionFactory) : base(connectionFactory)
        {

        }
    }
}
