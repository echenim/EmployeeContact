using System;
using System.Collections.Generic;
using System.Text;

namespace Portal.Business.Contracts.Base
{
   public interface IFind<T> where T:class
    {
        T find(Func<T, bool> predicate);
    }
}
