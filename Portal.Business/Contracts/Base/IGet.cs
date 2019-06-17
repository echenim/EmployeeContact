using Portal.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Portal.Business.Contracts.Base
{
    public interface IGet<T> where T:class
    {
        IQueryable<T> Get(Func<T, bool> predicate=null);
    }
}
