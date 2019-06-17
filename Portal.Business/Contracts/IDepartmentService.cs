using Portal.Business.Contracts.Base;
using Portal.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Portal.Business.Contracts
{
    public interface IDepartmentService:IGet<Departments>,ISave<Departments>,
        IEdit<Departments>, IFind<Departments>,IDelete<Departments>
    {
    }
}
