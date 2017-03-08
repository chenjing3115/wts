using Microsoft.VisualStudio.TestTools.UnitTesting;
using BlueWTSLib.Service.Implement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BlueWTSLibTests.Properties;

namespace BlueWTSLib.Service.Implement.Tests
{
    [TestClass()]
    public class UserServiceTests
    {
        [TestMethod()]
        public void FindByIdTest()
        {
            var u = new UserService(Settings.Default.db).FindById(1);
            Assert.IsNotNull(u);
        }

        [TestMethod()]
        public void AllTest() {

        }
    }
}