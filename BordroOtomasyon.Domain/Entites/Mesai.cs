using BordroOtomasyon.Domain.Core.BaseEntites;
using BordroOtomasyon.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BordroOtomasyon.Domain.Entites
{
    public class Mesai : AuditableEntity
    {
        public int Saat { get; set; }
        public double SaatlikUcret { get; set; }
        public KademeTipi Kademe { get; set; }
    }
}
