using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace UnitTestProject.PrimitiveTypes
{
    [TestClass]
    public class DateTimeTest
    {

        [TestMethod]
        public void StringToDateTime()
        {
            var input = "17/08/1990 BRA"; //BRA is just a random string
            var result = DateTime.ParseExact(input, "dd/MM/yyyy BRA", null);

            Debug.WriteLine(result);
        }
    }
}
