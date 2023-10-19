using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ZaripovEO.Sprint3.Task3.V3.Lib;

namespace Tyuiu.ZaripovEO.Sprint3.Task3.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            string str = "cvbmzff orffgtrr dkfvfffdr";
            char chr = 'f';

            double res = ds.GetMinCharCount(str, chr);

            int wait = 3;
            Assert.AreEqual(wait, res);
        }
    }
}
