using BordroOtomasyon.Domain.Entites;
using BordroOtomasyon.Infrastructure.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BordroOtomasyon.Infrastructure.Repositories.KıyafetOdenegiRepositories
{
    public interface IKıyafetOdenegiRepository : IAsyncRepository, IRepository, IAsyncFindableRepository<KiyafetOdenegi>, IAsyncInsertableRepository<KiyafetOdenegi>, IAsyncQueryableRepository<KiyafetOdenegi>, IAsyncDeletableRepository<KiyafetOdenegi>, IAsyncUpdatebleRepository<KiyafetOdenegi>, IAsyncTransactionRepository, IAsyncOrderableRepository<KiyafetOdenegi>
    {
    }
}
