using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ZaripovEO.Sprint3.Task1.V3.Lib;

namespace Tyuiu.ZaripovEO.Sprint3.Task1.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int startValue = 1;
            int stopValue = 10;

            double res = ds.GetMultiplySeries(startValue, stopValue);

            double wait = 24589.408;
            Assert.AreEqual(wait, res);
        }
    }
}
