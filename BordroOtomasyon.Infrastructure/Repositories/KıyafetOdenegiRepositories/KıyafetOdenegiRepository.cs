using BordroOtomasyon.Domain.Entites;
using BordroOtomasyon.Infrastructure.DataAccess.EntityFramework;
using Microsoft.EntityFrameworkCore;


namespace BordroOtomasyon.Infrastructure.Repositories.KıyafetOdenegiRepositories
{
    public class KıyafetOdenegiRepository : EFBaseRepository<KiyafetOdenegi>, IKıyafetOdenegiRepository
    {
        public KıyafetOdenegiRepository(DbContext context) : base(context)
        {
        }
    }
}
