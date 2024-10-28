using BordroOtomasyon.Domain.Core.BaseEntites;
using BordroOtomasyon.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BordroOtomasyon.Domain.Entites
{
    public class KiyafetOdenegi : AuditableEntity
    {
        public double OdenekMiktar { get; set; }
        public KademeTipi Kademe { get; set; }
    }
}
