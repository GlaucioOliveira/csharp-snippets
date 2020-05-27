using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTestProject.PrimitiveTypes
{
    [TestClass]
    public class StringTest
    {

        [TestMethod]
        public void CheckIfStringIsEmpty()
        {
            var input = "   ";
            var condition = string.IsNullOrWhiteSpace(input) == true;

            Assert.IsTrue(condition);
        }
    }
}
