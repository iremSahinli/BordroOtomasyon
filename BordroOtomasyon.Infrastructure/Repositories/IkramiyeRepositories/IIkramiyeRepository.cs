using BordroOtomasyon.Domain.Entites;
using BordroOtomasyon.Infrastructure.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BordroOtomasyon.Infrastructure.Repositories.IkramiyeRepositories
{
    public interface IIkramiyeRepository : IAsyncRepository, IRepository, IAsyncFindableRepository<Ikramiye>, IAsyncInsertableRepository<Ikramiye>, IAsyncQueryableRepository<Ikramiye>, IAsyncDeletableRepository<Ikramiye>, IAsyncUpdatebleRepository<Ikramiye>, IAsyncTransactionRepository, IAsyncOrderableRepository<Ikramiye>
    {
    }
}
