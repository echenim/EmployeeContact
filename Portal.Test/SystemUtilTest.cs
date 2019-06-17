using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Portal.Controllers;
using Portal.Domain.Helper;

namespace Portal.Test
{
   public class SystemUtilTest
    {
        [Fact]

        public void CheckIfFunctionReturnsControllersName()
        {
            HomeController home = new HomeController();
            var result = UtiOther.GetControllerName(home.ControllerContext);
            Assert.Equal("Home", result);
        }
    }
}
