using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Security.Cryptography;
using System.Text;

namespace UnitTestProject.PrimitiveTypes
{
    [TestClass]
    public class RandomTest
    {

        [TestMethod]
        public void RandomId()
        {
            Random random = new Random();
            var output = random.Next(100);

            for(int i = 0;i < 100;i++)
                Debug.WriteLine(random.Next(100));
        }

        [TestMethod]
        public void RandomSecureId()
        {
            using (RNGCryptoServiceProvider random = new RNGCryptoServiceProvider())
            {
                byte[] randomBytes = new byte[4];

                random.GetBytes(randomBytes);
                int result = BitConverter.ToInt32(randomBytes, 0);
            }
                
        }
    }
}
