using Portal.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Portal.Business.Contracts.Base
{
   public interface IDelete<T> where T:class
    {
        Notifications Delete(T entity);
    }
}
