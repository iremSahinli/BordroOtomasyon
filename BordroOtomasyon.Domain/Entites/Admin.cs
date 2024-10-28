using BordroOtomasyon.Domain.Core.BaseEntites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BordroOtomasyon.Domain.Entites
{
    public class Admin : AuditableEntity
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public string IdentityId { get; set; }

    }
}
