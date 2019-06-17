using Portal.Business.Contracts.Base;
using Portal.Domain.Models;
using Portal.Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Portal.Business.Contracts
{
   public  interface IPersonService:IGet<PersonViewModel>,ISave<PersonWriteViewModels>,
      IEdit<PersonWriteViewModels>, IFind<PersonWriteViewModels>,IDelete<PersonWriteViewModels>
    {
       
    }
}
