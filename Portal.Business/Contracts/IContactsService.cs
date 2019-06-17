using Portal.Business.Contracts.Base;
using Portal.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Portal.Business.Contracts
{
   public interface IContactsService: ISave<Contacts>,IEdit<Contacts>,IDelete<Contacts>
    {
    }
}
