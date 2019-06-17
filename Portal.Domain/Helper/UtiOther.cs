
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Portal.Domain.Helper
{
    public static class UtiOther
    {
        public static string GetCallerMemberName([CallerMemberName]string name = "")
        {
            return name;
        }

        public static string GetControllerName(ControllerContext _context)
        {

            return _context.RouteData.Values["controller"].ToString();
        }
    }
}
