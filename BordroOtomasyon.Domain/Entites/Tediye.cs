using BordroOtomasyon.Domain.Core.BaseEntites;
using BordroOtomasyon.Domain.Enums;

namespace BordroOtomasyon.Domain.Entites
{
    public class Tediye : AuditableEntity
    {
        public KademeTipi Kademe { get; set; }
        public double Miktar { get; set; }
    }
}


