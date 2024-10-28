using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BordroOtomasyon.Domain.Utilites.Interfaces
{
    public interface IDataResult<T> : IResult where T : class
    {
        public T? Data { get; }
    }
}
