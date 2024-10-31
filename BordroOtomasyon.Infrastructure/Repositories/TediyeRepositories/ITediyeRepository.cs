using BordroOtomasyon.Domain.Entites;
using BordroOtomasyon.Infrastructure.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BordroOtomasyon.Infrastructure.Repositories.TediyeRepositories
{
    public interface ITediyeRepository : IAsyncRepository, IRepository, IAsyncFindableRepository<Tediye>,IAsyncInsertableRepository<Tediye>, IAsyncQueryableRepository<Tediye>, IAsyncDeletableRepository<Tediye>, IAsyncUpdatebleRepository<Tediye>, IAsyncTransactionRepository, IAsyncOrderableRepository<Tediye>
    {
    }
}
