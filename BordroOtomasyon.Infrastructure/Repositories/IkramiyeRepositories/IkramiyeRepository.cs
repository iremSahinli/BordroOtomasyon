using BordroOtomasyon.Domain.Entites;
using BordroOtomasyon.Infrastructure.DataAccess.EntityFramework;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BordroOtomasyon.Infrastructure.Repositories.IkramiyeRepositories
{
    public class IkramiyeRepository : EFBaseRepository<Ikramiye>, IIkramiyeRepository
    {
        public IkramiyeRepository(DbContext context) : base(context)
        {
        }
    }
}
