using Portal.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Portal.Business.Contracts.Base
{
    public interface IEdit<T> where T:class
    {
        Notifications Edit(T entity);
    }
}
