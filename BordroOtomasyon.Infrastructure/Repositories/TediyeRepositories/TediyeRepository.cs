using BordroOtomasyon.Domain.Entites;
using BordroOtomasyon.Infrastructure.Context;
using BordroOtomasyon.Infrastructure.DataAccess.EntityFramework;


namespace BordroOtomasyon.Infrastructure.Repositories.TediyeRepositories
{
    public class TediyeRepository : EFBaseRepository<Tediye>, ITediyeRepository
    {
        public TediyeRepository(AppDbContext context) : base(context) { }
    }
}
