using Portal.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Portal.Business.Contracts.Base
{
    public interface ISave<T> where T:class
    {
        Notifications Save(T entity);
    }
}
